using ControllerApp.Controller;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient<HomeController>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

//app.UseRouting();
//app.UseEndpoints(endpoints => {
//    endpoints.MapControllers(); 
//});

app.Run();
