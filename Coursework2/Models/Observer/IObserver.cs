namespace Coursework2.Models.Observer;

public interface IObserver
{
    public void Update(ISubject subject);
}