using Microsoft.EntityFrameworkCore;
using TaskFlow.Application.Abstractions;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Infrastructure.Persistence;

public sealed class TaskRepository(AppDbContext db) : ITaskRepository
{
    public Task<TaskItem?> GetAsync(Guid id, CancellationToken cancellationToken) => db.Tasks.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task<(IReadOnlyList<TaskItem> Items, int Total)> SearchAsync(int page, int pageSize, bool? completed, CancellationToken cancellationToken)
    {
        var query = db.Tasks.AsNoTracking().AsQueryable();
        if (completed.HasValue) query = query.Where(x => x.IsCompleted == completed.Value);
        var total = await query.CountAsync(cancellationToken);
        var items = await query.OrderByDescending(x => x.CreatedAtUtc).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);
        return (items, total);
    }

    public async Task AddAsync(TaskItem task, CancellationToken cancellationToken) => await db.Tasks.AddAsync(task, cancellationToken);
    public void Remove(TaskItem task) => db.Tasks.Remove(task);
    public Task SaveChangesAsync(CancellationToken cancellationToken) => db.SaveChangesAsync(cancellationToken);
}
