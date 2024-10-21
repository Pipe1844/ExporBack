using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Produccion_DB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        // GET: api/<ArticulosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ArticulosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticulosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticulosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
