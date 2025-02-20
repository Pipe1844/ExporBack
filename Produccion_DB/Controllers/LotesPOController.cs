using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;
using Microsoft.Data.SqlClient;


namespace Produccion_DB.Controllers
{
    [Route("api/v2/LotesPO")]
    [ApiController]
   public class LotesPOController : Controller
   {
       private readonly AppDbContext appDbContext;
       
       public LotesPOController(AppDbContext appDbContext)
       {
           this.appDbContext = appDbContext;
       }
       
       [HttpGet]
               public async Task<IActionResult> Index()
               {
                   try
                   {
                       var lotePo = await this.appDbContext.LotesPoTbs.
                           Select(l=>new
                           {
                               l.Temporada,
                               l.SiembraNum,
                               l.NombreLote,
                               l.AliasLote,
                               l.FechaTrasplante,
                               l.Area,
                               l.Orientacion,
                               l.Fumig,
                               l.TipoPlastico,
                               l.Densidad,
                               l.ColmenasPorHa,
                               l.ProgFertilizacion,
                               l.ProgFitoProteccion
                           }).ToListAsync();
       
                       // Verificamos si la lista está vacía
                       if (lotePo.Count==0)
                       {
                           return Ok(new 
                           { 
                               isSuccess = true, 
                               status = 204, 
                               LotesPO = new List<object>() 
                           });
                       }
                       return Ok(new 
                       { 
                           isSuccess = true, 
                           status = 200, 
                           LotesPO = lotePo 
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
               
               [HttpGet("{temporada}/{siembraNum}/{nombreLote}/{aliasLote}")]
                       public async Task<IActionResult> Show(string temporada, int siembraNum,string nombreLote,string aliasLote)
                       {
                           try
                           {
                               
                               var lotePo = await this.appDbContext.LotesPoTbs
                                   .Select(l => new
                                   {
                                       l.Temporada,
                                       l.SiembraNum,
                                       l.NombreLote,
                                       l.AliasLote,
                                       l.FechaTrasplante,
                                       l.Area,
                                       l.Orientacion,
                                       l.Fumig,
                                       l.TipoPlastico,
                                       l.Densidad,
                                       l.ColmenasPorHa,
                                       l.ProgFertilizacion,
                                       l.ProgFitoProteccion
                                   })
                                   .FirstOrDefaultAsync(lPo => lPo.Temporada == temporada &&
                                                               lPo.SiembraNum == siembraNum &&
                                                               lPo.NombreLote == nombreLote &&
                                                               lPo.AliasLote == aliasLote);


                       
                               if (lotePo == null)
                               {
                                   return NotFound(new 
                                   { 
                                       isSuccess = false, 
                                       status = 404, 
                                       message = "LotePO no encontrado." 
                                   });
                               }
               
                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 200, 
                                   LotePO = lotePo 
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
                       
                       
                       [HttpGet("{temporada}")]
                       public async Task<IActionResult> GetByTemporada(string temporada)
                       {
                           try
                           {
                               var lotesPo = await this.appDbContext.LotesPoTbs.
                                   Where(lPo => lPo.Temporada == temporada).
                                   Select(l=>new
                                   {
                                       l.Temporada,
                                       l.SiembraNum,
                                       l.NombreLote,
                                       l.AliasLote,
                                       l.FechaTrasplante,
                                       l.Area,
                                       l.Orientacion,
                                       l.Fumig,
                                       l.TipoPlastico,
                                       l.Densidad,
                                       l.ColmenasPorHa,
                                       l.ProgFertilizacion,
                                       l.ProgFitoProteccion
                                   })
                                  .ToListAsync();

                               if (lotesPo.Count == 0) 
                               {
                                   return Ok(new 
                                   { 
                                       isSuccess = true, 
                                       status = 204, 
                                       LotesPO = new List<object>() 
                                   });
                               }

                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 200, 
                                   LotesPO = lotesPo 
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
                       public async Task<IActionResult> Store([FromBody] LotesPoTb lotePo)
                       {
                           try
                           {
                               await this.appDbContext.LotesPoTbs.AddAsync(lotePo);
                               await this.appDbContext.SaveChangesAsync();

                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 201, 
                                   message = "LotePO creado con éxito.", 
                                   LotePO = lotePo 
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
                       [HttpPut("{temporada}/{siembraNum}/{nombreLote}/{aliasLote}")]
                       public async Task<IActionResult> Update(string temporada, int siembraNum,
                           string nombreLote,string aliasLote, [FromBody] LotesPoTb lotePO)
                       {
                           try
                           {
                               var lote = await this.appDbContext.LotesPoTbs
                                   .FirstOrDefaultAsync(lPo =>
                                       lPo.Temporada == temporada && lPo.SiembraNum == siembraNum &&
                                       lPo.NombreLote == nombreLote && lPo.AliasLote == aliasLote);

                               if (lote == null)
                               {
                                   return NotFound(new
                                       { isSuccess = false, status = 404, message = "LotePO no encontrado." });
                               }

                               lote.Temporada = lotePO.Temporada;
                               lote.SiembraNum = lotePO.SiembraNum;
                               lote.NombreLote = lotePO.NombreLote;
                               lote.AliasLote = lotePO.AliasLote;
                               lote.FechaTrasplante = lotePO.FechaTrasplante;
                               lote.Area = lotePO.Area;
                               lote.Orientacion = lotePO.Orientacion;
                               lote.Fumig = lotePO.Fumig;
                               lote.TipoPlastico = lotePO.TipoPlastico;
                               lote.Densidad = lotePO.Densidad;
                               lote.ColmenasPorHa = lotePO.ColmenasPorHa;
                               lote.ProgFertilizacion = lotePO.ProgFertilizacion;
                               lote.ProgFitoProteccion = lotePO.ProgFitoProteccion;

                               await this.appDbContext.SaveChangesAsync();
                               return Ok(new
                               {
                                   isSuccess = true, status = 200, message = "LotePO actualizado exitosamente.",
                                   lotePO = lote
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
                       
                       [HttpDelete("{temporada}/{siembraNum}/{nombreLote}/{aliasLote}")]
                       public async Task<IActionResult> Destroy(string temporada, int siembraNum,string nombreLote,string aliasLote)
                       {
                           try
                           {
                               var lotePo = await this.appDbContext.LotesPoTbs
                                   .FirstOrDefaultAsync(lPo =>
                                       lPo.Temporada == temporada && lPo.SiembraNum == siembraNum &&
                                       lPo.NombreLote == nombreLote && lPo.AliasLote == aliasLote);

                               if (lotePo == null)
                               {
                                   return NotFound(new
                                       { isSuccess = false, status = 404, message = "LotePO no encontrado." });
                               }

                               this.appDbContext.LotesPoTbs.Remove(lotePo);
                               await this.appDbContext.SaveChangesAsync();

                               return Ok(new
                                   { isSuccess = true, status = 200, message = "LotePO eliminado exitosamente." });
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
                       
                       
                       [HttpPost("CopiarLotesPo")]
                       public async Task<IActionResult> StoreBulk([FromBody] List<LotesPoTb> lotesPoList)
                       {
                           if (lotesPoList.Count==0)
                           {
                               return BadRequest(new 
                               { 
                                   isSuccess = false, 
                                   status = 400, 
                                   message = "Datos inválidos o lista vacía." 
                               });
                           }

                           using (var transaction = await this.appDbContext.Database.BeginTransactionAsync())
                           {
                               try
                               {
                                   // Agregar múltiples registros a la base de datos de una sola vez
                                   await this.appDbContext.LotesPoTbs.AddRangeAsync(lotesPoList);
                                   await this.appDbContext.SaveChangesAsync();
                                   await transaction.CommitAsync();

                                   return Ok(new 
                                   { 
                                       isSuccess = true, 
                                       status = 201, 
                                       message = "LotesPO creados con éxito.", 
                                       LotesPo = lotesPoList 
                                   });
                               }
                              
                               catch (Exception ex)
                               {
                                   await transaction.RollbackAsync();
                                   return StatusCode(500, new 
                                   { 
                                       isSuccess = false, 
                                       status = 500, 
                                       message = "Ocurrió un error inesperado.", 
                                       error = ex.Message,
                                       innerError = ex.InnerException?.Message
                                   });
                               }
                           }
                       }


   } 
    
}

