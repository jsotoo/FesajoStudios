using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using FesajoStudios.Client.Auth;
using FesajoStudios.Client.Proxy.Interfaces;
using FesajoStudios.Client.Proxy.Services;
using FesajoStudios.Client;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredToast();
builder.Services.AddSweetAlert2();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();



builder.Services.AddScoped<IUserProxy, UserProxy>();

// Habilitamos el contexto de seguridad en Blazor
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationService>();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
