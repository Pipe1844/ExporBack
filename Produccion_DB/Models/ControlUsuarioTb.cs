using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ControlUsuarioTb
{
    public string ControlDeniega { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public virtual UsuarioTb UsuarioNavigation { get; set; } = null!;
}
