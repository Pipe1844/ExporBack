using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers;

[Route("api/v2/PoPedidoProductos")]
[ApiController]
public class PoPedidoProductosController : Controller
{
    private readonly AppDbContext appDbContext;

    public PoPedidoProductosController(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        try
        {
            var PoPedidoProductos = await this.appDbContext.KnPoPedidoProductosTbs.ToListAsync();

            // Verificamos si la lista está vacía
            if (PoPedidoProductos.Count == 0)
            {
                return Ok(new
                {
                    isSuccess = true,
                    status = 204,
                    PoPedidoProductos = new List<object>()
                });
            }

            return Ok(new
            {
                isSuccess = true,
                status = 200,
                PoPedidoProductos = PoPedidoProductos
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

    [HttpGet("{idPedido}/{idProducto}/{NumBoleta}")]
    public async Task<IActionResult> Show(string idPedido, int idProducto, int numBoleta)
    {
        try
        {
            var PoPedidoProductos = await this.appDbContext.KnPoPedidoProductosTbs.Where(l => l.NumBoleta == numBoleta)
                .ToListAsync();

            if (PoPedidoProductos == null)
            {
                return NotFound(new
                {
                    isSuccess = false,
                    status = 404,
                    message = "PoPedidoProductos no encontrado."
                });
            }

            return Ok(new
            {
                isSuccess = true,
                status = 200,
                PoPedidoProductos = PoPedidoProductos
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
    
    [HttpGet("{Temporada}/{SiembraNum}/{Departamento}/{Cultivo}/{aliasLabor}/{aliasLote}/{fechaBase}/{Ddt}/{areaSiembra}")]
    public async Task<IActionResult> Show(
        string Temporada,
        int SiembraNum,
        string Departamento,
        string Cultivo,
        string aliasLabor,
        string aliasLote,
        DateOnly fechaBase,
        int Ddt,
        float areaSiembra)
    {
        try
        {
            var PoPedidoProductos = await this.appDbContext.KnPoPedidoProductosTbs
                .Where(r =>
                    r.Temporada == Temporada &&
                    r.SiembraNum == SiembraNum &&
                    r.Departamento == Departamento &&
                    r.Cultivo == Cultivo &&
                    r.AliasLabor == aliasLabor &&
                    r.AliasLote == aliasLote &&
                    r.FechaBase == fechaBase &&
                    r.Ddt == Ddt &&
                    r.AreaSiembra == areaSiembra)
                .ToListAsync();

            if (PoPedidoProductos == null)
            {
                return NotFound(new
                {
                    isSuccess = false,
                    status = 404,
                    message = "PoPedidoProductos no encontrado."
                });
            }

            return Ok(new
            {
                isSuccess = true,
                status = 200,
                PoPedidoProductos = PoPedidoProductos
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
    public async Task<IActionResult> Store([FromBody] KnPoPedidoProductosTb poPedidoProductos)
    {
        try
        {
            await this.appDbContext.KnPoPedidoProductosTbs.AddAsync(poPedidoProductos);
            await this.appDbContext.SaveChangesAsync();

            return Ok(new
            {
                isSuccess = true,
                status = 201,
                message = "poPedidoProductos creado con éxito.",
                poPedidoProductos = poPedidoProductos
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
}