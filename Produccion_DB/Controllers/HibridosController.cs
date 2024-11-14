using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/hibridos")]
    [ApiController]

    public class HibridosController : Controller
    {
        private readonly AppDbContext appDbContext;

        public HibridosController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                // Intentamos obtener la lista de hibridos
                var hibridos = await this.appDbContext.HibridosTbs.ToListAsync();

                // Verificamos si la lista está vacía
                if (hibridos == null || !hibridos.Any())
                {
                    return Ok(new 
                    { 
                        isSuccess = true, 
                        status = 204, 
                        Hibridos = new List<Object>() 
                    });
                }
                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    Hibridos = hibridos 
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
        
        [HttpGet("{cultivo}/{variedad}/{hibrido}")]
        public async Task<IActionResult> Show(string cultivo, string variedad, string hibrido)
        {
            try
            {
                var hibridoBuscar = await this.appDbContext.HibridosTbs
                .FirstOrDefaultAsync(h => h.Cultivo == cultivo && h.Variedad == variedad && h.Hibrido==hibrido);
        
                if (hibridoBuscar == null)
                {
                    return NotFound(new 
                    { 
                        isSuccess = false, 
                        status = 404, 
                        message = "hibrido no encontrado." 
                    });
                }

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    Hibrido = hibridoBuscar 
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
        public async Task<IActionResult> Store([FromBody] HibridosTb hibrido)
        {
            if (hibrido == null)
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
                await this.appDbContext.HibridosTbs.AddAsync(hibrido);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 201, 
                    message = "Hibrido creado con éxito.", 
                    Hibrido = hibrido 
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
        
        [HttpPut("{cultivo}/{variedad}/{hibrido}")]
        public async Task<IActionResult> Update(string cultivo, string variedad, string hibrido, [FromBody] HibridosTb hibridos)
        {
            var hibridosModif = await this.appDbContext.HibridosTbs
                .FirstOrDefaultAsync(h => h.Cultivo == cultivo && h.Variedad == variedad && h.Hibrido==hibrido);
            
            if (hibridosModif == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Hibrido no encontrado." });
            }

            hibridosModif.Cultivo = hibridos.Cultivo;
            hibridosModif.Variedad = hibridos.Variedad;
            hibridosModif.Hibrido = hibridos.Hibrido;
            hibridosModif.Identificador = hibridos.Identificador;
            hibridosModif.Abreviatura = hibridos.Abreviatura;
            hibridosModif.Descripcion = hibridos.Descripcion;
            hibridosModif.Activo = hibridos.Activo;
            
           
            
            await this.appDbContext.SaveChangesAsync();
            return Ok(new
            {
                isSuccess = true, status = 200, message = "Hibrido actualizado exitosamente.", hibridoModificado = hibridosModif
            });
        }
        
        [HttpDelete("{cultivo}/{variedad}/{hibrido}")]
        public async Task<IActionResult> Destroy(string cultivo, string variedad, string hibrido)
        {
            var hibridoDel = await this.appDbContext.HibridosTbs
                .FirstOrDefaultAsync(h => h.Cultivo == cultivo && h.Variedad == variedad && h.Hibrido == hibrido);
            
            if (hibridoDel == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "hibrido no encontrado." });
            }
            
            this.appDbContext.HibridosTbs.Remove(hibridoDel);
            await this.appDbContext.SaveChangesAsync();
            
            return Ok(new { isSuccess = true, status = 200, message = "hibrido eliminado exitosamente." });
        }
    }
}