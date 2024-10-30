using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WeatherDataAppAPI.Repositories
{
	public class WeatherDataDeleteServ : IWeatherDataDelete
	{

		private readonly DBContextClass _dbContextClass;
		public WeatherDataDeleteServ(DBContextClass dBContextClass)
		{
			_dbContextClass = dBContextClass;
		}
		public async Task<List<WeatherDataDelete>> PreLocDeleteDelete(int locationID)
		{

			var parameter = new List<SqlParameter>();

			var param1 = new SqlParameter("@LocationID", locationID);
			

			var PreLocDelete = await Task.Run(() => _dbContextClass.WeatherDataDelete.FromSqlRaw("exec spPreLocDelete @LocationID ", param1).ToListAsync());
			return PreLocDelete;
		}
	}
}
