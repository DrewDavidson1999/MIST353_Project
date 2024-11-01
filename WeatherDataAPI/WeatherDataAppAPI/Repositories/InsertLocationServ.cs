using WeatherDataAppAPI.Data;
using WeatherDataAppAPI.Entities;
using WeatherDataAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace WeatherDataAppAPI.Repositories
{
    public class InsertLocationServ : IInsertLocation
    {
        private readonly DBContextClass _dbContextClass;
        public InsertLocationServ(DBContextClass dBContextClass)
        {
            _dbContextClass = dBContextClass;
        }

        public async Task<List<InsertLocation>> InsertLocationGetDetails(string city, string state, string country)
        {
            var parameters = new List<SqlParameter>();
            {
                var param2 = new SqlParameter("@City", city);
                var param3 = new SqlParameter("@State", state);
                var param4 = new SqlParameter("@Country", country);
            };

            var locations = await _dbContextClass.InsertLocation.FromSqlRaw("EXEC InsertNewLocation @City, @State, @Country", parameters.ToArray()).ToListAsync();
            return locations;
        }
    }
}

