namespace House_management.Observer;

public class NotificationService : IObserver
{
    public void Update(string message)
    {
        // Отображение сообщения в UI
        Console.WriteLine(message);
    }
}