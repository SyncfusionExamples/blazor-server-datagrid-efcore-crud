using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebApp.Shared.Services;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(http => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ClientServices>();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCf1FpR2dGfV5yd0VFalhXTnNbUiweQnxTdEZiW31ecH1VQmRcWEZ3Vw==");

await builder.Build().RunAsync();
