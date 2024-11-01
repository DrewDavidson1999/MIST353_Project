using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Repositories
{
	public interface INewUser
	{
        public async Task<bool> InsertNewUserGetDetails(string userName, string email, string passwordHash);


    }
}
