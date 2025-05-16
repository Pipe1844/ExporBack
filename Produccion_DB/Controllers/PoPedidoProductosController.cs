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
    
    [HttpGet("lastBoleta")]
    public async Task<IActionResult> GetLastBoleta()
    {
        try
        {
            //var lastBoleta = await this.appDbContext.KnPoPedidoProductosTbs.ToListAsync();

            var ultimaBoleta = await this.appDbContext.KnPoPedidoProductosTbs
                .OrderByDescending(p => p.NumBoleta)
                .Select(p => new { p.NumBoleta,})
                .FirstOrDefaultAsync();

            return Ok(new
            {
                isSuccess = true,
                status = 200,
                ultimaBoleta
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
            var PoPedidoProductos = await appDbContext.KnPoPedidoProductosTbs
                .Join(
                    appDbContext.ProductosTbs,
                    pedido => pedido.IdProducto,
                    producto => producto.IdProducto,
                    (pedido, producto) => new
                    {
                        // Unimos todo en un solo bloque tipo JSON
                        IdPedido = pedido.IdPedido,
                        IdProducto = pedido.IdProducto,
                        NumBoleta = pedido.NumBoleta,
                        Temporada = pedido.Temporada,
                        SiembraNum = pedido.SiembraNum,
                        Departamento = pedido.Departamento,
                        Cultivo = pedido.Cultivo,
                        AliasLabor = pedido.AliasLabor,
                        AliasLote = pedido.AliasLote,
                        FechaBase = pedido.FechaBase,
                        Ddt = pedido.Ddt,
                        AreaSiembra = pedido.AreaSiembra,
                        UnidadesPorLote = pedido.UnidadesPorLote,
                        NombreDescriptivo = pedido.NombreDescriptivo,
                        FechaPedido = pedido.FechaPedido,
                        Requisado = pedido.Requisado,
                        Aprueba = pedido.Aprueba,
                        Recive = pedido.Recive,
                        Rdistribuye = pedido.Rdistribuye,
                        Rcabezalero = pedido.Rcabezalero,
                        UnidadMedida = producto.UnidadMedida // ← Este es el extra
                    }
                )
                .Where(joined =>
                    joined.Temporada == Temporada &&
                    joined.SiembraNum == SiembraNum &&
                    joined.Departamento == Departamento &&
                    joined.Cultivo == Cultivo &&
                    joined.AliasLabor == aliasLabor &&
                    joined.AliasLote == aliasLote &&
                    joined.FechaBase == fechaBase &&
                    joined.Ddt == Ddt &&
                    joined.AreaSiembra == areaSiembra
                )
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