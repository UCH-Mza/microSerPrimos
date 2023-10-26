using System;
using System.Collections.Generic;

namespace Model;

public partial class Usuario
{
    public int UsuId { get; set; }

    public string UsuName { get; set; } = null!;

    public string UsuCalve { get; set; } = null!;

    public DateTime? UsuUltimoIngreso { get; set; }
}
