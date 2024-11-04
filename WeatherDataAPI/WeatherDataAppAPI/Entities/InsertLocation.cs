using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeatherDataAppAPI.Entities;

[Keyless]
public class InsertLocation
{

    public InsertLocation()
    { }
    [StringLength(100)]
    public string City { get; set; }


    [StringLength(100)]
    public string State { get; set; }


    [StringLength(100)]
    public string Country { get; set; }

    }

