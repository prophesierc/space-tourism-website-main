namespace App.API.Models
{
    public class Technology
    {
        public string? Name { get; set; }
        public TechnologyImages? Images { get; set; }
        public string? Description { get; set; }
    }

    public class TechnologyImages
    {
        public string? Portrait { get; set; }
        public string? Landscape { get; set; }
    }

}
