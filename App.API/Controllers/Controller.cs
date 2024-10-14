using App.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; 
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace App.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpaceDataController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        public required string _apiKey { get; init; }
        private readonly HttpClient _httpClient;

        public SpaceDataController(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _apiKey = configuration["ApiSettings:ApiKey"] ?? throw new InvalidOperationException("API Key not found in configuration.");
            _httpClient = new HttpClient();
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

        [HttpGet("proxy/data")]
        public async Task<ActionResult<SpaceData>> GetProxyData()
        {
            var apiUrl = "https://prophesierc.site/api/SpaceData/data";
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);

            try
            {
                var response = await _httpClient.GetAsync(apiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, "Error fetching data from external API.");
                }

                var json = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var spaceData = JsonSerializer.Deserialize<SpaceData>(json, options);

                if (spaceData != null)
                {
                    return Ok(spaceData);
                }

                return BadRequest("Failed to deserialize the data from external API.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

    public class SpaceData
    {
        public List<Destination> Destinations { get; set; } = new List<Destination>();
        public List<Crew> Crew { get; set; } = new List<Crew>();
        public List<Technology> Technology { get; set; } = new List<Technology>();
    }
}