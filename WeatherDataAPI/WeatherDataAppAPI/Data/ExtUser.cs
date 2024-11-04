using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherDataAppAPI.Data;

public partial class ExtUser
{
    [Key]
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public virtual ICollection<ExtUserPreferredLocation> ExtUserPreferredLocations { get; set; } = new List<ExtUserPreferredLocation>();
}
