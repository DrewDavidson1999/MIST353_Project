using WeatherDataAppAPI.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WeatherDataAppAPI.Repositories;
using Dapper;

namespace WeatherDataAppAPI.Repositories
{
    // Corrected class definition for WeatherRepository
    public class WeatherRepository
    {
        private readonly string _connectionString;

        // Constructor to initialize the connection string
        public WeatherRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException(nameof(configuration));
        }

        // Method to get current weather data by city
        public IEnumerable<WeatherData> GetCurrentWeatherByCity(string city)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open(); // Open the SQL connection

                // Define the parameters to pass to the stored procedure
                var parameters = new { City = city };

                // Execute the stored procedure using Dapper
                IEnumerable<WeatherData> weatherData = connection.Query<WeatherData>("spGetCurrentWeatherByLocation", parameters, commandType: CommandType.StoredProcedure);

                return weatherData; // Return the retrieved weather data
            }
        }
    }
}