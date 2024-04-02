using RoutingExample.NewFolder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(options => {
    options.ConstraintMap.Add("months", typeof(MonthCoustomConstrain));
});

var app = builder.Build();

//enable routing
app.UseRouting();

//app.UseEndpoints(endpoints => {
    //app.Map("map1", async (context) =>
    //{
    //    await context.Response.WriteAsync("IN MAP 1");
    //});

    //app.Map("map2", async (context) =>
    //{
    //    await context.Response.WriteAsync("IN MAP 2");
    //});

    app.Map("files/{filename}.{extension}", async
        context =>
    {
     string? fileName=   Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);

        await context.Response.WriteAsync($"In Files -{fileName} - {extension}");
    });

    app.Map("employee/profile/{EmployeeName=shivani}", async
      context =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
        await context.Response.WriteAsync($"In Employee Profiles -{employeeName}");
    });


//});


app.Map("employee/{EmployeeName=shivani}", async
      context =>
{
    string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
    await context.Response.WriteAsync($"In Employee Profiles -{employeeName}");
});

app.Map("emp/{EmployeeName?}", async
      context =>
{
    string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
    await context.Response.WriteAsync($"In Employee Profiles -{employeeName}");
});

app.Map("sales-report/{year:int:min(1900)}/{month:months}", async context => {
    int year = Convert.ToInt32(context.Request.RouteValues["year"]);
    string? month = Convert.ToString(context.Request.RouteValues["month"]);
    await context.Response.WriteAsync($"Sales Report -{year} -{month}");
});




app.Run(async context => {
    await context.Response.WriteAsync($"Request recive at{context.Request.Path}");
});

app.Run();