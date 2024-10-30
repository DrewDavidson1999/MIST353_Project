


namespace WeatherDataAppAPI.Repositories
{
	public interface IWeatherDataAdd
	{

		public Task<List<WeatherDataAdd>> WeatherDataAddGetDetails(int locationID, string city, string state, string country);

	}
}
