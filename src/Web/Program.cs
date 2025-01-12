using Carter;
using Scalar.AspNetCore;
using Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddWeb(builder.Configuration);
builder.Services.AddCarter();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();
// /scalar/v1
app.MapScalarApiReference(opt =>
{
    opt.WithTitle("URL Shortener API")
        .WithDarkMode(true)
        .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
});

app.UseHttpsRedirection();

app.MapCarter();
await app.RunAsync();