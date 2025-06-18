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
            return StatusCode(500,
                new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
        }
    }

    [HttpGet("departamento/{departamento}/labor/{labor}/alias/{aliasLabor}")]
    public async Task<IActionResult> GetByDepartamentoLaborAlias(string departamento, string labor, string aliasLabor)
    {
        try
        {
            var ddtLabores = await this.appDbContext.DdtLaborTbs
                .Where(l => l.Departamento == departamento && l.Labor == labor && l.AliasLabor == aliasLabor)
                .Select(l => new { l.Ddt })
                .ToListAsync();

            Console.WriteLine(
                $"Buscando registros con Departamento: {departamento}, Labor: {labor}, AliasLabor: {aliasLabor}");

            if (ddtLabores.Count == 0)
            {
                return Ok(new
                {
                    isSuccess = false,
                    status = 204,
                    message = "DDTLabores no enontradas.",
                    DdtLabores = new List<object>()
                });
            }

            return Ok(new { isSuccess = true, status = 200, DDTLabores = ddtLabores });
        }
        catch (Exception ex)
        {
            return StatusCode(500,
                new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
        }
    }

    [HttpGet("{temporada}/{alias}")]
    public async Task<IActionResult> GetByTemporadaAliasLabor(string temporada, string alias)
    {
        try
        {
            var departamento = "RIEGO Y DRENAJE";
            var ddtLabores = await this.appDbContext.DdtLaborTbs
                .Where(l => l.Temporada == temporada && l.Departamento == departamento && l.AliasLabor == alias)
                .OrderBy(l => l.Ddt)
                .Select(l => new { l.Temporada, l.Departamento, l.Labor, l.AliasLabor, l.Ddt, l.SiembraNumero })
                .ToListAsync();

            if (ddtLabores.Count == 0)
            {
                return Ok(new
                {
                    isSuccess = true,
                    status = 204,
                    message = "Sin registros.",
                    DdtLabores = new List<object>()
                });
            }

            return Ok(new { isSuccess = true, status = 200, DDTLabores = ddtLabores });
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

    [HttpGet("{temporada}/labor/departamento/riego")]
    public async Task<IActionResult> GetAliasByDepartamento(string temporada)
    {
        try
        {
            var depart = "RIEGO Y DRENAJE";
            var ddtLabores = await this.appDbContext.DdtLaborTbs
                .Where(l => l.Temporada == temporada && l.Departamento == depart)
                .Select(l => new { l.AliasLabor })
                .Distinct()
                .ToListAsync();

            if (ddtLabores.Count == 0)
            {
                return Ok(new
                {
                    isSuccess = true,
                    status = 204,
                    message = "Sin registros.",
                    DdtLabores = new List<object>()
                });
            }

            return Ok(new { isSuccess = true, status = 200, DDTLabores = ddtLabores });
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


    [HttpGet("{temporada}/{departamento}/{labor}/{ddt}")]
    public async Task<IActionResult> Show(string temporada, string departamento, string labor, int ddt)
    {
        try
        {
            var ddtLabor = await appDbContext.DdtLaborTbs
                .Where(l => l.Temporada == temporada && l.Departamento == departamento && l.Labor == labor &&
                            l.Ddt == ddt)
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
            return StatusCode(500,
                new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
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

        Console.WriteLine(
            $"Recibido: {ddtLabor.Temporada}, {ddtLabor.SiembraNumero}, {ddtLabor.Departamento}, {ddtLabor.Labor}, {ddtLabor.AliasLabor}, {ddtLabor.Ddt}");

        try
        {
            // Validación de duplicados
            var existingDdtLabor = await this.appDbContext.DdtLaborTbs
                .FirstOrDefaultAsync(d => d.Temporada == ddtLabor.Temporada
                                          && d.SiembraNumero == ddtLabor.SiembraNumero
                                          && d.Departamento == ddtLabor.Departamento
                                          && d.Labor == ddtLabor.Labor
                                          && d.AliasLabor == ddtLabor.AliasLabor
                                          && d.Ddt == ddtLabor.Ddt);

            if (existingDdtLabor != null)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "El DDT ya existe." });
            }

            await this.appDbContext.DdtLaborTbs.AddAsync(ddtLabor);
            await this.appDbContext.SaveChangesAsync();

            return Ok(new
                { isSuccess = true, status = 201, message = "Labor DDT creada con éxito.", DDTLabor = ddtLabor });
        }
        catch (Exception ex)
        {
            return StatusCode(500,
                new { isSuccess = false, status = 500, message = "Ocurrió un error inesperado.", error = ex.Message });
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
                return NotFound(new { isSuccess = false, status = 404, message = "DDTLabor no encontrada." });
            }

            // Verificar si el DDT ya existe  
            var existingDdt = await this.appDbContext.DdtLaborTbs
                .FirstOrDefaultAsync(l => l.Ddt == ddtLabor.Ddt &&
                                          l.Temporada == temporada &&
                                          l.Departamento == departamento &&
                                          l.Labor == labor &&
                                          l.SiembraNumero == siembraNumero &&
                                          l.AliasLabor == aliasLabor);

            if (existingDdt != null)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Ddt ya existe." });
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

            return Ok(new
            {
                isSuccess = true, status = 200, message = "Labor DDT actualizada exitosamente.", DDTLabor = nuevaLabor
            });
        }
        catch (DbUpdateConcurrencyException ex)
        {
            return BadRequest(new
            {
                isSuccess = false, status = 409, message = "Conflicto de concurrencia detectado.", error = ex.Message
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new
                { isSuccess = false, status = 400, message = "Error al actualizar la labor.", error = ex.Message });
        }
    }


    [HttpDelete("{temporada}/{departamento}/{siembraNumero}/{labor}/{aliasLabor}/{ddt}")]
    public async Task<IActionResult> Destroy(string temporada, string departamento, int siembraNumero, string labor,
        string aliasLabor, int ddt)
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

    [HttpGet("{temporada}/{fechaInicio}/{fechaFinal}")]
    public async Task<IActionResult> FilterDdtAndLote(string temporada, string fechaInicio, string fechaFinal)
    {
        // Parse las fechas
        if (!DateTime.TryParse(fechaInicio, out var startDate) || !DateTime.TryParse(fechaFinal, out var endDate))
        {
            return BadRequest(new { isSuccess = false, message = "Fechas inválidas" });
        }
        
        // Convertir DateTime a DateOnly si es necesario
        var startDateOnly = DateOnly.FromDateTime(startDate.Date); // Solo la parte de la fecha
        var endDateOnly = DateOnly.FromDateTime(endDate.Date);
        
        var dataRaw = await appDbContext.DdtLaborTbs
            .Join(
                appDbContext.LotesPoTbs,
                d => new { d.Temporada, Siembra = d.SiembraNumero },
                l => new { l.Temporada, Siembra = l.SiembraNum },
                (d, l) => new { d, l }
            )
            .Where(joined =>
                joined.d.Temporada == temporada && //Parámetro temporada
                joined.l.FechaTrasplante != null
            )
            .ToListAsync();

        var data = dataRaw
            .Select(joined => new
            {
                joined.d.Temporada,
                joined.d.SiembraNumero,
                joined.d.Departamento,
                joined.d.Labor,
                joined.d.AliasLabor,
                joined.d.Ddt,
                joined.l.NombreLote,
                joined.l.FechaTrasplante,
                joined.l.Area,
                joined.l.AliasLote,
                FechaCalculada = joined.l.FechaTrasplante!.Value.AddDays(joined.d.Ddt)
            })
            .Where(x => x.FechaCalculada >= startDateOnly && x.FechaCalculada <= endDateOnly)
            .ToList();

        return Ok(data.Count == 0 ? new { isSuccess = true, status = 200, data} : new { isSuccess = true, status = 200, data });
    }
}