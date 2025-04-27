using System;
using System.Collections.Generic;

namespace Produccion_DB.Models;

public partial class ArticulosTb
{
    public string IdArticulo { get; set; } = null!;

    public string NombreArticulo { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string? Placa { get; set; }

    public string? NumeroChasis { get; set; }

    public string? NumeroMotor { get; set; }

    public string? Observaciones { get; set; }

    //public virtual ICollection<FtAplicacionesTb> FtAplicacionesTbIdSprayNavigations { get; set; } = new List<FtAplicacionesTb>();

    //public virtual ICollection<FtAplicacionesTb> FtAplicacionesTbIdTractorNavigations { get; set; } = new List<FtAplicacionesTb>();
}
