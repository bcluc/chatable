using Blazored.LocalStorage;
using Chatable;
using Chatable.Data.Entitles.Model;
using Chatable.DI;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<AppData>();
builder.Services.AddScoped<CurrentUser>();

builder.Services.AddScoped<CallHubManager>();
builder.Services.AddScoped<MessageHubManager>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});


app.Run();
