namespace Produccion_DB.DTOs // Cambia 'TuProyecto' por el nombre de tu espacio de nombres
{
    public class UsuarioDto
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string IdEmpleado { get; set; }
        public string RolDeUsuario { get; set; }
        public List<string> Departamentos { get; set; } // Lista de IDs de departamentos
    }

}