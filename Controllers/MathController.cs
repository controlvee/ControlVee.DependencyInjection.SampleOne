using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIandJquery.Controllers
{
    [Route("api/[controller]/add")]
    public class MathController : Controller
    {
        public MathController(IHostingEnvironment ihost)
        {
            var t = ihost.WebRootPath;
        }

        // GET api/math/add/3/4 -> 7
        [HttpGet("{x}/{y}")]
        public int Get(int x, int y)
        {
            return x + y; // add
        }
    }
}
