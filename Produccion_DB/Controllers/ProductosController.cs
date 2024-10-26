using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

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
            var productos = await _appDbContext.ProductosTbs.ToListAsync();

            if (productos == null || !productos.Any())
            {
                return NotFound(new { isSuccess = false, status = 404, message = "No se encontraron productos." });
            }

            return Ok(new { isSuccess = true, status = 200, productos });
        }

        // GET: api/v2/productos/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(string id)
        {
            var producto = await _appDbContext.ProductosTbs.FindAsync(id);

            if (producto == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Producto no encontrado." });
            }

            return Ok(new { isSuccess = true, status = 200, producto });
        }

        // POST: api/v2/productos
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] ProductosTb producto)
        {
            if (producto == null)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Datos de producto inválidos." });
            }

            // Verificar campos requeridos
            if (string.IsNullOrEmpty(producto.NombreDescriptivo) ||
                string.IsNullOrEmpty(producto.TipoUso) ||
                string.IsNullOrEmpty(producto.NombreComercial) ||
                string.IsNullOrEmpty(producto.UnidadMedida) ||
                string.IsNullOrEmpty(producto.IngredienteActivo) ||
                (producto.ConcentracionIactivo == null || string.IsNullOrEmpty(producto.ConcentracionIactivo.ToString())) ||
                (producto.Activo == null || string.IsNullOrEmpty(producto.Activo.ToString())))
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Faltan campos requeridos." });
            }


            await _appDbContext.ProductosTbs.AddAsync(producto);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                isSuccess = true, status = 201, message = "Producto creado exitosamente.", producto
            });
        }

        // PUT: api/v2/productos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] ProductosTb productoActualizado)
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

        // DELETE: api/v2/productos/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(string id)
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
    }
}
