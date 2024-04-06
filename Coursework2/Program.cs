using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Coursework2;
using Coursework2.Controllers;
using Coursework2.Models;
using Coursework2.Models.Repositories.Staff;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<SystemClient>();
builder.Services.AddScoped<IStaffRepository, StaffRepository>();
builder.Services.AddScoped<StaffController>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();