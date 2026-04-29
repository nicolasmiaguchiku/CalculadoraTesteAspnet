using CalculadoraTeste.Components;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("CalcApi", client =>
{
    client.BaseAddress = new Uri("http://intranet.pekus.com.br/calcapi/api/");
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient()
    .AddFluentUIComponents();

var app = builder.Build();

app.UseHsts()
    .UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();