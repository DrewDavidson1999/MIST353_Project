﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherDataAppAPI.Data;

public partial class ExtWeatherCurrent
{
    [Key]
    public int WeatherId { get; set; }

    public string Location { get; set; } = null!;

    public double Temperature { get; set; }

    public int Humidity { get; set; }

    public double WindSpeed { get; set; }

    public string WeatherDescription { get; set; } = null!;

    public DateTime DateTime { get; set; }
}
