using Coursework2.Controllers;
using Coursework2.Enums;
using Coursework2.Models.Staff;
using Microsoft.AspNetCore.Components;

namespace Coursework2.Views;

public partial class StaffRegisterView: ComponentBase
{
    private string name;
    private GenderEnum gender;
    private  StaffEnum type;
    private ProfessionEnum profession;

    // private List<IStaff> allStaff;
    
    [Inject] public StaffRegisterController StaffRegisterController { get; set; } = default;

    protected override void OnInitialized()
    {
        StaffRegisterController.SetView(this);
    }
    
    private void CreateStaff()
    {
        Console.WriteLine("We are in");
        StaffRegisterController.AddStaff(type, name, gender, profession);
    }
    

}