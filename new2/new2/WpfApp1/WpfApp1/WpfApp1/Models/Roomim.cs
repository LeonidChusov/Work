using System;
using System.Collections.Generic;

namespace WpfApp1.Models;

public partial class Roomim
{
    public long Id { get; set; }

    public string Imagge { get; set; } = null!;

    public string Price { get; set; }

    public string FlootKom { get; set; }

    public string Metr { get; set; }

    public string Ittag { get; set; }

    public string Adreess { get; set; } = null!;

    public string? MictoRoiin { get; set; }

    public string? Remont { get; set; }

    public string? Opisaninie { get; set; }

    public string? SrokVladenia { get; set; }
}
