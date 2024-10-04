namespace App.API.Models
{
    public class Destination
    {
        public string? Name { get; set; }
        public DestinationImages? Images { get; set; }
        public string? Description { get; set; }
        public string? Distance { get; set; }
        public string? Travel { get; set; }
    }

    public class DestinationImages
    {
        public string? Png { get; set; }
        public string? Webp { get; set; }
    }


}
