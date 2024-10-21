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
            var articulos = await this.appDbContext.ArticulosTbs.ToListAsync();

            if (articulos == null || !articulos.Any())
            {
                return NotFound(new { isSuccess = false, status = 404, message = "No se encontraron Articulos." });
            }

            return Ok(new { isSuccess = true, status = 200, articulos = articulos });
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Show(int id)
        {
            var articulo = await this.appDbContext.ArticulosTbs.FindAsync(id);
            
            if (articulo == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Articulo no encontrado." });
            }
            
            return Ok(new { isSuccess = true, status = 200, producto = articulo });
        }
        
        [HttpPost]
        public async Task<IActionResult> Store([FromBody] ArticulosTb articulo)
        {
            if (articulo == null)
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Datos de articulo inválidos." });
            }
            
            await this.appDbContext.ArticulosTbs.AddAsync(articulo);
            await this.appDbContext.SaveChangesAsync();
            
            return Ok(new
            {
                isSuccess = true, status = 201, message = "Articulo creado exitosamente.", articulo = articulo
            });
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ArticulosTb articulo)
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
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Destroy(int id)
        {
            var producto = await this.appDbContext.ArticulosTbs.FindAsync(id);
            
            if (producto == null)
            {
                return NotFound(new { isSuccess = false, status = 404, message = "Articulo no encontrado." });
            }
            
            this.appDbContext.ArticulosTbs.Remove(producto);
            await this.appDbContext.SaveChangesAsync();
            
            return Ok(new { isSuccess = true, status = 200, message = "Articulo eliminado exitosamente." });
        }
    }
}