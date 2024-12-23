using System;
using System.Collections.Generic;

namespace WpfApp1.Models;

public partial class Regestrat
{
    public static Regestrat Current { get; set; }

    public long Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
