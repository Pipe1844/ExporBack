using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;
using System.Threading.Tasks;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/depusuarios")]
    [ApiController]
    public class DepUsuarioController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public DepUsuarioController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // POST: api/v2/departamentos-usuarios
        // Asocia departamentos a un usuario
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] DepUsuarioRequest request)
        
        {

            try
            {
                // Verificar que el usuario exista  
                var usuarioExiste = await _appDbContext.UsuarioTbs  
                    .AnyAsync(u => u.Usuario == request.Usuario);  

                if (!usuarioExiste)  
                {  
                    return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado.", request = request });  
                }  

// Comprobar los datos antes de proceder  
                if (string.IsNullOrEmpty(request.Usuario) || request.Departamentos == null)  
                {  
                    return BadRequest(new { isSuccess = false, status = 400, message = "Datos inválidos. Usuario o departamentos no proporcionados." });  
                }  

// Crear las relaciones con los departamentos  
                var relaciones = request.Departamentos.Select(dept => new DepUsuarioTb  
                {  
                    Usuario = request.Usuario,  
                    Departamento = dept  
                });  

// Agregar las relaciones y guardar  
                await _appDbContext.DepUsuarioTBs.AddRangeAsync(relaciones);  
                await _appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 201, message = "Departamentos asociados al usuario exitosamente." });
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, 
                    message = "Error al guardar en la base de datos.", error = dbEx.Message,  
                    innerError = dbEx.InnerException?.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }


        // DELETE: api/v2/departamentos-usuarios
        // Elimina una relación entre un usuario y departamentos
        [HttpDelete]
        public async Task<IActionResult> Destroy([FromBody] DepUsuarioRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Usuario) || request.Departamentos == null || !request.Departamentos.Any())
                {
                    return BadRequest(new { isSuccess = false, status = 400, message = "Datos inválidos. Usuario o departamentos no proporcionados." });
                }
                
                // Obtener las relaciones que se desean eliminar
                var relaciones = await _appDbContext.DepUsuarioTBs
                    .Where(du => du.Usuario == request.Usuario && request.Departamentos.Contains(du.Departamento))
                    .ToListAsync();

                if (string.IsNullOrEmpty(request.Usuario) || request.Departamentos == null)
                {
                    return BadRequest(new { isSuccess = false, status = 400, message = "Datos inválidos. Usuario o departamentos no proporcionados." });
                }
                
                if (relaciones.Count==0)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Relaciones no encontradas." });
                }
                
                _appDbContext.DepUsuarioTBs.RemoveRange(relaciones);
                await _appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "Relaciones eliminadas exitosamente." });
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
        
        // PUT: api/v2/depusuarios  
// Actualiza las relaciones entre un usuario y departamentos  
        [HttpPut("update")] 
public async Task<IActionResult> Update([FromBody] DepUsuarioRequest request)  
{   

    if (string.IsNullOrEmpty(request.Usuario) || request.Departamentos == null)  
    {  
        return BadRequest(new { isSuccess = false, status = 400, message = "Datos inválidos. Usuario o departamentos no proporcionados." });  
    }  

    try  
    {  
        // Verificar que el usuario exista  
        var usuarioExiste = await _appDbContext.UsuarioTbs  
            .AnyAsync(u => u.Usuario == request.Usuario);  

        if (!usuarioExiste)  
        {  
            return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });  
        }  

        // Obtener las relaciones actuales  
        var relacionesActuales = await _appDbContext.DepUsuarioTBs  
            .Where(du => du.Usuario == request.Usuario)  
            .ToListAsync();  

        // Eliminar todas las relaciones actuales  
        _appDbContext.DepUsuarioTBs.RemoveRange(relacionesActuales);  

        // Crear nuevas relaciones  
        var nuevasRelaciones = request.Departamentos.Select(dept => new DepUsuarioTb  
        {  
            Usuario = request.Usuario,  
            Departamento = dept  
        });  

        await _appDbContext.DepUsuarioTBs.AddRangeAsync(nuevasRelaciones);  
        await _appDbContext.SaveChangesAsync();  

        return Ok(new { isSuccess = true, status = 200, message = "Relaciones actualizadas exitosamente." });  
    }  
    catch (DbUpdateException dbEx)  
    {  
        return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al guardar en la base de datos.", error = dbEx.Message });  
    }  
    catch (Exception ex)  
    {  
        return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });  
    }  
}

        // GET: api/v2/depusuarios/{usuario}
// Obtiene los departamentos asociados a un usuario
        [HttpGet("{usuario}")]
        public async Task<IActionResult> GetDepartamentosByUsuario(string usuario)
        {
            try
            {
                // Verificar que el usuario exista en la base de datos
                var usuarioExiste = await _appDbContext.UsuarioTbs
                    .AnyAsync(u => u.Usuario == usuario);

                if (!usuarioExiste)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Usuario no encontrado." });
                }

                // Obtener los departamentos asociados al usuario
                var departamentos = await _appDbContext.DepUsuarioTBs
                    .Where(du => du.Usuario == usuario)
                    .Select(du => new
                    {
                        du.Departamento // Asegúrate de que este campo sea el correcto
                    })
                    .ToListAsync();

             
                return departamentos.Count==0 ? 
                    Ok(new { isSuccess = true, status = 204, message = "El usuario no tiene departamentos asignados.", departamentos = new List<object>() }) 
                    : Ok(new { isSuccess = true, status = 200, departamentos });
            }
            catch (DbUpdateException dbEx)  
            {  
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error al guardar en la base de datos.", error = dbEx.Message });  
            }  
            catch (Exception ex)  
            {  
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });  
            } 
        }

    }
    
    

    // Modelo auxiliar para las solicitudes
    public class DepUsuarioRequest
    {
        public string? Usuario { get; set; } // Ahora acepta null  

        public List<string>? Departamentos { get; set; } // Ahora acepta null  
    }
}
