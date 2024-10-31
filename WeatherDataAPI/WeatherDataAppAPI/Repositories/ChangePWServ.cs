using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WeatherDataAppAPI.Repositories
{
    public class ChangePWServ : IChangePW
    {
        private readonly DBContextClass _dbContextClass;
        public ChangePWServ(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<ChangePW>> ChangePassword(int userid, string passwordhash)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserID", userid),
                new SqlParameter("@PasswordHash", passwordhash)
        };
            

            return await _dbContextClass.ChangePW
                .FromSqlRaw("exec spChangePassword @UserID, @PasswordHash", parameters)
                .ToListAsync();
        }
    }
}
