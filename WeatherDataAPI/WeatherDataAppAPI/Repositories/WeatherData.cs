namespace WeatherDataAppAPI.Repositories
{
    public class WeatherData : IWeatherData
    {
        public string? Location { get; set; }
        public double? Temperature { get; set; }
        public int? Humidity { get; set; }
        public double? WindSpeed { get; set; }
        public string? WeatherDescription { get; set; }
        public DateTime? DateTime { get; set; }
    }
}

