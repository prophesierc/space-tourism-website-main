using DotNetEnv;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.OpenApi.Models;
using System.Net; 
using System.Text.Json;
using System.Threading.RateLimiting;

public class API
{
    public static void Main(string[] args)
    {
        Env.Load();

        var builder = WebApplication.CreateBuilder(args);

        var certPath = Env.GetString("CERT_PATH");
        var privateKeyPath = Env.GetString("PRIVATE_KEY_PATH");

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
                    "http://localhost:5173",
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

        // Kestrel server
        builder.WebHost.ConfigureKestrel(options =>
        {
            options.Listen(IPAddress.Any, 5001, listenOptions =>
            {
                listenOptions.UseHttps(certPath, privateKeyPath);
            });
        });

        var app = builder.Build();

        // Serve static files from wwwroot folder
        app.UseStaticFiles();

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