namespace App.API.Models
{
    public class Crew
    {
        public string? Name { get; set; }
        public CrewImages? Images { get; set; }
        public string? Role { get; set; }
        public string? Bio { get; set; }
    }

    public class CrewImages
    {
        public string? Png { get; set; }
        public string? Webp { get; set; }
    }

}
