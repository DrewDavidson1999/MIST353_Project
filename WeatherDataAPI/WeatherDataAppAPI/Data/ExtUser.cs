using System;
using System.Collections.Generic;

namespace WeatherDataAppAPI.Data;

public partial class ExtUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public virtual ICollection<ExtUserPreferredLocation> ExtUserPreferredLocations { get; set; } = new List<ExtUserPreferredLocation>();
}
