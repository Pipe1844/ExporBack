using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers;

    [Route("api/v2/DDTLabores")]
    [ApiController]
    public class DDTLaboresController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public DDTLaboresController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var ddtLabores = await this.appDbContext.DdtLaborTbs.Select(l => new
                {
                    l.Temporada,
                    l.SiembraNumero,
                    l.Departamento,
                    l.Labor,
                    l.AliasLabor,
                    l.Ddt
                }).ToListAsync();

                if (!ddtLabores.Any())
                {
                    return Ok(new { isSuccess = true, status = 204, DDTLabores = new object[] { } });
                }

                return Ok(new { isSuccess = true, status = 200, DDTLabores = ddtLabores });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }
        
        [HttpGet("alias/{aliasLabor}")]
        public async Task<IActionResult> GetByAliasLabor(string aliasLabor)
        {
            try
            {
                var ddtLabores = await this.appDbContext.DdtLaborTbs
                    .Where(l => l.AliasLabor == aliasLabor)
                    .Select(l => new { l.Ddt })
                    .ToListAsync();
                Console.WriteLine($"Buscando registros con el alias: {aliasLabor}");
                
                if (!ddtLabores.Any())
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "No se encontraron registros con ese alias." });
                }

                return Ok(new { isSuccess = true, status = 200, DDTLabores = ddtLabores });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }

        [HttpGet("{temporada}/{departamento}/{labor}/{ddt}")]
        public async Task<IActionResult> Show(string temporada, string departamento, string labor, int ddt)
        {
            try
            {
                var ddtLabor = await appDbContext.DdtLaborTbs
                    .Where(l => l.Temporada == temporada && l.Departamento == departamento && l.Labor == labor && l.Ddt == ddt)
                    .Select(l => new { l.Temporada, l.SiembraNumero, l.Departamento, l.Labor, l.AliasLabor, l.Ddt })
                    .ToListAsync();

                if (!ddtLabor.Any())
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrada." });
                }

                return Ok(new { isSuccess = true, status = 200, DDTLabores = ddtLabor });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Store([FromBody] DdtLaborTb ddtLabor)
        {
            if (ddtLabor == null)
            {
                Console.WriteLine("El objeto recibido es nulo.");
                return BadRequest(new { isSuccess = false, status = 400, message = "Datos inválidos." });
            }

            Console.WriteLine($"Recibido: {ddtLabor.Temporada}, {ddtLabor.SiembraNumero}, {ddtLabor.Departamento}, {ddtLabor.Labor}, {ddtLabor.AliasLabor}, {ddtLabor.Ddt}");

            try
            {
                
                await this.appDbContext.DdtLaborTbs.AddAsync(ddtLabor);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 201, message = "Labor DDT creada con éxito.", DDTLabor = ddtLabor });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
            }
        }


        [HttpPut("{temporada}/{departamento}/{siembraNumero}/{labor}/{aliasLabor}/{ddt}")]
        public async Task<IActionResult> Update(
            string temporada, string departamento, string labor, int siembraNumero, 
            string aliasLabor, int ddt, [FromBody] DdtLaborTb ddtLabor)
        {
            try
            {
                // Buscar el registro actual con el Ddt existente
                var laborT = await this.appDbContext.DdtLaborTbs.FirstOrDefaultAsync(l =>
                    l.Temporada == temporada &&
                    l.Departamento == departamento &&
                    l.Labor == labor &&
                    l.SiembraNumero == siembraNumero &&
                    l.AliasLabor == aliasLabor &&
                    l.Ddt == ddt);

                if (laborT == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrada." });
                }

                // Crear una nueva instancia con el nuevo Ddt
                var nuevaLabor = new DdtLaborTb
                {
                    Temporada = laborT.Temporada,
                    Departamento = laborT.Departamento,
                    Labor = laborT.Labor,
                    SiembraNumero = laborT.SiembraNumero,
                    AliasLabor = laborT.AliasLabor,
                    Ddt = ddtLabor.Ddt // Nuevo Ddt
                };

                // Eliminar el registro anterior
                this.appDbContext.DdtLaborTbs.Remove(laborT);

                // Agregar la nueva instancia
                this.appDbContext.DdtLaborTbs.Add(nuevaLabor);

                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "Labor DDT actualizada exitosamente.", DDTLabor = nuevaLabor });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(new { isSuccess = false, status = 409, message = "Conflicto de concurrencia detectado.", error = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Error al actualizar la labor.", error = ex.Message });
            }
        }




        [HttpDelete("{temporada}/{departamento}/{siembraNumero}/{labor}/{aliasLabor}/{ddt}")]
        public async Task<IActionResult> Destroy(string temporada, string departamento, int siembraNumero, string labor, string aliasLabor, int ddt)
        {
            var laborT = await this.appDbContext.DdtLaborTbs
                .FirstOrDefaultAsync(lT => lT.Temporada == temporada 
                                           && lT.Departamento == departamento 
                                           && lT.SiembraNumero == siembraNumero
                                           && lT.Labor == labor 
                                           && lT.AliasLabor == aliasLabor
                                           && lT.Ddt == ddt);
    
            if (laborT == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Labor no encontrada." });
            }

            this.appDbContext.DdtLaborTbs.Remove(laborT);
            await this.appDbContext.SaveChangesAsync();
    
            return Ok(new { isSuccess = true, status = 200, message = "Labor DDT eliminada exitosamente." });
        }

    }