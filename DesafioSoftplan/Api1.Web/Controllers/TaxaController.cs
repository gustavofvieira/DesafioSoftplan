using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api1.Web.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class TaxaController : ControllerBase
    {

        // GET: api/<TaxaController>
        [HttpGet]
        public double Get()
        {
            return 0.01;
        }

        //// GET: api/<TaxaController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<TaxaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TaxaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaxaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaxaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
