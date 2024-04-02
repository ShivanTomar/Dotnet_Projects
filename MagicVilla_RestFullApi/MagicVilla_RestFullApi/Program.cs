using MagicVilla_RestFullApi;
using MagicVilla_RestFullApi.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MagicVilla_RestFullApi.Repository.IRepostiory;
using MagicVilla_RestFullApi.Repository;
using MagicVilla_RestFullApi.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

//ADD SERVICES TO THE CONTAINER
builder.Services.AddDbContext<ApplicationDBContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("VilaConnection"));
});

//Adding Automapper services
builder.Services.AddAutoMapper(typeof(MappingConfig));

//Adding Repository
builder.Services.AddScoped<IVillaRepository, VillaRepository>();
builder.Services.AddScoped<IVillaNumberRepository, VillaNumberRepository>();


builder.Services.AddControllers(option => {
   // option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();


//AUTOMAPPING
builder.Services.AddAutoMapper(typeof(MappingConfig));

// Learn more about configuring Swagger/openAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
