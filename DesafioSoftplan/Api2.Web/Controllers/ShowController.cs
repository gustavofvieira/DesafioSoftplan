using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api2.Web.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        // GET: api/<ShowController>
        [HttpGet]
        public string Get()
        {
            return "https://github.com/gustavofvieira/DesafioSoftplan";
        }

    }
}
