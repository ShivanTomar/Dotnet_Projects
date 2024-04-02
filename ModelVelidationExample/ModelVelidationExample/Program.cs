using Microsoft.Extensions.Options;
//using ModelVelidationExample.CustomModelBinders;
using ModelVelidationExample.CustomModelBinders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(Options=> {
    Options.ModelBinderProviders.Insert(0, new PersonBinderProvider());
});
builder.Services.AddControllers().AddXmlSerializerFormatters();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
