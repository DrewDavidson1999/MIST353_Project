using System;
using System.Collections.Generic;

namespace SampleProject.Data;

public partial class ExtUserPreferredLocation
{
    public int UserId { get; set; }

    public string Location { get; set; } = null!;
}
