
using DesafioSoftplan.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Api2.Docker.Web.Controllers
{
    [Route("calculaJuros")]
    [ApiController]
    public class CalculaController : ControllerBase
    {
        // GET: api/<CalculaController>
        [HttpGet]
        public string Get()
        {
            return "API Calcula Juros - ATIVA";
        }

        
        [HttpPost]

        public ActionResult<CalculaJurosVM> Post(CalculaJurosVM calculaJurosVM)
        {

            try
            {
                var jurosTotal = calculaJurosVM.CalculaJuros(calculaJurosVM);

                return Ok("Juros Total: " + jurosTotal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
