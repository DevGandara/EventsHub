using Domain;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace EventsHub.Application.UnitTests.Events;

public abstract class HandlerTestBase
{
    private SqliteConnection _connection = null!;

    protected AppDbContext Context { get; private set; } = null!;

    [SetUp]
    public async Task BaseSetUpAsync()
    {
        // An in-memory SQLite database lives only as long as its connection, so keep it open for the test.
        _connection = new SqliteConnection("Data Source=:memory:");
        _connection.Open();

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite(_connection)
            .Options;

        Context = new AppDbContext(options);
        await Context.Database.EnsureCreatedAsync();
    }

    [TearDown]
    public async Task BaseTearDownAsync()
    {
        await Context.DisposeAsync();
        await _connection.DisposeAsync();
    }

    protected static Event NewEvent(string? id = null, string title = "Test event") => new()
    {
        Id = id ?? Guid.NewGuid().ToString(),
        Title = title,
        Description = "Test description",
        Category = "music",
        City = "Merida",
        Venue = "Test venue",
        Date = DateTime.UtcNow.AddDays(7),
    };

    /// <summary>
    /// Inserts an event with the given title and detaches it, so the handler under test
    /// loads the row from the database instead of from the change tracker.
    /// </summary>
    protected async Task<Event> SeedAsync(string title)
    {
        var @event = NewEvent(title: title);
        Context.Events.Add(@event);
        await Context.SaveChangesAsync();
        Context.ChangeTracker.Clear();
        return @event;
    }
}
