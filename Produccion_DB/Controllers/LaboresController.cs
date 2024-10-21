using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Produccion_DB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboresController : ControllerBase
    {
        // GET: api/<LaboresController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LaboresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LaboresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LaboresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LaboresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
