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
        public async Task<int> InsertNewUserGetDetails(string userName, string email, string passwordHash)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Email", email),
                new SqlParameter("@PasswordHash", passwordHash)
            };

            // Execute the stored procedure and get the number of affected rows
            var result = await _dbContextClass.Database.ExecuteSqlRawAsync("EXEC InsertNewUser @UserName, @Email, @PasswordHash", parameters.ToArray());

            // Return the number of affected rows
            return result;
        }
    }
}