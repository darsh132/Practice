using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Abstractions;

public interface ITaskRepository
{
    Task<TaskItem?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task<(IReadOnlyList<TaskItem> Items, int Total)> SearchAsync(int page, int pageSize, bool? completed, CancellationToken cancellationToken);
    Task AddAsync(TaskItem task, CancellationToken cancellationToken);
    void Remove(TaskItem task);
    Task SaveChangesAsync(CancellationToken cancellationToken);
}
