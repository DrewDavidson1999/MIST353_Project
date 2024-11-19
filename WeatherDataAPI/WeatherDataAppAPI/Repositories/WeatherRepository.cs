using WeatherDataAppAPI.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace WeatherDataAppAPI.Repositories
{
    public class WeatherRepository
    {
        private readonly string _connectionString;

        public WeatherRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException(nameof(configuration));
        }

        public bool AddWeatherForecast(string region, DateTime forecastDate, double temperature, string weatherDescription)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var parameters = new
                    {
                        Region = region,
                        ForecastDate = forecastDate,
                        Temperature = temperature,
                        WeatherDescription = weatherDescription
                    };

                    // Execute the stored procedure and get the number of rows affected
                    int rowsAffected = connection.Execute("spAddWeatherForecast", parameters, commandType: CommandType.StoredProcedure);

                    // Return true if one or more rows were affected
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddWeatherForecast: {ex.Message}");
                return false; // Return false if there's an exception
            }
        }

        // Updated to return IEnumerable<WeatherData>
        public IEnumerable<WeatherData> GetCurrentWeatherByLocation(string city)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(city))
                {
                    throw new ArgumentException("City name cannot be empty or whitespace.", nameof(city));
                }

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var parameters = new { City = city.Trim() };

                    // Ensure this uses the correct stored procedure
                    var weatherData = connection.Query<WeatherData>("spGetCurrentWeatherByLocation", parameters, commandType: CommandType.StoredProcedure);

                    return weatherData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCurrentWeatherByLocation: {ex.Message}");
                return new List<WeatherData>(); // Return an empty list in case of an error
            }
        }
    }
}


