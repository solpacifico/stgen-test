using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using stgen_test;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var licenseKey = "Ngo9BigBOggjHTQxAR8/V1NHaF1cWWhIfEx+WmFZfV1gd19HYFZTQGY/P1ZhSXxQd0djWH5bcXRXQmBYWUQ=";
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<StateContainer>();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);



await builder.Build().RunAsync();
