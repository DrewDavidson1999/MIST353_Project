using WeatherDataAppAPI.Data;

using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;

namespace WeatherDataAppAPI.Repositories
{


    public interface INewUser
    {
        Task<int> InsertNewUserGetDetails(string userName, string email, string passwordHash);
    }
}

