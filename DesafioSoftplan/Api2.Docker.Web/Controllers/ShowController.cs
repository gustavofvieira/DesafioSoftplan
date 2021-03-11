using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Docker.Web.Controllers
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
