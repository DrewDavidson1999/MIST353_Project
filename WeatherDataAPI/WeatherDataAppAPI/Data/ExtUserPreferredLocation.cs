using System;
using System.Collections.Generic;

namespace WeatherDataAppAPI.Data;

public partial class ExtUserPreferredLocation
{
    public int UserId { get; set; }

    public string Location { get; set; } = null!;

    public virtual ExtUser User { get; set; } = null!;
}
