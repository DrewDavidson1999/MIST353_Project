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

        public async Task<int> InsertLocationGetDetails(string city, string state, string country)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@City", city),
                new SqlParameter("@State", state),
                new SqlParameter("@Country", country)
            };

            // Execute the stored procedure and get the number of affected rows.
            var result = await _dbContextClass.Database.ExecuteSqlRawAsync("EXEC InsertNewLocation @City, @State, @Country", parameters.ToArray());

            // Return the number of affected rows.
            return result;
        }
    }
}
