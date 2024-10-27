using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

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
                return Ok(new { isSuccess = true, status = 204, Usuarios=new{} });
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
        public async Task<IActionResult> Create([FromBody] UsuarioTb nuevoUsuario)
        {
            // Verificar si el modelo es válido
            if (!ModelState.IsValid)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Datos de usuario inválidos." });
            }

            // Verificar si el usuario ya existe
            var usuarioExistente = await _appDbContext.UsuarioTbs.FindAsync(nuevoUsuario.Usuario);
            if (usuarioExistente != null)
            {
                return Conflict(new { isSuccess = false, status = 409, message = "El usuario ya existe." });
            }

            // Agregar el nuevo usuario a la base de datos
            await _appDbContext.UsuarioTbs.AddAsync(nuevoUsuario);
            await _appDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Destroy), new { usuario = nuevoUsuario.Usuario }, 
                new { isSuccess = true, status = 201, message = "Usuario creado exitosamente.", usuario = nuevoUsuario });
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
