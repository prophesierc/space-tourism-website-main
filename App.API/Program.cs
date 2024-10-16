using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins(
            "http://localhost", 
            "https://prophesierc.github.io")
                            .AllowAnyHeader()
                            .AllowAnyMethod());
});
app.UseCors("AllowSpecificOrigin");

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "App.API",
        Description = "test",
        Version = "v1"
    });
});
var app = builder.Build();

if (app.Environment.IsDevelopment()) // Hosting environment: Development
{
    

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "App.API V1");
    });    
}

app.MapGet("/", () => "Hello World!");

app.Run();
