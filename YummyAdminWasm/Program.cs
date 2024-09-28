using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using YummyAdminWasm;
using YummyAdminWasm.Auth;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:8080/api/") });
builder.Services.AddScoped<UserAuth>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
