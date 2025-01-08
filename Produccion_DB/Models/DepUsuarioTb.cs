namespace Produccion_DB.Models;

public class DepUsuarioTb
{
    public string Usuario { get; set; } = null!;
    public string Departamento { get; set; } = null!;
    
    public virtual UsuarioTb UsuarioTb { get; set; } = null!;

    public virtual DepartamentoTb DepartamentoTb { get; set; } = null!;
}