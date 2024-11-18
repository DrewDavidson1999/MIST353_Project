using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeatherDataAppAPI.Entities
{
	[Keyless]
	public class WeatherDataAdd
	{
		public WeatherDataAdd()
		{ }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		

	}
}
