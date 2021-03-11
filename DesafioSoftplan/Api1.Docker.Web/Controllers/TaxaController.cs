using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api1.Docker.Web.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class TaxaController : ControllerBase
    {
        [HttpGet]
        public double Get()
        {
            return 0.01;
        }
    }
}
