using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WeatherDataAppAPI.Repositories
{
    public class NewUserServ : INewUser 
    {
        private readonly DBContextClass _dbContextClass;
        public NewUserServ(DBContextClass dBContextClass)
        {
            _dbContextClass = dBContextClass;
        }
        public async Task<bool<NewUser>> InsertNewUserGetDetails(string userName, string email, string passwordHash);

        var paramUserName = new SqlParameter("@UserName", userName);
        var paramEmail = new SqlParameter("@Email", email);
        var paramPasswordHash = new SqlParameter("@PasswordHash", passwordHash);

        var result = await Task.Run(() =>
            _dbContextClass.Database.ExecuteSqlRawAsync("EXEC InsertNewUser @UserName, @Email, @PasswordHash",
                                                        paramUserName, paramEmail, paramPasswordHash));
            
            return result > 0; 
            }
    }
}
