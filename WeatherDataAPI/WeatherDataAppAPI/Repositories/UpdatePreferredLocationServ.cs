using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WeatherDataAppAPI.Repositories
{
    public class UpdatePreferredLocationServ : IUpdatePreferredLocation
    {
        private readonly DBContextClass _dbContextClass;
        public UpdatePreferredLocationServ(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<UpdatePreferredLocation>> ChangePreferredLocation(int userid, string location)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserID", userid),
                new SqlParameter("@Location", location)
            };

            return await _dbContextClass.UpdatePreferredLocation
                .FromSqlRaw("exec spChangePreferredLocation @UserID, @Location", parameters)
                .ToListAsync();
        }
    }
}
