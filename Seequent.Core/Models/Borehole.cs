using System;
using System.Collections.Generic;

namespace SeequentApi.Models;

public partial class Borehole
{
    public long Id { get; set; }

    public int DepthKm { get; set; }

    public int XlocationKm { get; set; }

    public int YlocationKm { get; set; }

    public string? CableType { get; set; }

    public string? CableStrength { get; set; }

    public string? DrillType { get; set; }

    public string? DrillStrength { get; set; }
}
