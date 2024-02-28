using WebApi;
using WebApi.ControllersImpl;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDataController, DataControllerImpl>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers().AllowAnonymous();
});

app.Run();
