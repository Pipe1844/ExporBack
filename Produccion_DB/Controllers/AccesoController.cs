using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

namespace Produccion_DB.Controllers
{
    [Route("api/v2/login")]
    [ApiController]
    public class AccesoController : ControllerBase
    {
        // ReSharper disable once InconsistentNaming
        private readonly AppDbContext appDbContext;
        
        public AccesoController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(UsuarioTb usuario)
        {
            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contrasena))
            {
                return BadRequest(new { isSuccess = false, status = 400, message = "Usuario o contraseña no pueden estar vacíos." });
            }
            
            var usuarioEncontrado = await this.appDbContext.UsuarioTbs
                .Where(u => 
                    u.Usuario == usuario.Usuario &&
                    u.Contrasena == usuario.Contrasena
                ).FirstOrDefaultAsync();
            
            if (usuarioEncontrado == null)
                return Unauthorized(new { isSuccess = false, status = 401 });
            return Ok(new { isSuccess = true, status = 200 ,user = usuarioEncontrado});
        }
    }
}