using DesafioSoftplan.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api2.Web.Controllers
{
    [Route("calculaJuros")]
    [ApiController]
    public class CalculaController : ControllerBase
    {
        // GET: api/<CalculaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CalculaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
        [HttpPost]
        
        public ActionResult<CalculaJurosVM> Post(CalculaJurosVM calculaJurosVM)
        {
           
            try
            {
                var jurosTotal = calculaJurosVM.CalculaJuros(calculaJurosVM);
               
                return Ok("Juros Total: "+jurosTotal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // PUT api/<CalculaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalculaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
