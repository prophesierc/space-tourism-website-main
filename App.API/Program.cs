var builder = WebApplication.CreateBuilder(args);
var apiKey = builder.Configuration["ApiSettings:ApiKey"];

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:5173", "https://prophesierc.github.io")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});


builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();