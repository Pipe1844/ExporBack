using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/Lotes")]
    [ApiController]
   public class LotesController : Controller
   {
       private readonly AppDbContext appDbContext;
       
       public LotesController(AppDbContext appDbContext)
       {
           this.appDbContext = appDbContext;
       }
       
       [HttpGet]
               public async Task<IActionResult> Index()
               {
                   try
                   {
                       // Intentamos obtener la lista de temporadas
                       var lotes = await this.appDbContext.LotesFisicosTbs.ToListAsync();
       
                       // Verificamos si la lista está vacía
                       if (lotes == null || !lotes.Any())
                       {
                           return Ok(new 
                           { 
                               isSuccess = true, 
                               status = 204, 
                               Lotes = new {} 
                           });
                       }
                       return Ok(new 
                       { 
                           isSuccess = true, 
                           status = 200, 
                           Lotes = lotes 
                       });
                   }
                   catch (DbUpdateException dbEx)
                   {
                       // Manejo específico de errores relacionados con la base de datos
                       return StatusCode(500, new 
                       { 
                           isSuccess = false, 
                           status = 500, 
                           message = "Ocurrió un error al acceder a la base de datos.", 
                           error = dbEx.Message 
                       });
                   }
                   catch (Exception ex)
                   {
                       // Manejo de errores generales
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
                               var lote = await this.appDbContext.LotesFisicosTbs.FindAsync(id);
                       
                               if (lote == null)
                               {
                                   return NotFound(new 
                                   { 
                                       isSuccess = false, 
                                       status = 404, 
                                       message = "Lote no encontrado." 
                                   });
                               }
               
                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 200, 
                                   Lotes = lote 
                               });
                           }
                           catch (DbUpdateException dbEx)
                           {
                               return StatusCode(500, new 
                               { 
                                   isSuccess = false, 
                                   status = 500, 
                                   message = "Error al acceder a la base de datos.", 
                                   error = dbEx.Message 
                               });
                           }
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
                       public async Task<IActionResult> Store([FromBody] LotesFisicosTb lote)
                       {
                           if (lote == null)
                           {
                               return BadRequest(new 
                               { 
                                   isSuccess = false, 
                                   status = 400, 
                                   message = "Datos inválidos." 
                               });
                           }

                           try
                           {
                               await this.appDbContext.LotesFisicosTbs.AddAsync(lote);
                               await this.appDbContext.SaveChangesAsync();

                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 201, 
                                   message = "Lote creado con éxito.", 
                                   Lote = lote 
                               });
                           }
                           catch (DbUpdateException dbEx)
                           {
                               return StatusCode(500, new 
                               { 
                                   isSuccess = false, 
                                   status = 500, 
                                   message = "Error al guardar en la base de datos.", 
                                   error = dbEx.Message 
                               });
                           }
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
                       public async Task<IActionResult> Update(string id, [FromBody] LotesFisicosTb lote)
                       {
                           var Lote = await this.appDbContext.LotesFisicosTbs.FindAsync(id);
            
                           if (Lote == null)
                           {
                               return NotFound(new { isSuccess = false, status = 404, message = "Lote no encontrado." });
                           }

                           Lote.NombreLote = lote.NombreLote;
                           Lote.Activo = lote.Activo;
                           Lote.Descripcion = lote.Descripcion;
                           Lote.Area = lote.Area;
                           
                           await this.appDbContext.SaveChangesAsync();
                           return Ok(new
                           {
                               isSuccess = true, status = 200, message = "Lote actualizado exitosamente.", producto = Lote
                           });
                       }
                       [HttpDelete("{id}")]
                       public async Task<IActionResult> Destroy(string id)
                       {
                           var lote = await this.appDbContext.LotesFisicosTbs.FindAsync(id);
            
                           if (lote == null)
                           {
                               return NotFound(new { isSuccess = false, status = 404, message = "Lote no encontrado." });
                           }
            
                           this.appDbContext.LotesFisicosTbs.Remove(lote);
                           await this.appDbContext.SaveChangesAsync();
            
                           return Ok(new { isSuccess = true, status = 200, message = "Lote eliminado exitosamente." });
                       }
   } 
    
}

