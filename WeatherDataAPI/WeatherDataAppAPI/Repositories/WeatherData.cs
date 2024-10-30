using WeatherDataAppAPI.Data;  // Reference to your data layer
using Microsoft.Data.SqlClient; // For SQL server interaction
using Microsoft.EntityFrameworkCore; // For DbContext interactions

namespace WeatherDataAppAPI.Repositories
{
    public class WeatherData
    {
        // Retain the reference to the WeatherDataDbContext for DB operations
        private readonly WeatherDataDbContext _dbcontext;

        // Constructor to initialize the DbContext
        public WeatherData(WeatherDataDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // Properties to store weather data (these can be mapped from the DB)
        public string? Location { get; set; } // Nullable string for location
        public double? Temperature { get; set; } // Nullable double for temperature
        public int? Humidity { get; set; } // Nullable int for humidity
        public double? WindSpeed { get; set; } // Nullable double for wind speed
        public string? WeatherDescription { get; set; } // Nullable string for description
        public DateTime? DateTime { get; set; } // Nullable DateTime for the weather date

        // Method example: Fetch weather data from the database
        public IEnumerable<ExtWeatherCurrent> GetWeatherDataByCity(string city)
        {
            // Query the ExtWeatherCurrent DbSet instead of WeatherData
            return _dbcontext.ExtWeatherCurrents
                .Where(w => w.Location == city) // Location is part of ExtWeatherCurrent
                .ToList();
        }
    }
}

