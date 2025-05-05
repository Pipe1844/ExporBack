using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers;

    [Route("api/v2/PoProductosLabor")]
    [ApiController]
    public class PoProductosLaborController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public PoProductosLaborController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var poProductosLabor = await this.appDbContext.PoProductosALaborTbs.Select(l => new
                {
                    l.Temporada,
                    l.SiembraNumero,
                    l.Departamento,
                    l.Labor,
                    l.AliasLabor,
                    l.Ddt,
                    l.IdProducto,
                    l.NombreDescriptivo,
                    l.DosisHa,
                    l.HorasAgua,
                    l.HorasInyeccion,
                    l.HorasLavado
                }).ToListAsync();

                return poProductosLabor.Count==0 ? 
                    Ok(new { isSuccess = true, status = 204, poProductosLabor = new List<object>() }) :
                    Ok(new { isSuccess = true, status = 200, poProductosLabor });
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


        // [HttpGet("{temporada}/{siembraNum}/{departamento}/{labor}/{aliasLabor}/{ddt}")]
        // public async Task<IActionResult> getByTempSiembraNumDepLabAliasDdt(string temporada, int siembraNum, string departamento, 
        //     string labor,string aliasLabor, int ddt)
        // {
        //     try
        //     {
        //         var departament = "RIEGO Y DRENAJE";
        //         var poProductosLabor = await appDbContext.PoProductosALaborTbs
        //             .Where(l => l.Temporada == temporada && l.SiembraNumero==siembraNum &&
        //                         l.Departamento == departamento && l.Labor == labor && l.AliasLabor==aliasLabor 
        //                         && l.Ddt == ddt)
        //             .Select(l => new
        //             {
        //                 l.Temporada,
        //                 l.SiembraNumero,
        //                 l.Departamento,
        //                 l.Labor,
        //                 l.AliasLabor,
        //                 l.Ddt,
        //                 l.IdProducto,
        //                 l.NombreDescriptivo,
        //                 l.DosisHa,
        //                 l.HorasAgua,
        //                 l.HorasInyeccion,
        //                 l.HorasLavado
        //             })
        //             .ToListAsync();
        //
        //         return poProductosLabor.Count==0 ?
        //             Ok(new { isSuccess = true, status = 204, poProductosLabor= new List<object> () }) :
        //             Ok(new { isSuccess = true, status = 200, poProductosLabor });
        //     }
        //     catch (DbUpdateException dbEx)
        //     { 
        //         return StatusCode(500, new 
        //         { 
        //             isSuccess = false, 
        //             status = 500, 
        //             message = "Ocurrió un error al acceder a la base de datos.", 
        //             error = dbEx.Message,
        //             innerError = dbEx.InnerException?.Message
        //         });
        //     }
        //     // Manejo de errores generales
        //     catch (Exception ex)
        //     {
        //         return StatusCode(500, new 
        //         { 
        //             isSuccess = false, 
        //             status = 500, 
        //             message = "Ocurrió un error inesperado.", 
        //             error = ex.Message 
        //         });
        //     }
        // }
        
        [HttpGet("{temporada}/{siembraNum}/{departamento}/{labor}/{aliasLabor}/{ddt}")]
        public async Task<IActionResult> getByTempSiembraNumDepLabAliasDdt(string temporada, int siembraNum, string departamento, 
            string labor,string aliasLabor, int ddt)
        {
            try
            {
                var poProductosLabor = await appDbContext.PoProductosALaborTbs
                    .Where(l =>
                        l.Temporada      == temporada &&
                        l.SiembraNumero == siembraNum &&
                        l.Departamento   == departamento &&
                        l.Labor          == labor &&
                        l.AliasLabor     == aliasLabor &&
                        l.Ddt            == ddt
                    )
                    .Join(
                        appDbContext.ProductosTbs,
                        l => l.IdProducto,
                        p => p.IdProducto,
                        (l, p) => new { l, p }
                    )
                    .Select(x => new
                    {
                        x.l.Temporada,
                        x.l.SiembraNumero,
                        x.l.Departamento,
                        x.l.Labor,
                        x.l.AliasLabor,
                        x.l.Ddt,
                        x.l.IdProducto,
                        x.l.NombreDescriptivo,
                        x.l.DosisHa,
                        x.l.HorasAgua,
                        x.l.HorasInyeccion,
                        x.l.HorasLavado,
                        x.p.UnidadMedida
                    })
                    .ToListAsync();


                return poProductosLabor.Count==0 ?
                    Ok(new { isSuccess = true, status = 204, poProductosLabor= new List<object> () }) :
                    Ok(new { isSuccess = true, status = 200, poProductosLabor });
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
        public async Task<IActionResult> Store([FromBody] PoProductosALaborTb poProductosLabor)
        {
            try
            {
                /*
                // Validación de duplicados
                var existingpoProductosLabor = await this.appDbContext.PoProductosALaborTbs
                    .FirstOrDefaultAsync(p => p.Temporada == poProductosLabor.Temporada 
                                              && p.SiembraNumero == poProductosLabor.SiembraNumero
                                              && p.Departamento == poProductosLabor.Departamento
                                              && p.Labor == poProductosLabor.Labor
                                              && p.AliasLabor == poProductosLabor.AliasLabor
                                              && p.Ddt == poProductosLabor.Ddt
                                              && p.IdProducto == poProductosLabor.IdProducto);
        
                if (existingpoProductosLabor != null)  
                {  
                    return BadRequest(new { isSuccess = false, status = 400, message = "El poProductosLabor ya existe." });  
                }
                */

                await this.appDbContext.PoProductosALaborTbs.AddAsync(poProductosLabor);
                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 201, message = "poProductosLabor creado con éxito.", poProductoLabor = poProductosLabor });
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



        [HttpPut("{temporada}/{siembraNumero}/{departamento}/{labor}/{aliasLabor}/{ddt}/{idProducto}")]
        public async Task<IActionResult> Update(
            string temporada,int siembraNumero,  string departamento, string labor, 
            string aliasLabor, int ddt, string idProducto, [FromBody] PoProductosALaborTb poProductosALaborUpdate)
        {
            try
            {
                var productLabPo = await this.appDbContext.PoProductosALaborTbs.FirstOrDefaultAsync(p =>
                    p.Temporada == temporada &&
                    p.Departamento == departamento &&
                    p.Labor == labor &&
                    p.SiembraNumero == siembraNumero &&
                    p.AliasLabor == aliasLabor &&
                    p.Ddt == ddt &&
                    p.IdProducto == idProducto);

                if (productLabPo == null)
                {
                    return NotFound(new { isSuccess = false, status = 404, message = "productoLaborPo no encontrado." });
                }

                productLabPo.NombreDescriptivo = poProductosALaborUpdate.NombreDescriptivo;
                productLabPo.DosisHa = poProductosALaborUpdate.DosisHa;
                productLabPo.HorasAgua = poProductosALaborUpdate.HorasAgua;
                productLabPo.HorasInyeccion = poProductosALaborUpdate.HorasInyeccion;
                productLabPo.HorasLavado = poProductosALaborUpdate.HorasLavado;

                await this.appDbContext.SaveChangesAsync();

                return Ok(new { isSuccess = true, status = 200, message = "productoLaborPo actualizad exitosamente.", productLabPo });
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




        [HttpDelete("{temporada}/{siembraNumero}/{departamento}/{labor}/{aliasLabor}/{ddt}/{idProducto}")]
        public async Task<IActionResult> Destroy(string temporada, string departamento, int siembraNumero, 
            string labor, string aliasLabor, int ddt, string idProducto)
        {
            try
            {
                var productLabPo = await this.appDbContext.PoProductosALaborTbs
                    .FirstOrDefaultAsync(pL => pL.Temporada == temporada
                                               && pL.Departamento == departamento
                                               && pL.SiembraNumero == siembraNumero
                                               && pL.Labor == labor
                                               && pL.AliasLabor == aliasLabor
                                               && pL.Ddt == ddt
                                               && pL.IdProducto == idProducto);

                if (productLabPo == null)
                {
                    return NotFound(new
                        { isSuccess = false, status = 404, message = "productoLaborPo no encontrado." });
                }

                this.appDbContext.PoProductosALaborTbs.Remove(productLabPo);
                await this.appDbContext.SaveChangesAsync();
                return Ok(new { isSuccess = true, status = 200, message = "productoLaborPo eliminado exitosamente." });
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
