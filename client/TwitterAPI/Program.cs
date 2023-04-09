using Raven.Client.Documents;
using TwitterAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);


using var store = new DocumentStore
{
    Urls = new[] { "http://localhost:8080/" },
    Database = "Twitter"
}.Initialize();

//new Twitter_Search().Execute(store);

builder.Services.AddSingleton(store);
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
