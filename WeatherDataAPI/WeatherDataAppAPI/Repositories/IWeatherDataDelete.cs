using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;



namespace WeatherDataAppAPI.Repositories
{
	public interface IWeatherDataDelete
	{

		public Task<List<WeatherDataDelete>> PreLocDeleteDelete(int locationID);

	}
}
