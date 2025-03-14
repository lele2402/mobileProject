namespace MeteoApp
{
    public class WeatherInfo
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public string WeatherDescription { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;

        
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;
    }
}