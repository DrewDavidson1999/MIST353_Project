using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;



namespace WeatherDataAppAPI.Repositories
{
	public interface IUserDelete
	{

		public Task<List<UserDelete>> UserDeleteDelete(int userID);

	}
}
