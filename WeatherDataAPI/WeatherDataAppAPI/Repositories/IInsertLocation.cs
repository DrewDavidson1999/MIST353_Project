using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Repositories
{
	public interface IInsertLocation
	{
        public async Task<bool> InsertLocationGetDetails(string city, string state, string country);

    }
}
