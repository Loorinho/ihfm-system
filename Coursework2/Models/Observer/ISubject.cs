namespace Coursework2.Models.Observer;

public interface ISubject
{
    public void AddSubscriber(IObserver observer);
    public void RemoveSubscriber(IObserver observer);
    public void NotifySubscribers();
}