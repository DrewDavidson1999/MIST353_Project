using WeatherDataAppAPI.Entities;

namespace WeatherDataAppAPI.Repositories
{
    public interface IUpdatePreferredLocation
    {
        public Task<List<UpdatePreferredLocation>> ChangePreferredLocation(int userid, string location);
    }
}
