using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;
using Microsoft.Data.SqlClient;


namespace Produccion_DB.Controllers
{
    [Route("api/v2/LaboresT")]
    [ApiController]

    public class LaboresTemporadaController : Controller
    {
        private readonly AppDbContext appDbContext;

        public LaboresTemporadaController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var laboresTemporada = await this.appDbContext.LaborTTbs.Select(l => new
                {
                    l.Temporada,
                    l.SiembraNumero,
                    l.Departamento,
                    l.Labor,
                    l.AliasLabor,
                    l.AplicarATodo,
                    l.AplicarA

                }).ToListAsync();

                if (laboresTemporada.Count==0)
                {
                    return Ok(new 
                    { 
                        isSuccess = true, 
                        status = 204, 
                        LaboresTemporada = new List<object>() 
                    });
                }
                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 200, 
                    LaboresTemporada = laboresTemporada 
                });
            }
            catch (DbUpdateException dbEx)
            { 
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Ocurrió un error al acceder a la base de datos.", 
                    error = dbEx.Message,
                    innerError = dbEx.InnerException?.Message
                });
            }
            // Manejo de errores generales
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

        [HttpGet("{temporada}/{departamento}/{labor}")]
         public async Task<IActionResult> Show(string temporada,string departamento, string labor)
            {
                try
                {
                     var laboresTemporada = await appDbContext.LaborTTbs
                         .Where(l =>l.Temporada == temporada && l.Departamento == departamento && l.Labor == labor)
                         .Select(l => new
                         {
                             l.Temporada,
                             l.SiembraNumero,
                             l.Departamento,
                             l.Labor,
                             l.AliasLabor,
                             l.AplicarATodo,
                             l.AplicarA
                         })
                         .ToListAsync();
                     
                    if (laboresTemporada.Count==0)
                    {
                     return NotFound(new 
                     { 
                         isSuccess = false, 
                         status = 404, 
                         message = "labores no enontradas." 
                     });
                    }
                    return Ok(new 
                    { 
                     isSuccess = true, 
                     status = 200, 
                     LaboresTemporada = laboresTemporada 
                    }); 
                }
                catch (DbUpdateException dbEx)
                { 
                    return StatusCode(500, new 
                    { 
                        isSuccess = false, 
                        status = 500, 
                        message = "Ocurrió un error al acceder a la base de datos.", 
                        error = dbEx.Message,
                        innerError = dbEx.InnerException?.Message
                    });
                }
                // Manejo de errores generales
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
        public async Task<IActionResult> Store([FromBody] LaborTTb laboresTemporada)
        {
           
            try
            {
                await this.appDbContext.LaborTTbs.AddAsync(laboresTemporada);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new 
                { 
                    isSuccess = true, 
                    status = 201, 
                    message = "labor Temporada creado con éxito.", 
                    LaboresTemporada = laboresTemporada 
                });
            }
            catch (DbUpdateException dbEx)
            { 
                return StatusCode(500, new 
                { 
                    isSuccess = false, 
                    status = 500, 
                    message = "Ocurrió un error al acceder a la base de datos.", 
                    error = dbEx.Message,
                    innerError = dbEx.InnerException?.Message
                });
            }
            // Manejo de errores generales
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

        [HttpPut("{temporada}/{departamento}/{siembraNumero}/{labor}/{aliasLabor}")]
        public async Task<IActionResult> Update(string temporada,string departamento, int siembraNumero,string labor, string aliasLabor,
            [FromBody] LaborTTb laboresTemporada)
        {
            var laborT = await this.appDbContext.LaborTTbs
                .FirstOrDefaultAsync(llabor => llabor.Temporada == temporada && llabor.Departamento == departamento && llabor.Labor == labor 
                                               && llabor.SiembraNumero == siembraNumero && llabor.AliasLabor == aliasLabor);
            
            if (laborT == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "labor no encontrado." });
            }
            laborT.AplicarATodo = laboresTemporada.AplicarATodo;
            laborT.AplicarA = laboresTemporada.AplicarA;
            
            await this.appDbContext.SaveChangesAsync();
            return Ok(new
            {
                isSuccess = true, status = 200, message = "Labor actualizado exitosamente.", laboresTemporada = laborT
            });
        }

        [HttpDelete("{temporada}/{depatamento}/{labor}")]
        public async Task<IActionResult> Destroy(string temporada, string depatamento, string labor)
        {
            var laborT = await this.appDbContext.LaborTTbs
                .FirstOrDefaultAsync(lT =>lT.Temporada == temporada && lT.Departamento == depatamento && lT.Labor == labor);
            
            if (laborT == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "labor no encontrado." });
            }
            this.appDbContext.LaborTTbs.Remove(laborT);
            await this.appDbContext.SaveChangesAsync();
            
            return Ok(new { isSuccess = true, status = 200, message = "LaborT eliminado exitosamente." });
        } 
    }
}