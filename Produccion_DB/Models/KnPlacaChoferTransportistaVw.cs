using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class KnPlacaChoferTransportistaVw
{
    public string Placa { get; set; } = null!;

    public string Trasportista { get; set; } = null!;

    public string? NombreChofer { get; set; }
}
