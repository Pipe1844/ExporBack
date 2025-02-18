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
                var variedades = await this.appDbContext.VariedadTbs.
                    Select(v=>new
                    {
                        v.Variedad,
                        v.Cultivo,
                        v.NombreAbreviatura,
                        v.Descripcion
                    })
                    .ToListAsync();

                // Verificamos si la lista está vacía
                if (variedades.Count==0)
                {
                    return Ok(new 
                    { 
                        isSuccess = true, 
                        status = 204, 
                        Variedades = new List<object>() 
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
        
        [HttpGet("{cultivo}/{variedad}")]
        public async Task<IActionResult> Show(string cultivo, string variedad)
        {
            try
            {
                var variedadBuscar = await this.appDbContext.VariedadTbs.
                    Select(v=>new
                    {
                        v.Variedad,
                        v.Cultivo,
                        v.NombreAbreviatura,
                        v.Descripcion
                    }).FirstOrDefaultAsync(va=>va.Variedad==variedad && va.Cultivo==cultivo);
        
                if (variedadBuscar == null)
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
                    Variedad = variedadBuscar 
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
        public async Task<IActionResult> Store([FromBody] VariedadTb variedad)
        {
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
        
        [HttpPut("{cultivo}/{variedad}")]
        public async Task<IActionResult> Update(string cultivo, string variedad, [FromBody] VariedadTb variedades)
        {
            try
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
                    isSuccess = true, status = 200, message = "Variedad actualizada exitosamente.", variedadModific
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
        
        [HttpDelete("{cultivo}/{variedad}")]
        public async Task<IActionResult> Destroy(string cultivo, string variedad)
        {
            try
            {
                var variedaDel = await this.appDbContext.VariedadTbs
                    .FirstOrDefaultAsync(v => v.Cultivo == cultivo && v.Variedad == variedad);

                if (variedaDel == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "variedad no encontrada." });
                }

                this.appDbContext.VariedadTbs.Remove(variedaDel);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "variedad eliminada exitosamente." });
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
    }
}