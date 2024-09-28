using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class MtPlubiometroTb
{
    public int IdPlubiometro { get; set; }

    public bool Activo { get; set; }

    public string Ubicacion { get; set; } = null!;

    public virtual ICollection<MtRegistroLluviasTb> MtRegistroLluviasTbs { get; set; } = new List<MtRegistroLluviasTb>();
}
