namespace MeteoApp
{
    public class NotificationPreferences
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public double TemperatureThreshold { get; set; } // Soglia di temperatura
        public bool NotifyRain { get; set; } // Notifica in caso di pioggia
        public bool NotifySnow { get; set; } // Notifica in caso di neve
    }
}