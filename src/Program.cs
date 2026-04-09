using CalculadoraTeste.Components;
using CalculadoraTeste.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CalculationStateService>();

builder.Services.AddHttpClient("CalcApi", client =>
{
    client.BaseAddress = new Uri("http://pekus.ddns.net/");
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();


app.UseHsts()
    .UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();