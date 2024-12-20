﻿using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;



namespace WeatherDataAppAPI.Repositories
{
	public interface IWeatherDataAdd
	{

		public Task<List<WeatherDataAdd>> PreLocAddGetDetails(string city, string state, string country);

	}
}
