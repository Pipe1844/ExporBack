using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class FtLarvasMasEstadoVw
{
    public int IdMfruto { get; set; }

    public string? Genero { get; set; }

    public string? Especie { get; set; }

    public string? NombreDlarva { get; set; }

    public int? CantidadDlarva { get; set; }

    public string? EstadoLarva { get; set; }

    public int? CantidadElarva { get; set; }
}
