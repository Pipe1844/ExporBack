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
            var labores = await this.appDbContext.LaboresTbs.ToListAsync();

            if (labores == null || !labores.Any())
            {
                return Ok(new { isSuccess = true, status = 204, labores = new List<Object>() });
            }

            return Ok(new { isSuccess = true, status = 200, labores = labores });
        }

        // GET api/<LaboresController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            var labor = await this.appDbContext.ArticulosTbs.FindAsync(id);

            if (labor == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
            }

            return Ok(new { isSuccess = true, status = 200, labor = labor });
        }

        // POST api/<LaboresController>
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] LaboresTb labor)
        {
            if (labor == null)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Datos del labor inválidos." });
            }

            await this.appDbContext.LaboresTbs.AddAsync(labor);
            await this.appDbContext.SaveChangesAsync();

            return Ok(new
            {
                isSuccess = true, status = 201, message = "Labor creado exitosamente.", labor = labor
            });
        }

        // PUT api/<LaboresController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] LaboresTb oldLabor)
        {
            var labor = await this.appDbContext.LaboresTbs.FindAsync(id);

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

        // DELETE api/<LaboresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(string id)
        {
            var labor = await this.appDbContext.LaboresTbs.FindAsync(id);

            if (labor == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrado." });
            }

            this.appDbContext.LaboresTbs.Remove(labor);
            await this.appDbContext.SaveChangesAsync();

            return Ok(new { isSuccess = true, status = 200, message = "Labor eliminado exitosamente." });
        }
    }
}