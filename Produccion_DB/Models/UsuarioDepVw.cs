using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UsuarioDepVw
{
    public string Usuario { get; set; } = null!;

    public string RolDeUsuario { get; set; } = null!;

    public string? Contrasena { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public string Departamento { get; set; } = null!;

    public string IdEmpleado { get; set; } = null!;
}
