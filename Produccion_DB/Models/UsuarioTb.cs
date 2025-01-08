using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class UsuarioTb
{
    public string Usuario { get; set; } = null!;

    public string RolDeUsuario { get; set; } = null!;
    
    public string? Contrasena { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public string IdEmpleado { get; set; } = null!;

    public virtual ICollection<ControlUsuarioTb> ControlUsuarioTbs { get; set; } = new List<ControlUsuarioTb>();

    public virtual ICollection<DepUsuarioTb> DepUsuarios { get; set; } = new List<DepUsuarioTb>();
    
    //public virtual ICollection<DepartamentoTb> Departamentos { get; set; } = new List<DepartamentoTb>();
}
