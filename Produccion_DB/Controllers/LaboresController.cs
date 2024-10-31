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
                var labores = await this.appDbContext.LaboresTbs.ToListAsync();

                if (labores == null || !labores.Any())
                {
                    return Ok(new { isSuccess = true, status = 204, labores = new {} });
                    //return NotFound(new { isSuccess = false, status = 404, message = "No se encontraron Labores." });
                }

                return Ok(new { isSuccess = true, status = 200, labores = labores });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = e.Message });
            }
        }

        // GET api/<LaboresController>/5
        [HttpGet("{laborId}/{departamento}")]
        public async Task<IActionResult> Show(string laborId, string departamento)
        {
            try
            {
                var labor = await this.appDbContext.ArticulosTbs.FindAsync(laborId, departamento);

                if (labor == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
                }

                return Ok(new { isSuccess = true, status = 200, labor = labor });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = e.Message });
            }
        }

        // POST api/<LaboresController>
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] LaboresTb labor)
        {
            try
            {
                if (labor == null)
                {
                    return BadRequest(new { isSuccess = false, status = 400, message = "Datos del labor inválidos." });
                }

                await this.appDbContext.LaboresTbs.AddAsync(labor);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 201, message = "Labor creado exitosamente.", articulo = labor
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = e.Message });
            }
        }

        // PUT api/<LaboresController>/5
        [HttpPut("{laborId}/{departamento}")]
        public async Task<IActionResult> Update(string laborId, string departamento, [FromBody] LaboresTb oldLabor)
        {
            try
            {
                var labor = await this.appDbContext.LaboresTbs.FindAsync(laborId,departamento);

                if (labor == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Articulo no encontrado." });
                }


                labor.Labor = oldLabor.Labor;
                labor.Departamento = oldLabor.Departamento;
                labor.Descripcion = oldLabor.Descripcion;

                await this.appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 200, message = "Labor actualizado exitosamente.", labor = labor
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = e.Message });
            }
        }

        // DELETE api/<LaboresController>/5
        [HttpDelete("{laborId}/{departamento}")]
        public async Task<IActionResult> Destroy(string laborId, string departamento)
        {
            try
            {
                var labor = await this.appDbContext.LaboresTbs.FindAsync(laborId,departamento);

                if (labor == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
                }

                this.appDbContext.LaboresTbs.Remove(labor);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "Labor eliminado exitosamente." });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = e.Message });
            }
        }
    }
}