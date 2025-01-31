using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;
using Produccion_DB.Models.AuxiliarModels;

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
            try
            {
                var usuarios = await _appDbContext.UsuarioTbs.ToListAsync();

                if (usuarios == null || !usuarios.Any())
                {
                    return Ok(new { isSuccess = true, status = 204, Usuarios = new List<Object>() });
                }

                return Ok(new { isSuccess = true, status = 200, usuarios });
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al acceder a la base de datos.", error = dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }

        // GET: api/v2/usuarios/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            try
            {
                var usuario = await _appDbContext.UsuarioTbs.FindAsync(id);

                if (usuario == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });
                }

                return Ok(new { isSuccess = true, status = 200, usuario });
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al acceder a la base de datos.", error = dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }
        
        // POST: api/v2/usuarios
        [HttpPost]
        public async Task<IActionResult> Store([FromBody]  UsuarioTb usuario)
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

            // Verificar si el ID_Empleado ya existe
            var existeEmpleado = await _appDbContext.UsuarioTbs
                .AnyAsync(u => u.IdEmpleado == usuario.IdEmpleado);

            if (existeEmpleado)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "El ID de empleado ya está en uso." });
            }

            try
            {
                // Agregar el usuario a la base de datos sin manejar departamentos
                await _appDbContext.UsuarioTbs.AddAsync(usuario);
                await _appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 201, message = "Usuario creado exitosamente.", newUsuario = usuario });
            }
            catch (DbUpdateException dbEx)  
            {  
                var errorMessage = dbEx.InnerException != null ? dbEx.InnerException.Message : dbEx.Message;  
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al guardar en la base de datos.", error = errorMessage });  
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex });
            }
        }
        
        // PUT: api/v2/usuarios/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UsuarioTb usuarioActualizado)
        {
            try
            {
                var usuario = await _appDbContext.UsuarioTbs.FindAsync(id);

                if (usuario == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });
                }

                usuario.RolDeUsuario = usuarioActualizado.RolDeUsuario;
                usuario.Contrasena = usuarioActualizado.Contrasena;
                //usuario.FechaCreacion = usuarioActualizado.FechaCreacion;
                usuario.IdEmpleado = usuarioActualizado.IdEmpleado;

                await _appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "Usuario actualizado exitosamente.", usuario });
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al actualizar en la base de datos.", error = dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }

        // DELETE: api/v2/usuarios/{usuario}
        [HttpDelete("{usuario}")]
        public async Task<IActionResult> Destroy(string usuario)
        {
            try
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
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al eliminar en la base de datos.", error = dbEx.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }
    }
}
