using MongoDB.Bson;
using MongoDB.Driver;
using Raven.Client.Documents;
using TwitterAPI;
using TwitterAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

 var mongoClient = new MongoClient("mongodb://localhost:27017");
var mongoDatabase = mongoClient.GetDatabase("Twitter");
var tweets = mongoDatabase.GetCollection<BsonDocument>("Tweets");
var users = mongoDatabase.GetCollection<BsonDocument>("Users");

using var store = new DocumentStore
{
    Urls = new[] { "http://localhost:8080/" },
    Database = "Twitter"
}.Initialize();

//new Twitter_Search().Execute(store);

builder.Services.AddSingleton(store);
builder.Services.AddSingleton(Tuple.Create(tweets, users));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseAuthorization();

app.MapControllers();

app.Run();
