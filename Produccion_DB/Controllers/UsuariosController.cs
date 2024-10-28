using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;
using Produccion_DB.DTOs; 

namespace Produccion_DB.Controllers
{
    [Route("api/v2/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsuariosController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // GET: api/v2/usuarios
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _appDbContext.UsuarioTbs.ToListAsync();

            if (usuarios == null || !usuarios.Any())
            {
                return NotFound(new { isSuccess = false, status = 404, message = "No se encontraron usuarios." });
            }

            return Ok(new { isSuccess = true, status = 200, usuarios });
        }

        // GET: api/v2/usuarios/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            var usuario = await _appDbContext.UsuarioTbs.FindAsync(id);

            if (usuario == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });
            }

            return Ok(new { isSuccess = true, status = 200, usuario });
        }

        // POST: api/v2/usuarios
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] UsuarioTb usuario)
        {
            if (usuario == null)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Datos de usuario inválidos." });
            }

            // Verificar campos requeridos
            if (string.IsNullOrEmpty(usuario.Usuario) ||
                string.IsNullOrEmpty(usuario.RolDeUsuario) ||
                string.IsNullOrEmpty(usuario.IdEmpleado))
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Faltan campos requeridos." });
            }

            await _appDbContext.UsuarioTbs.AddAsync(usuario);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                isSuccess = true, status = 201, message = "Usuario creado exitosamente.", usuario
            });
        }

        // PUT: api/v2/usuarios/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UsuarioTb usuarioActualizado)
        {
            var usuario = await _appDbContext.UsuarioTbs.FindAsync(id);

            if (usuario == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });
            }

            usuario.RolDeUsuario = usuarioActualizado.RolDeUsuario;
            usuario.Contrasena = usuarioActualizado.Contrasena;
            usuario.FechaCreacion = usuarioActualizado.FechaCreacion;
            usuario.IdEmpleado = usuarioActualizado.IdEmpleado;

            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                isSuccess = true, status = 200, message = "Usuario actualizado exitosamente.", usuario
            });
        }
        
        // DELETE: api/v2/usuarios/{usuario}
        [HttpDelete("{usuario}")]
        public async Task<IActionResult> Destroy(string usuario)
        {
            var usuarioEncontrado = await _appDbContext.UsuarioTbs.FindAsync(usuario);

            if (usuarioEncontrado == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });
            }

            _appDbContext.UsuarioTbs.Remove(usuarioEncontrado);
            await _appDbContext.SaveChangesAsync();

            return Ok(new { isSuccess = true, status = 200, message = "Usuario eliminado exitosamente." });
        }


    }
}
