using WeatherDataAppAPI.Entities;
using Microsoft.EntityFrameworkCore;



namespace WeatherDataAppAPI.Data
{
	public class DBContextClass : DbContext
	{
        protected readonly IConfiguration Configuration;
        public DBContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<WeatherDataAdd> WeatherDataAdd { get; set; }
		public DbSet<WeatherDataDelete> WeatherDataDelete { get; set; }

		public DbSet<NewUser> NewUser { get; set; }
		public DbSet<InsertLocation> InsertLocation { get; set; }

		public DbSet<ChangePW> ChangePW { get; set; }

		public DbSet<UpdatePreferredLocation> UpdatePreferredLocation { get; set; }


	}
}
