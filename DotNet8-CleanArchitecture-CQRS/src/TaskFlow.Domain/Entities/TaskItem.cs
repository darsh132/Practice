namespace TaskFlow.Domain.Entities;

public sealed class TaskItem
{
    private TaskItem() { }

    public Guid Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public int Priority { get; private set; }
    public bool IsCompleted { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime? CompletedAtUtc { get; private set; }

    public static TaskItem Create(string title, string? description, int priority)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required.", nameof(title));
        if (title.Length > 200) throw new ArgumentException("Title cannot exceed 200 characters.", nameof(title));
        if (priority is < 1 or > 5) throw new ArgumentOutOfRangeException(nameof(priority));

        return new TaskItem
        {
            Id = Guid.NewGuid(),
            Title = title.Trim(),
            Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim(),
            Priority = priority,
            CreatedAtUtc = DateTime.UtcNow
        };
    }

    public void Update(string title, string? description, int priority)
    {
        if (IsCompleted) throw new InvalidOperationException("A completed task cannot be edited.");
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required.", nameof(title));
        if (priority is < 1 or > 5) throw new ArgumentOutOfRangeException(nameof(priority));
        Title = title.Trim();
        Description = string.IsNullOrWhiteSpace(description) ? null : description.Trim();
        Priority = priority;
    }

    public void Complete()
    {
        if (IsCompleted) return;
        IsCompleted = true;
        CompletedAtUtc = DateTime.UtcNow;
    }
}
