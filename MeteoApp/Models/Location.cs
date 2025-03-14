namespace MeteoApp
{
    public class Location 
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsCurrentLocation { get; set; }

        public List<WeatherInfo> WeatherHistory { get; set; } = new();
    }
}