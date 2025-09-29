using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add CORS policies
builder.Services.AddCors(options =>
{
    options.AddPolicy("OpenPolicy", policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

    options.AddPolicy("RestrictedPolicy", policy =>
        policy.WithOrigins("http://localhost:4200") // only Angular allowed
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

// Pick the policy you want to test
app.UseCors("RestrictedPolicy");

// Sample API endpoint
app.MapGet("/hello", () => "Hello from API with CORS!");

app.Run("http://localhost:5001"); // fixed port


