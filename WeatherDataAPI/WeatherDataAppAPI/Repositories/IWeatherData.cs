namespace WeatherDataAppAPI.Repositories
{
    public class IWeatherData
    {
        public string? Location { get; set; } // Nullable string for location
        public double? Temperature { get; set; } // Nullable double for temperature
        public int? Humidity { get; set; } // Nullable int for humidity
        public double? WindSpeed { get; set; } // Nullable double for wind speed
        public string? WeatherDescription { get; set; } // Nullable string for description
        public DateTime? DateTime { get; set; } // Nullable DateTime for the weather date
    }
}


