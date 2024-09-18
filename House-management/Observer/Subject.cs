namespace House_management.Observer;

public abstract class Subject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    protected void NotifyObservers(string message)
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(message);
        }
    }
}