using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeatherDataAppAPI.Entities
{
	public class WeatherDataDelete
	{
		[Key]
		public int LocationID { get; set; }
		


	}
}
