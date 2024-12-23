using System;
using System.Collections.Generic;

namespace WpfApp1.Models;

public partial class Prodavez
{
    public long Id { get; set; }

    public string Fio { get; set; } = null!;

    public string Nomer { get; set; } = null!;

    public string Seria { get; set; } = null!;

    public string Telefon { get; set; } = null!;
}
