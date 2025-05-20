using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:9101");

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()     // Allow all origins (or specify a specific origin)
              .AllowAnyMethod()     // Allow all HTTP methods (GET, POST, etc.)
              .AllowAnyHeader();    // Allow all headers
    });
});

var app = builder.Build();

// Use CORS
app.UseCors("AllowAllOrigins");

app.MapControllers();

await app.RunAsync();