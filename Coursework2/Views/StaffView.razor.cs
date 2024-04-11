using Coursework2.Controllers;
using Coursework2.Enums;
using Coursework2.Models.Staff;
using Microsoft.AspNetCore.Components;

namespace Coursework2.Views;

public partial class StaffView: ComponentBase
{
    private string Name { get; set; }
    private GenderEnum Gender { get; set; }

    private List<IStaff> allStaff;
    [Inject] public StaffController StaffController { get; set; } = default;

    protected override void OnInitialized()
    {
        StaffController.SetView(this);
    }

    public void CreateStaff(StaffEnum type, string name, GenderEnum gender, ProfessionEnum profession)
    {
        StaffController.AddStaff(type, name, gender, profession);
    }

    public void SetStaff(List<IStaff> _staff)
    {
        allStaff = _staff;
    }
}