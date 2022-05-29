using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OnlinesShop.Application.Interfaces;
using OnlinesShop.Application.Services;
using OnlinesShop.Infrastructure.Contexts;

using OnlinesShop.Application.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
});


// Register DbContext
string cString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<OnlineShopDbContext>(options => options.UseSqlServer(cString));

// Register Services
builder.Services.AddScoped<IProductService, ProductService>();


var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperConfig());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);



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
