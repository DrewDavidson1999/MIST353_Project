using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WeatherDataAppAPI.Repositories
{
	public class WeatherDataAdd : IWeatherDataAdd
	{

		private readonly DBContextClass _dbContextClass;
		public WeatherDataAdd(DBContextClass dBContextClass)
		{
			_dbContextClass = dBContextClass;
		}
		public async Task<List<WeatherDataAdd>> WeatherDataAddGetDetails()
		{

			var parameter = new List<SqlParameter>();

			var locationID = new SqlParameter("@LocationID", LocationID);
			var city = new SqlParameter("@City", City);
			var state = new SqlParameter("@State", State);
			var country = new SqlParameter("@Country", Country);

			var WeatherDataAddStatus = await Task.Run(() => _dbContextClass.WeatherDataAdd.FromSqlRaw("exec spPreLocAdd @LoactionID, @City, @State, @Country ", locationID, city, state, country).ToListAsync());
			return WeatherDataAddStatus;
		}
	}
}
