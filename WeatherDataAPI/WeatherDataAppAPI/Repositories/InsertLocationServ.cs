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

        public async Task<bool> InsertLocationGetDetails(string city, string state, string country);
        {
            var paramCity = new SqlParameter("@City", city);
            var paramState = new SqlParameter("@State", state);
            var paramCountry = new SqlParameter("@Country", country);

            var result = await _dbContextClass.Database.ExecuteSqlRawAsync(
                "EXEC InsertNewLocation @City, @State, @Country",
                paramCity, paramState, paramCountry);

            return result > 0;
        }
    }
}
