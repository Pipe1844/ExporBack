using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;
using System;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ProductosController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // GET: api/v2/productos
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var productos = await _appDbContext.ProductosTbs.
                    Select(p =>new
                    {
                        p.IdProducto,
                        p.NombreDescriptivo,
                        p.TipoUso,
                        p.NombreComercial,
                        p.UnidadMedida,
                        p.IngredienteActivo,
                        p.ConcentracionIactivo,
                        p.RestriccionIngreso,
                        p.Descripcion,
                        p.Activo
                    })
                    .ToListAsync();

                return productos.Count==0 ? 
                    Ok(new { isSuccess = true, status = 204, Productos = new List<object>() }) : 
                    Ok(new { isSuccess = true, status = 200, Productos = productos });
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

        // GET: api/v2/productos/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            try
            {
                var producto = await _appDbContext.ProductosTbs.
                    Select(p =>new
                    {
                        p.IdProducto,
                        p.NombreDescriptivo,
                        p.TipoUso,
                        p.NombreComercial,
                        p.UnidadMedida,
                        p.IngredienteActivo,
                        p.ConcentracionIactivo,
                        p.RestriccionIngreso,
                        p.Descripcion,
                        p.Activo
                    }).FirstOrDefaultAsync(p=>p.IdProducto==id);

                if (producto == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Producto no encontrado." });
                }

                return Ok(new { isSuccess = true, status = 200, producto });
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

        // POST: api/v2/productos
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] ProductosTb producto)
        {
            try
            {
              
                await _appDbContext.ProductosTbs.AddAsync(producto);
                await _appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 201, message = "Producto creado exitosamente.", producto
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

        // PUT: api/v2/productos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] ProductosTb productoActualizado)
        {
            try
            {
                var producto = await _appDbContext.ProductosTbs.FindAsync(id);

                if (producto == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Producto no encontrado." });
                }


                // Actualizar los atributos del producto
                producto.NombreDescriptivo = productoActualizado.NombreDescriptivo;
                producto.TipoUso = productoActualizado.TipoUso;
                producto.NombreComercial = productoActualizado.NombreComercial;
                producto.UnidadMedida = productoActualizado.UnidadMedida;
                producto.IngredienteActivo = productoActualizado.IngredienteActivo;
                producto.ConcentracionIactivo = productoActualizado.ConcentracionIactivo;
                producto.RestriccionIngreso = productoActualizado.RestriccionIngreso;
                producto.Descripcion = productoActualizado.Descripcion;
                producto.Activo = productoActualizado.Activo;

                await _appDbContext.SaveChangesAsync();

                return Ok(new
                {
                    isSuccess = true, status = 200, message = "Producto actualizado exitosamente.", producto
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

        // DELETE: api/v2/productos/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(string id)
        {
            try
            {
                var producto = await _appDbContext.ProductosTbs.FindAsync(id);

                if (producto == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "Producto no encontrado." });
                }

                _appDbContext.ProductosTbs.Remove(producto);
                await _appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "Producto eliminado exitosamente." });
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
