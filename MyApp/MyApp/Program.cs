using System;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("Hello");
    await next(context);
});
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("Hello again");
    await next(context);
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("HIIIII");
});

app.Run();
