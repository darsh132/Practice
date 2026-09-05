using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Application.Abstractions;
using TaskFlow.Application.Behaviors;
using TaskFlow.Application.Features.Tasks;
using TaskFlow.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

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
    Results.Created($"/api/tasks/{{id}}", await sender.Send(command, ct)));

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

app.Run();

public sealed record UpdateTaskRequest(string Title, string? Description, int Priority);
