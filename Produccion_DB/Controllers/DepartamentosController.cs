using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;


namespace Produccion_DB.Controllers
{
    [Route("api/v2/Departamentos")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
       private readonly AppDbContext appDbContext;
       
       public DepartamentosController(AppDbContext appDbContext)
       {
           this.appDbContext = appDbContext;
       }
       
       [HttpGet]
               public async Task<IActionResult> Index()
               {
                   try  
                   {  
                       var departamentos = await this.appDbContext.DepartamentoTbs  
                           .Select(d => new  
                           {  
                               d.Departamento,  
                               d.Encargado,  
                               d.Descripcion  
                           })  
                           .ToListAsync();  

                       if (departamentos.Count == 0)  
                       {  
                           return Ok(new   
                           {   
                               isSuccess = true,   
                               status = 204,   
                               Departamentos = new List<object>()   
                           });  
                       }  

                       return Ok(new   
                       {   
                           isSuccess = true,   
                           status = 200,   
                           Departamentos = departamentos   
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
                               var departamento = await this.appDbContext.DepartamentoTbs.
                                   Select(d => new  
                                   {  
                                       d.Departamento,  
                                       d.Encargado,  
                                       d.Descripcion  
                                   })
                                   .FirstOrDefaultAsync(dep=>dep.Departamento==id);
                       
                               if (departamento == null)
                               {
                                   return NotFound(new 
                                   { 
                                       isSuccess = false, 
                                       status = 404, 
                                       message = "Departamento no encontrado." 
                                   });
                               }
               
                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 200, 
                                   Departamentos = departamento 
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
                       public async Task<IActionResult> Store([FromBody] DepartamentoTb departamento)
                       {

                           try
                           {
                               await this.appDbContext.DepartamentoTbs.AddAsync(departamento);
                               await this.appDbContext.SaveChangesAsync();

                               return Ok(new 
                               { 
                                   isSuccess = true, 
                                   status = 201, 
                                   message = "Departamento creado con éxito.", 
                                   Departamento = departamento 
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
                       public async Task<IActionResult> Update(string id, [FromBody] DepartamentoTb departamentoEntrante)
                       {
                           try
                           {
                               var departamentoModificar = await this.appDbContext.DepartamentoTbs.FindAsync(id);

                               if (departamentoModificar == null)
                               {
                                   return NotFound(new
                                       { isSuccess = false, status = 404, message = "Departamento no encontrado." });
                               }

                               departamentoModificar.Departamento = departamentoEntrante.Departamento;
                               departamentoModificar.Encargado = departamentoEntrante.Encargado;
                               departamentoModificar.Descripcion = departamentoEntrante.Descripcion;

                               await this.appDbContext.SaveChangesAsync();
                               return Ok(new
                               {
                                   isSuccess = true, status = 200, message = "Departamento actualizado exitosamente.",
                                   producto = departamentoModificar
                               });
                           } catch (DbUpdateException dbEx)
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
                               var departamento = await this.appDbContext.DepartamentoTbs.FindAsync(id);

                               if (departamento == null)
                               {
                                   return NotFound(new
                                       { isSuccess = false, status = 404, message = "Departamento no encontrado." });
                               }

                               this.appDbContext.DepartamentoTbs.Remove(departamento);
                               await this.appDbContext.SaveChangesAsync();

                               return Ok(new
                               {
                                   isSuccess = true, status = 200, message = "Departamento eliminado exitosamente."
                               });
                           }  catch (DbUpdateException dbEx)
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
