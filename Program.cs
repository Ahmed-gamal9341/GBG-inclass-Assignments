public interface INotificationChannel
{
    void Send(string message);
}

public interface IMessageLogger
{
    void Log(string message);
}


public class EmailChannel : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

public class SmsChannel : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}

public class FileLogger : IMessageLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}


public class NotificationService
{
    private readonly INotificationChannel _channel;
    private readonly IMessageLogger _logger;

    public NotificationService(
        INotificationChannel channel,
        IMessageLogger logger)
    {
        _channel = channel;
        _logger = logger;
    }

    public void Send(string message)
    {
        _channel.Send(message);
        _logger.Log(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessageLogger logger = new FileLogger();

        List<INotificationChannel> channels = new List<INotificationChannel>
        {
            new EmailChannel(),
            new SmsChannel()
        };

        string message = "Hello from Session 7!";

        // No if else is needed because both classes implement Inotificationchannel polymorphism calls the correct method

        foreach (INotificationChannel channel in channels)
        {
            NotificationService service = new NotificationService(channel, logger);

            service.Send(message);

            Console.WriteLine();
        }
    }
}
