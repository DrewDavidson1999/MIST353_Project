﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeatherDataAppAPI.Entities
{
	[Keyless]
	public class WeatherDataAdd
	{

		public int LocationID { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }


	}
}
