using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class CultivoProductoFaseTb
{
    public string Cultivo { get; set; } = null!;

    public string ProductoTipoUso { get; set; } = null!;

    public string CodigoFase { get; set; } = null!;
}
