using Coursework2.Enums;
using Coursework2.Models;
using Coursework2.Models.Observer;
using Coursework2.Views;

namespace Coursework2.Controllers;

public class StaffRegisterController: IObserver
{
    private readonly SystemClient systemClient;
    private StaffRegisterView _view;

    public StaffRegisterController(SystemClient client)
    {
        systemClient = client;
        systemClient.AddSubscriber(this);
    }
    
    public void SetView(StaffRegisterView view)
    {
        _view = view;
        // GetAllStaff();
    }


    public void AddStaff(StaffEnum type, string name, GenderEnum gender, ProfessionEnum profession)
    {
        systemClient.AddStaff(type, name, gender, profession); 
    }

    public void Update(ISubject subject)
    {
        
    }
}