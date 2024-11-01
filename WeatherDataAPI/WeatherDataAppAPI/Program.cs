using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using WeatherDataAppAPI.Repositories;
using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Repositories; // Add this to reference your repository


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IChangePW, ChangePWServ>();
builder.Services.AddDbContext<DBContextClass>();

builder.Services.AddScoped<INewUser, NewUserServ>();
builder.Services.AddScoped<IInsertLocation, InsertLocationServ>();
builder.Services.AddDbContext<DBContextClass>();

builder.Services.AddScoped<IWeatherDataAdd, WeatherDataAddServ>();
builder.Services.AddScoped<IWeatherDataDelete, WeatherDataDeleteServ>();
builder.Services.AddDbContext<DBContextClass>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();

// Add Swagger/OpenAPI configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the WeatherRepository as a service for dependency injection
builder.Services.AddScoped<WeatherRepository>(); // This is needed for your repository

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // Make sure authentication middleware is called
app.UseAuthorization();

app.MapControllers();

app.Run();
