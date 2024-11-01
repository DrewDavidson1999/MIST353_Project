using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace WeatherDataAppAPI.Repositories
{
    public class NewUserServ : INewUser
    {
        private readonly DBContextClass _dbContextClass;
        public NewUserServ(DBContextClass dBContextClass)
        {
            _dbContextClass = dBContextClass;
        }
        public async Task<List<NewUser>> InsertNewUserGetDetails(string userName, string email, string passwordHash)
        {
            var parameter = new List<SqlParameter>();
            {
                var param2 = new SqlParameter("@UserName", userName);
                var param3 = new SqlParameter("@Email", email);
                var param4 = new SqlParameter("@PasswordHash", passwordHash);
            };

            var InsertNewUsers = await _dbContextClass.NewUser.FromSqlRaw("EXEC InsertNewUser @UserName, @Email, @PasswordHash", parameter.ToArray()).ToListAsync();
            return InsertNewUsers;
        }
    }
}