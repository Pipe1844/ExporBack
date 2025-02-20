using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/labores")]
    [ApiController]
    public class LaboresController : ControllerBase
    {
        // ReSharper disable once InconsistentNaming
        private readonly AppDbContext appDbContext;

        public LaboresController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        // GET: api/<LaboresController>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {


                var labores = await this.appDbContext.LaboresTbs.Select(l => new
                {
                    l.Labor,
                    l.Departamento,
                    l.Descripcion
                }).ToListAsync();

                return labores.Count == 0
                    ? Ok(new { isSuccess = true, status = 204, labores = new List<object>() })
                    : Ok(new { isSuccess = true, status = 200, labores = labores });
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

        // GET api/<LaboresController>/5
        [HttpGet("{id}/{departamento}")]
        public async Task<IActionResult> Show(string id, string departamento)
        {
            try
            {
                var labor = await this.appDbContext.LaboresTbs
                    .Where(l => l.Labor == id && l.Departamento == departamento)
                    .Select(l => new
                    {
                        l.Labor,
                        l.Departamento,
                        l.Descripcion
                    })
                    .FirstOrDefaultAsync();

                if (labor == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
                }

                return Ok(new { isSuccess = true, status = 200, labor = labor });
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

        // POST api/<LaboresController>
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] LaboresTb labor)
        {
            try
            {
                await this.appDbContext.LaboresTbs.AddAsync(labor);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 201, message = "Labor creado exitosamente.", labor
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

        // PUT api/<LaboresController>/5
        [HttpPut("{id}/{departamento}/{descripcion}")]
        public async Task<IActionResult> Update(string id, string departamento, string descripcion)
        {
            try
            {
                var labor = await this.appDbContext.LaboresTbs.FindAsync(id, departamento);

                if (labor == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
                }

                labor.Descripcion = descripcion;

                await this.appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 200, message = "Labor actualizado exitosamente.", labor = labor
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

        // DELETE api/<LaboresController>/
        [HttpDelete("{id}/{departamento}")]
        public async Task<IActionResult> Destroy(string id, string departamento)
        {
            try
            {
                var labor = await this.appDbContext.LaboresTbs.FindAsync(id, departamento);

                if (labor == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
                }

                this.appDbContext.LaboresTbs.Remove(labor);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new
                    { labor = labor, isSuccess = true, status = 200, message = "Labor eliminado exitosamente." });
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