using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/variedades")]
    [ApiController]

    public class VariedadesController : Controller
    {
        private readonly AppDbContext appDbContext;

        public VariedadesController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                // Intentamos obtener la lista de temporadas
                var variedades = await this.appDbContext.VariedadTbs.ToListAsync();

                // Verificamos si la lista está vacía
                if (variedades == null || !variedades.Any())
                {
                    return Ok(new 
                    { 
                        isSuccess = true, 
                        status = 204, 
                        Variedades = new List<Object>() 
                    });
                }
                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    Variedades = variedades 
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
                var variedad = await this.appDbContext.VariedadTbs.FindAsync(id);
        
                if (variedad == null)
                {
                    return NotFound(new 
                    { 
                        isSuccess = false, 
                        status = 404, 
                        message = "variedad no encontrada." 
                    });
                }

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    Variedad = variedad 
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
        public async Task<IActionResult> Store([FromBody] VariedadTb variedad)
        {
            if (variedad == null)
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
                await this.appDbContext.VariedadTbs.AddAsync(variedad);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 201, 
                    message = "Variedad creada con éxito.", 
                    Variedad = variedad 
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
        
        [HttpPut("{cultivo}/{variedad}")]
        public async Task<IActionResult> Update(string cultivo, string variedad, [FromBody] VariedadTb variedades)
        {
            var variedadModific = await this.appDbContext.VariedadTbs
                .FirstOrDefaultAsync(v => v.Cultivo == cultivo && v.Variedad == variedad);
            
            if (variedadModific == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Variedad no encontrada." });
            }

            variedadModific.Cultivo = variedades.Cultivo;
            variedadModific.Variedad = variedades.Variedad;
            variedadModific.NombreAbreviatura = variedades.NombreAbreviatura;
            variedadModific.Descripcion = variedades.Descripcion;
            
           
            
            await this.appDbContext.SaveChangesAsync();
            return Ok(new
            {
                isSuccess = true, status = 200, message = "Variedad actualizada exitosamente.", variedadModific = variedadModific
            });
        }
        
        [HttpDelete("{cultivo}/{variedad}")]
        public async Task<IActionResult> Destroy(string cultivo, string variedad)
        {
            var variedade = await this.appDbContext.VariedadTbs
                .FirstOrDefaultAsync(v => v.Cultivo == cultivo && v.Variedad == variedad);
            
            if (variedade == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "variedad no encontrada." });
            }
            
            this.appDbContext.VariedadTbs.Remove(variedade);
            await this.appDbContext.SaveChangesAsync();
            
            return Ok(new { isSuccess = true, status = 200, message = "variedad eliminada exitosamente." });
        }
    }
}