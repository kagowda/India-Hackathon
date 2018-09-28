using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            FraudCheck.Check();
            var currentTime = DateTime.Now;
            return new string[] { currentTime.ToLongDateString(), currentTime.ToLongTimeString() };
        }
    }
}
