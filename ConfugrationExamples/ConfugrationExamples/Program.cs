using ConfugrationExamples;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//supply an object of weatherapioptions() as a service
builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("weatherapi"));
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
//app.UseEndpoints(async endpoints =>
//{
//    _ = endpoints.Map("/config", async context =>
//    {
//        await context.Response.WriteAsync(
//        app.Configuration["myKey"]+"\n");

//        await context.Response.WriteAsync(
//        app.Configuration.GetValue<string>("MyKey")+"\n");

//        await context.Response.WriteAsync(
//        app.Configuration.GetValue<int>("x",10)+"\n");
//    });
//});

app.Run();
