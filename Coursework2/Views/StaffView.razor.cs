using Coursework2.Controllers;
using Coursework2.Enums;
using Coursework2.Models.Staff;
using Microsoft.AspNetCore.Components;

namespace Coursework2.Views;

public partial class StaffView: ComponentBase
{
    private string name = "";
    private GenderEnum gender;

    private List<IStaff> allStaff;
    
    [Inject] public StaffController StaffController { get; set; } = default;

    protected override void OnInitialized()
    {
        StaffController.SetView(this);
    }

    public void CreateStaff(string type, string name, GenderEnum gender)
    {
        StaffController.AddStaff(type, name, gender);
    }

    public void SetStaff(List<IStaff> _staff)
    {
        allStaff = _staff;
    }
}