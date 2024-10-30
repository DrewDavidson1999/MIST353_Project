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

        // Constructor to initialize the connection string
        public WeatherRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException(nameof(configuration));
        }

        // Method to add a weather forecast using the stored procedure spAddWeatherForecast
        public void AddWeatherForecast(string region, DateTime forecastDate, double temperature, string weatherDescription)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open(); // Open the SQL connection

                // Define the parameters to pass to the stored procedure
                var parameters = new
                {
                    Region = region,
                    ForecastDate = forecastDate,
                    Temperature = temperature,
                    WeatherDescription = weatherDescription
                };

                // Execute the stored procedure using Dapper to insert the forecast
                connection.Execute("spAddWeatherForecast", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        // Implement the method to get current weather data by city
        public IEnumerable<WeatherData> GetCurrentWeatherByCity(string city)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open(); // Open the SQL connection

                // Define the parameters to pass to the stored procedure or query
                var parameters = new { City = city };

                // Execute a query to get current weather data by city using Dapper
                string query = "SELECT Location, Temperature, Humidity, WindSpeed, WeatherDescription, DateTime FROM ext_Weather_Current WHERE Location = @City";

                // Query the database using Dapper
                var weatherData = connection.Query<WeatherData>(query, parameters);

                return weatherData; // Return the retrieved weather data
            }
        }
    }
}
