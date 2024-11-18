using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WeatherDataAppAPI.Repositories
{
	public class WeatherDataAddServ : IWeatherDataAdd
	{

		private readonly DBContextClass _dbContextClass;
		public WeatherDataAddServ(DBContextClass dBContextClass)
		{
			_dbContextClass = dBContextClass;
		}
		public async Task<List<WeatherDataAdd>> PreLocAddGetDetails(string city, string state, string country)
		{

			var parameter = new List<SqlParameter>();

			
			var param2 = new SqlParameter("@City", city);
			var param3 = new SqlParameter("@State", state);
			var param4 = new SqlParameter("@Country", country);

			var PreLocAdd = await Task.Run(() => _dbContextClass.WeatherDataAdd.FromSqlRaw("exec spPreLocAdd @City, @State, @Country ",param2, param3, param4).ToList());
			return PreLocAdd;
		}
	}
}
