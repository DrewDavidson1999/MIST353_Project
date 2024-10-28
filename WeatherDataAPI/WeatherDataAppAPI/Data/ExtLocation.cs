using System;
using System.Collections.Generic;

namespace WeatherDataAppAPI.Data;

public partial class ExtLocation
{
    public int LocationId { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;
}
