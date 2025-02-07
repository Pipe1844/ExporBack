using Microsoft.AspNetCore.Mvc;  
using Microsoft.EntityFrameworkCore;  
using Produccion_DB.Models;  


namespace Produccion_DB.Controllers  
{  
    [Route("api/v2/certificaciones")]  
    [ApiController]  
    public class CertificacionesController : ControllerBase  
    {  
        private readonly AppDbContext _appDbContext;  

        public CertificacionesController(AppDbContext appDbContext)  
        {  
            _appDbContext = appDbContext;  
        }  

        // GET: api/v2/certificaciones/{idProducto}  
        [HttpGet("{idProducto}")]  
        public async Task<IActionResult> GetCertificacionesByProducto(string idProducto)  
        {  
            try  
            {  
                var certificaciones = await _appDbContext.CertificacionesTbs  
                    .Where(c => c.IdProducto == idProducto)  
                    .Select(c => new  
                    {  
                        c.IdProducto,  
                        c.NombreCertificacion,  
                        c.DdtPrecosecha,  
                        c.Comentarios  
                    })  
                    .ToListAsync();  

                if (certificaciones == null || !certificaciones.Any())  
                {  
                    return Ok(new   
                    {   
                        isSuccess = true,   
                        status = 204,   
                        Certificaciones = new List<Object>()   
                    });  
                }  

                return Ok(new   
                {   
                    isSuccess = true,   
                    status = 200,   
                    Certificaciones = certificaciones   
                });  
            }  
            catch (DbUpdateException dbEx)  
            {  
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
                return StatusCode(500, new   
                {   
                    isSuccess = false,   
                    status = 500,   
                    message = "Ocurrió un error inesperado.",   
                    error = ex.Message   
                });  
            }  
        }

        // POST: api/v2/certificaciones  
        [HttpPost]  
        public async Task<IActionResult> Store([FromBody] CertificacionRequest request)  
        {  
            if (request == null || !ModelState.IsValid)  
            {  
                return BadRequest(ModelState);  
            }  
    
            var certificacion = new CertificacionesTb  
            {  
                IdProducto = request.IdProducto,  
                NombreCertificacion = request.NombreCertificacion,  
                DdtPrecosecha = request.DdtPrecosecha,  
                Comentarios = request.Comentarios  
            };  

            try  
            {  
                await _appDbContext.CertificacionesTbs.AddAsync(certificacion);  
                await _appDbContext.SaveChangesAsync();  

                return Ok(new  
                {  
                    isSuccess = true,   
                    status = 201,   
                    message = "Certificación creada exitosamente.",   
                    certificacion  
                });  
            }  
            catch (Exception ex)  
            {  
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error interno del servidor.", error = ex.Message });  
            }  
        }

        // PUT: api/v2/certificaciones/{id}  
        [HttpPut("{id}")]  
        public async Task<IActionResult> Update(string id, [FromBody] CertificacionesTb certificacionActualizada)  
        {  
            try  
            {  
                var certificacion = await _appDbContext.CertificacionesTbs.FindAsync(id);  

                if (certificacion == null)  
                {  
                    return NotFound(new { isSuccess = false, status = 404, message = "Certificación no encontrada." });  
                }  

                if (certificacionActualizada == null)  
                {  
                    return BadRequest(new { isSuccess = false, status = 400, message = "Datos de certificación inválidos." });  
                }  

                // Actualizar los atributos de la certificación  
                certificacion.NombreCertificacion = certificacionActualizada.NombreCertificacion; // Asegúrate de que los nombres sean correctos  
                certificacion.Comentarios = certificacionActualizada.Comentarios;  
                certificacion.DdtPrecosecha = certificacionActualizada.DdtPrecosecha;  

                await _appDbContext.SaveChangesAsync();  

                return Ok(new  
                {  
                    isSuccess = true, status = 200, message = "Certificación actualizada exitosamente.", certificacion  
                });  
            }  
            catch (Exception ex)  
            {  
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error interno del servidor.", error = ex.Message });  
            }  
        }  

        // DELETE: api/v2/certificaciones/{id}  
        [HttpDelete("{id}")]  
        public async Task<IActionResult> Destroy(string id)  
        {  
            try  
            {  
                var certificacion = await _appDbContext.CertificacionesTbs.FindAsync(id);  

                if (certificacion == null)  
                {  
                    return NotFound(new { isSuccess = false, status = 404, message = "Certificación no encontrada." });  
                }  

                _appDbContext.CertificacionesTbs.Remove(certificacion);  
                await _appDbContext.SaveChangesAsync();  

                return Ok(new { isSuccess = true, status = 200, message = "Certificación eliminada exitosamente." });  
            }  
            catch (Exception ex)  
            {  
                return StatusCode(500, new { isSuccess = false, status = 500, message = "Error interno del servidor.", error = ex.Message });  
            }  
        }  
    }  
    public class CertificacionRequest  
    {  
        public required string IdProducto { get; set; }  
        public required string NombreCertificacion { get; set; }  
        public required int DdtPrecosecha { get; set; } // Puedes cambiar esto a un valor por defecto si es apropiado  
        public required string Comentarios { get; set; } 

    }
}