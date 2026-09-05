using FluentValidation;
using MediatR;
using TaskFlow.Application.Abstractions;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Features.Tasks;

public sealed record TaskDto(Guid Id, string Title, string? Description, int Priority, bool IsCompleted, DateTime CreatedAtUtc, DateTime? CompletedAtUtc)
{
    public static TaskDto From(TaskItem x) => new(x.Id, x.Title, x.Description, x.Priority, x.IsCompleted, x.CreatedAtUtc, x.CompletedAtUtc);
}

public sealed record CreateTaskCommand(string Title, string? Description, int Priority) : IRequest<TaskDto>;
public sealed class CreateTaskValidator : AbstractValidator<CreateTaskCommand>
{
    public CreateTaskValidator() { RuleFor(x => x.Title).NotEmpty().MaximumLength(200); RuleFor(x => x.Priority).InclusiveBetween(1, 5); }
}
public sealed class CreateTaskHandler(ITaskRepository repository) : IRequestHandler<CreateTaskCommand, TaskDto>
{
    public async Task<TaskDto> Handle(CreateTaskCommand request, CancellationToken ct)
    {
        var task = TaskItem.Create(request.Title, request.Description, request.Priority);
        await repository.AddAsync(task, ct);
        await repository.SaveChangesAsync(ct);
        return TaskDto.From(task);
    }
}

public sealed record GetTaskQuery(Guid Id) : IRequest<TaskDto?>;
public sealed class GetTaskHandler(ITaskRepository repository) : IRequestHandler<GetTaskQuery, TaskDto?>
{
    public async Task<TaskDto?> Handle(GetTaskQuery request, CancellationToken ct) =>
        (await repository.GetAsync(request.Id, ct)) is { } task ? TaskDto.From(task) : null;
}

public sealed record SearchTasksQuery(int Page = 1, int PageSize = 20, bool? Completed = null) : IRequest<PagedResult<TaskDto>>;
public sealed record PagedResult<T>(IReadOnlyList<T> Items, int Page, int PageSize, int Total);
public sealed class SearchTasksHandler(ITaskRepository repository) : IRequestHandler<SearchTasksQuery, PagedResult<TaskDto>>
{
    public async Task<PagedResult<TaskDto>> Handle(SearchTasksQuery request, CancellationToken ct)
    {
        var page = Math.Max(1, request.Page);
        var size = Math.Clamp(request.PageSize, 1, 100);
        var result = await repository.SearchAsync(page, size, request.Completed, ct);
        return new PagedResult<TaskDto>(result.Items.Select(TaskDto.From).ToList(), page, size, result.Total);
    }
}

public sealed record UpdateTaskCommand(Guid Id, string Title, string? Description, int Priority) : IRequest<TaskDto?>;
public sealed class UpdateTaskValidator : AbstractValidator<UpdateTaskCommand>
{
    public UpdateTaskValidator() { RuleFor(x => x.Title).NotEmpty().MaximumLength(200); RuleFor(x => x.Priority).InclusiveBetween(1, 5); }
}
public sealed class UpdateTaskHandler(ITaskRepository repository) : IRequestHandler<UpdateTaskCommand, TaskDto?>
{
    public async Task<TaskDto?> Handle(UpdateTaskCommand request, CancellationToken ct)
    {
        var task = await repository.GetAsync(request.Id, ct);
        if (task is null) return null;
        task.Update(request.Title, request.Description, request.Priority);
        await repository.SaveChangesAsync(ct);
        return TaskDto.From(task);
    }
}

public sealed record CompleteTaskCommand(Guid Id) : IRequest<TaskDto?>;
public sealed class CompleteTaskHandler(ITaskRepository repository) : IRequestHandler<CompleteTaskCommand, TaskDto?>
{
    public async Task<TaskDto?> Handle(CompleteTaskCommand request, CancellationToken ct)
    {
        var task = await repository.GetAsync(request.Id, ct);
        if (task is null) return null;
        task.Complete();
        await repository.SaveChangesAsync(ct);
        return TaskDto.From(task);
    }
}
