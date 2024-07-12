using Microsoft.AspNetCore.Mvc;
using ToRental.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeicoloController : ControllerBase
    {
        // GET: api/<VeicoloController>
        [HttpGet]
        public IEnumerable<Veicolo> Get() {

            return new Veicolo[] { new Veicolo() };

            //return json data of all vehicles present in the DB

        }

        // GET api/<VeicoloController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<VeicoloController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<VeicoloController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<VeicoloController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
