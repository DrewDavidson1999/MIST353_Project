﻿using WeatherDataAppAPI.Data;
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

        public void AddWeatherForecast(string region, DateTime forecastDate, double temperature, string weatherDescription)
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

                connection.Execute("spAddWeatherForecast", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        // Updated to return IEnumerable<WeatherData>
        public IEnumerable<WeatherData> GetCurrentWeatherByLocation(string city)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var parameters = new { City = city };

                // Ensure this uses a stored procedure if required by your teacher
                var weatherData = connection.Query<WeatherData>("spGetCurrentWeatherByLocation", parameters, commandType: CommandType.StoredProcedure);

                return weatherData;
            }
        }
    }
}

