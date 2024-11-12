using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Repositories
{
    public interface IInsertLocation
    {
        Task<int> InsertLocationGetDetails(string city, string state, string country);
    }
}
