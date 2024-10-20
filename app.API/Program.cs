using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.RateLimiting;

public class API
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Rate Limiting
        builder.Services.AddRateLimiter(options =>
        {
            options.AddFixedWindowLimiter("fixed", config =>
            {
                config.PermitLimit = 4;
                config.Window = TimeSpan.FromSeconds(12);
                config.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                config.QueueLimit = 2;
            });
        });

        builder.Services.AddControllers();

        // CORS
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                builder => builder.WithOrigins(
                    "http://localhost",
                    "https://prophesierc.github.io",
                    "https://prophesierc.site")
                                    .AllowAnyHeader()
                                    .AllowAnyMethod());
        });

        // Logging
        builder.Logging.AddConsole();

        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Space Tourism API",
                Description = "Space Tourism API for fetching space data",
                Version = "v1"
            });
        });

        var app = builder.Build();

        // Apply CORS policy
        app.UseCors("AllowSpecificOrigin");

        // Use rate limiting
        app.UseRateLimiter();
        
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Space Tourism API v1");
        });

        // Endpoints
        app.MapGet("/crew", async (ILogger<API> logger) =>
        {
            logger.LogInformation("Received request for crew data");
            var jsonData = await File.ReadAllTextAsync("wwwroot/data/crew.json");
            return Results.Json(JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData));
        }).RequireRateLimiting("fixed");

        app.MapGet("/destinations", async (ILogger<API> logger) =>
        {
            logger.LogInformation("Received request for destinations data");
            var jsonData = await File.ReadAllTextAsync("wwwroot/data/destinations.json");
            return Results.Json(JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData));
        }).RequireRateLimiting("fixed");

        app.MapGet("/technology", async (ILogger<API> logger) =>
        {
            logger.LogInformation("Received request for technology data");
            var jsonData = await File.ReadAllTextAsync("wwwroot/data/technology.json");
            return Results.Json(JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData));
        }).RequireRateLimiting("fixed");

        Console.WriteLine($"Environment: {app.Environment.EnvironmentName}");
        app.Run();
    }
}
