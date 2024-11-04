using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherDataAppAPI.Entities;
[Table("Ext_Users")]
public class NewUser
{
    public NewUser()
    { }
    [Key]
        public int UserID { get; set; }


    [StringLength(100)]
    public string UserName { get; set; }


    [StringLength(255)]
    public string Email { get; set; }


    [StringLength(255)]
    public string PasswordHash { get; set; }

    }

