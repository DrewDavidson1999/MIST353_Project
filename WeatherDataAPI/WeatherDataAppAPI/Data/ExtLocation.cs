using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherDataAppAPI.Data;

public partial class ExtLocation
{
    [Key]
    public int LocationId { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;
}
