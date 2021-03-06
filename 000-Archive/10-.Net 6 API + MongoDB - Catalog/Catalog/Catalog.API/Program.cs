using Catalog.API.Repositories;
using Catalog.API.Repositories.Implementations;
using Catalog.API.Settings;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject dependencies
BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(BsonType.String));

var mongoDbSettings = builder.Configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();
builder.Services.AddSingleton<IMongoClient>(q =>
{
    return new MongoClient(mongoDbSettings.ConnectionString);
});

builder.Services.AddHealthChecks().
    AddMongoDb(
    mongoDbSettings.ConnectionString, 
    name: "mongodb", 
    timeout: TimeSpan.FromSeconds(3),
    tags: new[] { "ready"}
    );

//builder.Services.AddSingleton<IItemsRepository, InMemItemsRepository>();
builder.Services.AddSingleton<IItemsRepository, MongoDbItemsRepository>();

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

app.MapHealthChecks("/health/ready", new HealthCheckOptions
{
    Predicate = (check) => check.Tags.Contains("tags")
});

app.MapHealthChecks("/health/live", new HealthCheckOptions
{
    Predicate = (_) => false
});

app.Run();
