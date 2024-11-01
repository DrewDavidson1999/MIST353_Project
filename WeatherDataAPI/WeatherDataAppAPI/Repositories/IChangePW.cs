using WeatherDataAppAPI.Entities;

namespace WeatherDataAppAPI.Repositories
{
    public interface IChangePW
    {
        public Task<List<ChangePW>> ChangePassword(int userid, string passwordhash);
    }
}
