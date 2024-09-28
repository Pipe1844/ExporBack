using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtLarvasMonitoreoTb
{
    public int IdLarva { get; set; }

    public int IdMfruto { get; set; }

    public string? Genero { get; set; }

    public string? Especie { get; set; }

    public string NombreDlarva { get; set; } = null!;

    public int Cantidad { get; set; }
}
