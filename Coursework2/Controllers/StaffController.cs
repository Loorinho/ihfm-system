using Coursework2.Enums;
using Coursework2.Models;
using Coursework2.Models.Observer;
using Coursework2.Models.Staff;
using Coursework2.Views;

namespace Coursework2.Controllers;

public class StaffController: IObserver
{
    private readonly SystemClient systemClient;
    private StaffView _view;

    public StaffController(SystemClient client)
    {
        systemClient = client;
        systemClient.AddSubscriber(this);
    }
    public void Update(ISubject subject)
    {
        GetAllStaff();
    }

    public void SetView(StaffView view)
    {
        _view = view;
        GetAllStaff();
    }

    public void AddStaff(string type, string name, GenderEnum gender)
    {
        systemClient.AddStaff(type, name, gender); 
    }

    private void GetAllStaff()
    {
        var staff = systemClient.GetStaff();
        // return staff;
        _view.SetStaff(staff);
    }
}