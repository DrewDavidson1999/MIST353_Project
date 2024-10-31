using WeatherDataAppAPI.Entities;
using Microsoft.EntityFrameworkCore;



namespace WeatherDataAppAPI.Data
{
	public class DBContextClass : DbContext
	{

		public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
		{ }
		public DbSet<WeatherDataAdd> WeatherDataAdd { get; set; }
		public DbSet<WeatherDataDelete> WeatherDataDelete { get; set; }

		public DbSet<NewUser> NewUser { get; set; }
		public DbSet<InsertLocation> InsertLocation { get; set; }


	}
}
