using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherDataAppAPI.Data;

public partial class ExtUserPreferredLocation
{
    [Key]
    public int UserId { get; set; }

    public string Location { get; set; } = null!;

    public virtual ExtUser User { get; set; } = null!;
}
