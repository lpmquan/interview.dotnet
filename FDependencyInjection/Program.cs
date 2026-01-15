
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// What is the issue with the following code snippet regarding dependency injection lifetimes?
services.AddScoped<RequestTracker>();
services.AddSingleton<AppLogger>();

public class RequestTracker
{
    public Guid Id { get; } = Guid.NewGuid();
}

public class AppLogger
{
    private readonly RequestTracker _tracker;

    public AppLogger(RequestTracker tracker)
    {
        _tracker = tracker;
    }

    public void Log()
    {
        Console.WriteLine(_tracker.Id);
    }
}

