namespace Produccion_DB.Models.AuxiliarModels;

public class UsuarioDep
{
    public UsuarioTb Usuario { get; set; }
    public List<string> Departamentos { get; set; }
}