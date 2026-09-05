using FluentAssertions;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Tests;

public sealed class TaskItemTests
{
    [Fact]
    public void Create_should_build_valid_task()
    {
        var task = TaskItem.Create("Learn CQRS", "Practice command/query separation", 2);
        task.Title.Should().Be("Learn CQRS");
        task.IsCompleted.Should().BeFalse();
    }

    [Fact]
    public void Complete_should_set_completion_state_and_timestamp()
    {
        var task = TaskItem.Create("Ship API", null, 1);
        task.Complete();
        task.IsCompleted.Should().BeTrue();
        task.CompletedAtUtc.Should().NotBeNull();
    }

    [Fact]
    public void Completed_task_cannot_be_updated()
    {
        var task = TaskItem.Create("Ship API", null, 1);
        task.Complete();
        var action = () => task.Update("Changed", null, 3);
        action.Should().Throw<InvalidOperationException>();
    }
}
