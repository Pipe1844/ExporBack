using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/temporadas")]
    [ApiController]
    
    public class TemporadaController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public TemporadaController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                // Intentamos obtener la lista de temporadas
                var temporadas = await this.appDbContext.TemporadaTbs.ToListAsync();

                // Verificamos si la lista está vacía
                if (temporadas == null || !temporadas.Any())
                {
                    return Ok(new 
                    { 
                        isSuccess = true, 
                        status = 204, 
                        Temporadas = new List<Object>() 
                    });
                }
                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    Temporadas = temporadas 
                });
            }
            catch (DbUpdateException dbEx)
            {
                // Manejo específico de errores relacionados con la base de datos
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Ocurrió un error al acceder a la base de datos.", 
                    error = dbEx.Message 
                });
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Ocurrió un error inesperado.", 
                    error = ex.Message 
                });
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            try
            {
                var temporada = await this.appDbContext.TemporadaTbs.FindAsync(id);
        
                if (temporada == null)
                {
                    return NotFound(new 
                    { 
                        isSuccess = false, 
                        status = 404, 
                        message = "Artículo no encontrado." 
                    });
                }

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    Temporadas = temporada 
                });
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Error al acceder a la base de datos.", 
                    error = dbEx.Message 
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Ocurrió un error inesperado.", 
                    error = ex.Message 
                });
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] TemporadaTb temporada)
        {
            if (temporada == null)
            {
                return BadRequest(new 
                { 
                    isSuccess = false, 
                    status = 400, 
                    message = "Datos inválidos." 
                });
            }

            try
            {
                await this.appDbContext.TemporadaTbs.AddAsync(temporada);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 201, 
                    message = "Temporada creadoa con éxito.", 
                    Temporada = temporada 
                });
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Error al guardar en la base de datos.", 
                    error = dbEx.Message 
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Ocurrió un error inesperado.", 
                    error = ex.Message 
                });
            }
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] TemporadaTb temporadaa)
        {
            var producto = await this.appDbContext.TemporadaTbs.FindAsync(id);
            
            if (producto == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Temporada no encontrado." });
            }

            producto.Temporada = temporadaa.Temporada;
            producto.Actual = temporadaa.Actual;
            producto.Descripcion = temporadaa.Descripcion;
            producto.FechaInicio = temporadaa.FechaInicio;
            producto.FechaFin = temporadaa.FechaFin;
           
            
            await this.appDbContext.SaveChangesAsync();
            return Ok(new
            {
                isSuccess = true, status = 200, message = "Temporada actualizada exitosamente.", producto = producto
            });
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(string id)
        {
            var temporada = await this.appDbContext.TemporadaTbs.FindAsync(id);
            
            if (temporada == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Temporada no encontrada." });
            }
            
            this.appDbContext.TemporadaTbs.Remove(temporada);
            await this.appDbContext.SaveChangesAsync();
            
            return Ok(new { isSuccess = true, status = 200, message = "Temporada eliminada exitosamente." });
        }
    }    
}

