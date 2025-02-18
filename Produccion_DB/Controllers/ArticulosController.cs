using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/articulos")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        // ReSharper disable once InconsistentNaming
        private readonly AppDbContext appDbContext;

        public ArticulosController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var articles = await this.appDbContext.ArticulosTbs.Select(a => new
                    {
                        a.IdArticulo,
                        a.NombreArticulo,
                        a.Tipo,
                        a.Marca,
                        a.Modelo,
                        a.Color,
                        a.Placa,
                        a.NumeroChasis,
                        a.NumeroMotor,
                        a.Observaciones
                    })
                    .ToListAsync();

                return articles.Count == 0
                    ? Ok(new { isSuccess = true, status = 204, articulos = new List<object>() })
                    : Ok(new { isSuccess = true, status = 200, articulos = articles });
            }
            // Manejo específico de errores relacionados con la base de datos
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
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            try
            {

                var articles = await this.appDbContext.ArticulosTbs.Select(a => new
                    {
                        a.IdArticulo,
                        a.NombreArticulo,
                        a.Tipo,
                        a.Marca,
                        a.Modelo,
                        a.Color,
                        a.Placa,
                        a.NumeroChasis,
                        a.NumeroMotor,
                        a.Observaciones
                    })
                    .FirstOrDefaultAsync(ar => ar.IdArticulo == id);

                if (articles == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Articulo no encontrado." });
                }

                return Ok(new { isSuccess = true, status = 200, articulo = articles });
            }   // Manejo específico de errores relacionados con la base de datos
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
        public async Task<IActionResult> Store([FromBody] ArticulosTb article)
        {
            try
            {
                await this.appDbContext.ArticulosTbs.AddAsync(article);
                await this.appDbContext.SaveChangesAsync();
                
                return Ok(new
                {
                    isSuccess = true, status = 201, message = "Articulo creado exitosamente.", articulo = article
                });
            }
            // Manejo específico de errores relacionados con la base de datos
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
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] ArticulosTb articulo)
        {
            try
            {
                var producto = await this.appDbContext.ArticulosTbs.FindAsync(id);

                if (producto == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Articulo no encontrado." });
                }


                producto.NombreArticulo = articulo.NombreArticulo;
                producto.Tipo = articulo.Tipo;
                producto.Marca = articulo.Marca;
                producto.Modelo = articulo.Modelo;
                producto.Color = articulo.Color;
                producto.Placa = articulo.Placa;
                producto.NumeroChasis = articulo.NumeroChasis;
                producto.NumeroMotor = articulo.NumeroMotor;
                producto.Observaciones = articulo.Observaciones;

                await this.appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 200, message = "Articulo actualizado exitosamente.", producto = producto
                });
            }   // Manejo específico de errores relacionados con la base de datos
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
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(string id)
        {
            try
            {
                var producto = await this.appDbContext.ArticulosTbs.FindAsync(id);

                if (producto == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Articulo no encontrado." });
                }

                this.appDbContext.ArticulosTbs.Remove(producto);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "Articulo eliminado exitosamente." });
            }   // Manejo específico de errores relacionados con la base de datos
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