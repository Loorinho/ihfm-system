using Coursework2.Enums;
using Coursework2.Models.Observer;
using Coursework2.Models.Repositories.Staff;
using Coursework2.Models.Staff;
using Microsoft.AspNetCore.Components;

namespace Coursework2.Models;

public class SystemClient: ISubject
{
    private List<IObserver> _observers = new();
    private IStaffRepository _staffRepository;
    

    public SystemClient(IStaffRepository _staffRepo)
    {
        _staffRepository = _staffRepo;
    }

    public void AddStaff(string type, string name, GenderEnum gender)
    {
        IStaff staff = StaffFactory.CreateStaff(type,name, gender);
        _staffRepository.CreateStaff(staff);
    }
    
    public void AddSubscriber(IObserver observer)
    {
       _observers.Add(observer);
    }

    public void RemoveSubscriber(IObserver observer)
    {
        _observers.Remove(observer);

    }

    public void NotifySubscribers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
            
        }
    }

    public List<IStaff> GetStaff()
    {
        var staff = _staffRepository.GetStaff();
        return staff;
    }
}