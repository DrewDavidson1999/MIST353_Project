using System;
using System.Collections.Generic;

namespace SampleProject.Data;

public partial class ExtWeatherForecast
{
    public int ForecastId { get; set; }

    public string Region { get; set; } = null!;

    public DateOnly ForecastDate { get; set; }

    public double Temperature { get; set; }

    public string WeatherDescription { get; set; } = null!;
}
