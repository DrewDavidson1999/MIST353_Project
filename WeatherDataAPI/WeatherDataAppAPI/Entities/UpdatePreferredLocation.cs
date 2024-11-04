using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WeatherDataAppAPI.Entities
{
    [Keyless]
    public class UpdatePreferredLocation
    {

        public int UserID { get; set; }

        public string Location { get; set; }
    }
}
