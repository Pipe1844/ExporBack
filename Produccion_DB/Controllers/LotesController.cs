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
                       var lotes = await this.appDbContext.LotesFisicosTbs.
                           Select(l=>new
                           {
                               l.NombreLote,
                               l.Activo,
                               l.Area,
                               l.Descripcion
                           })
                           .ToListAsync();
       
                       // Verificamos si la lista está vacía
                       if (lotes.Count==0)
                       {
                           return Ok(new 
                           { 
                               isSuccess = true, 
                               status = 204, 
                               Lotes = new List<object>() 
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
               
               
       [HttpGet("activos")]
       public async Task<IActionResult> lotesActivos()
       {
           try
           {
               // Intentamos obtener la lista de temporadas
               var lotesActivos = await this.appDbContext.LotesFisicosTbs.
                   Where(l=>l.Activo==true)
                   .Select(lo => new { lo.NombreLote, lo.Area }).
                   ToListAsync();
       
               // Verificamos si la lista está vacía
               if (lotesActivos.Count==0)
               {
                   return Ok(new 
                   { 
                       isSuccess = true, 
                       status = 204, 
                       LotesActivos = new List<object>() 
                   });
               }
               return Ok(new 
               { 
                   isSuccess = true, 
                   status = 200, 
                   LotesActivos = lotesActivos 
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
               
           [HttpGet("{id}")]
                   public async Task<IActionResult> Show(string id)
                   {
                       try
                       {
                           var lote = await this.appDbContext.LotesFisicosTbs.
                               Select(l=>new
                               {
                                   l.NombreLote,
                                   l.Activo,
                                   l.Area,
                                   l.Descripcion
                               }).FirstOrDefaultAsync(lo=>lo.NombreLote==id);
                   
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
                   public async Task<IActionResult> Store([FromBody] LotesFisicosTb lote)
                   {

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
                   public async Task<IActionResult> Update(string id, [FromBody] LotesFisicosTb lote)
                   {
                       try
                       {
                           var loteFinded = await this.appDbContext.LotesFisicosTbs.FindAsync(id);

                           if (loteFinded == null)
                           {
                               return NotFound(new
                                   { isSuccess = false, status = 404, message = "Lote no encontrado." });
                           }

                           loteFinded.NombreLote = lote.NombreLote;
                           loteFinded.Activo = lote.Activo;
                           loteFinded.Descripcion = lote.Descripcion;
                           loteFinded.Area = lote.Area;

                           await this.appDbContext.SaveChangesAsync();
                           return Ok(new
                           {
                               isSuccess = true, status = 200, message = "Lote actualizado exitosamente.",
                               producto = loteFinded
                           });
                       }catch (DbUpdateException dbEx)
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
                           var lote = await this.appDbContext.LotesFisicosTbs.FindAsync(id);

                           if (lote == null)
                           {
                               return NotFound(new
                                   { isSuccess = false, status = 404, message = "Lote no encontrado." });
                           }

                           this.appDbContext.LotesFisicosTbs.Remove(lote);
                           await this.appDbContext.SaveChangesAsync();

                           return Ok(new { isSuccess = true, status = 200, message = "Lote eliminado exitosamente." });
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

