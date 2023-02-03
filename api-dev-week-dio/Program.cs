using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using src.Persistence;
using src.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("dbContracts"));

builder.Services.AddScoped<DatabaseContext>();
builder.Services.AddScoped<PersonRepository>();
builder.Services.AddScoped<PersonService>();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
  options.SwaggerDoc("v1", new OpenApiInfo
  {
    Version = "v1",
    Title = "Pottencial Dev Week",
    Description = "Este projeto foi realizado pela DIO em parceria com a Pottencial durante o evento Pottencial Dev Week. É uma API construída em .NET 6 com ASP.NET Web API para cadastrar pessoas e os contratos adquiridos por elas. "
  });

  var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
  options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

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

app.CreateDbIfNotExists();

app.Run();
