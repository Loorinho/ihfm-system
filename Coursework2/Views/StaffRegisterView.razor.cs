// using Coursework2.Controllers;
// using Coursework2.Enums;
// using Coursework2.Models.Staff;
// using Microsoft.AspNetCore.Components;
//
// namespace Coursework2.Views;
//
// public partial class StaffRegisterView: ComponentBase
// {
//     public string Name { get; set; } = "";
//     public GenderEnum Gender { get; set; }
//
//     private List<IStaff> allStaff;
//     
//     [Inject] public StaffController StaffController { get; set; } = default;
//
//     protected override void OnInitialized()
//     {
//         StaffController.SetView(this);
//     }
//     
//     // public void CreateStaff()
//     // {
//     //     StaffController.AddStaff(type, name, gender, profession);
//     // }
//     
//
// }