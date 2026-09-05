using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using TaskFlow.Application.Abstractions;
using TaskFlow.Application.Behaviors;
using TaskFlow.Application.Features.Tasks;
using TaskFlow.Infrastructure.Persistence;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting TaskFlow API");

    var builder = WebApplication.CreateBuilder(args);
    builder.Host.UseSerilog((context, services, configuration) => configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext()
        .Enrich.WithProperty("Application", "TaskFlow.Api"));

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddProblemDetails();
    builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
    builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("Default") ?? "Data Source=taskflow.db"));
    builder.Services.AddScoped<ITaskRepository, TaskRepository>();
    builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateTaskCommand).Assembly));
    builder.Services.AddValidatorsFromAssembly(typeof(CreateTaskCommand).Assembly);
    builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    builder.Services.AddHealthChecks().AddDbContextCheck<AppDbContext>();

    var app = builder.Build();
    app.UseExceptionHandler();
    app.UseSerilogRequestLogging(options =>
    {
        options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
        {
            diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);
            diagnosticContext.Set("UserAgent", httpContext.Request.Headers.UserAgent.ToString());
        };
    });

    if (app.Environment.IsDevelopment()) { app.UseSwagger(); app.UseSwaggerUI(); }
    app.MapHealthChecks("/health");

    var tasks = app.MapGroup("/api/tasks").WithTags("Tasks");
    tasks.MapGet("/", async (int? page, int? pageSize, bool? completed, ISender sender, CancellationToken ct) =>
        Results.Ok(await sender.Send(new SearchTasksQuery(page ?? 1, pageSize ?? 20, completed), ct)));

    tasks.MapGet("/{id:guid}", async (Guid id, ISender sender, CancellationToken ct) =>
    {
        var result = await sender.Send(new GetTaskQuery(id), ct);
        return result is null ? Results.NotFound() : Results.Ok(result);
    });

    tasks.MapPost("/", async (CreateTaskCommand command, ISender sender, CancellationToken ct) =>
    {
        var result = await sender.Send(command, ct);
        return Results.Created($"/api/tasks/{result.Id}", result);
    });

    tasks.MapPut("/{id:guid}", async (Guid id, UpdateTaskRequest request, ISender sender, CancellationToken ct) =>
    {
        var result = await sender.Send(new UpdateTaskCommand(id, request.Title, request.Description, request.Priority), ct);
        return result is null ? Results.NotFound() : Results.Ok(result);
    });

    tasks.MapPost("/{id:guid}/complete", async (Guid id, ISender sender, CancellationToken ct) =>
    {
        var result = await sender.Send(new CompleteTaskCommand(id), ct);
        return result is null ? Results.NotFound() : Results.Ok(result);
    });

    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await db.Database.EnsureCreatedAsync();
    }

    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "TaskFlow API terminated unexpectedly");
}
finally
{
    await Log.CloseAndFlushAsync();
}

public sealed record UpdateTaskRequest(string Title, string? Description, int Priority);

public partial class Program { }
