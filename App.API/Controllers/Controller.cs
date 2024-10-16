using App.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace App.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpaceDataController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        public required string _apiKey { get; init; }

        public SpaceDataController(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _apiKey = configuration["ApiSettings:ApiKey"] ?? throw new InvalidOperationException("API Key not found in configuration.");
        }

        [HttpGet]
        public async Task<ActionResult<SpaceData>> GetSpaceData([FromHeader(Name = "X-API-Key")] string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey) || apiKey != _apiKey)
            {
                return Unauthorized("Invalid or missing API key.");
            }

            var filePath = Path.Combine(_environment.WebRootPath, "data", "data.json");

            if (System.IO.File.Exists(filePath))
            {
                var json = await System.IO.File.ReadAllTextAsync(filePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                try
                {
                    var spaceData = JsonSerializer.Deserialize<SpaceData>(json, options);

                    if (spaceData != null)
                    {
                        return Ok(spaceData);
                    }

                    return BadRequest("Failed to deserialize the data");
                }
                catch (JsonException ex)
                {
                    return BadRequest($"Error deserializing JSON: {ex.Message}");
                }
            }

            return NotFound("Data not found");
        }
    }

    public class SpaceData
    {
        public List<Destination> Destinations { get; set; } = new List<Destination>();
        public List<Crew> Crew { get; set; } = new List<Crew>();
        public List<Technology> Technology { get; set; } = new List<Technology>();
    }
}