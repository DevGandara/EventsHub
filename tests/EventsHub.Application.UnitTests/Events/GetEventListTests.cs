using EventsHub.Application.Events.Queries;

namespace EventsHub.Application.UnitTests.Events;

[TestFixture]
public class GetEventListTests : HandlerTestBase
{
    [Test]
    public async Task Handle_WhenNoEventsExist_ReturnsEmptyListAsync()
    {
        // Arrange
        var handler = new GetEventList.Handler(Context);
        var query = new GetEventList.Query();

        // Act
        var result = await handler.Handle(query, CancellationToken.None);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public async Task Handle_WhenEventsExist_ReturnsAllOfThemAsync()
    {
        // Arrange
        await SeedAsync("First");
        await SeedAsync("Second");
        await SeedAsync("Third");
        var handler = new GetEventList.Handler(Context);
        var query = new GetEventList.Query();

        // Act
        var result = await handler.Handle(query, CancellationToken.None);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Has.Count.EqualTo(3));
            Assert.That(result.Select(e => e.Title), Is.EquivalentTo(new[] { "First", "Second", "Third" }));
        });
    }

    [Test]
    public async Task Handle_WhenTokenIsAlreadyCancelled_ThrowsOperationCanceledExceptionAsync()
    {
        // Arrange
        await SeedAsync("Any");
        var handler = new GetEventList.Handler(Context);
        var query = new GetEventList.Query();
        using var cts = new CancellationTokenSource();
        await cts.CancelAsync();

        // Act & Assert
        Assert.That(
            async () => await handler.Handle(query, cts.Token),
            Throws.InstanceOf<OperationCanceledException>());
    }
}
