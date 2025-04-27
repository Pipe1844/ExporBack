using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class DepartamentoTb
{
    public string Departamento { get; set; } = null!;

    public string? Encargado { get; set; }

    public string? Descripcion { get; set; }

    //public virtual ICollection<ConsultasTb> ConsultasTbs { get; set; } = new List<ConsultasTb>();

    //public virtual ICollection<KnLaboresLotesTb> KnLaboresLotesTbs { get; set; } = new List<KnLaboresLotesTb>();

    //public virtual ICollection<LaborTTb> LaborTTbs { get; set; } = new List<LaborTTb>();

    //public virtual ICollection<LaboresTb> LaboresTbs { get; set; } = new List<LaboresTb>();

    //public virtual ICollection<DepUsuarioTb> DepUsuarios { get; set; } = new List<DepUsuarioTb>();
    
    //public virtual ICollection<UsuarioTb> Usuarios { get; set; } = new List<UsuarioTb>();
}
