using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WeatherDataAppAPI.Repositories
{
	public class UserDeleteServ : IUserDelete
	{

		private readonly DBContextClass _dbContextClass;
		public UserDeleteServ(DBContextClass dBContextClass)
		{
			_dbContextClass = dBContextClass;
		}
		public async Task<List<UserDelete>> UserDeleteDelete(int userID)
		{

			var parameter = new List<SqlParameter>();

			var param1 = new SqlParameter("@UserID", userID);


			var UserDelete = await Task.Run(() => _dbContextClass.UserDelete.FromSqlRaw("exec UserDelete @UserID ", param1).ToListAsync());
			return UserDelete;
		}
	}
}
