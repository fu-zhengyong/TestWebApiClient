using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values?username=
        [HttpGet]
        public IList<string> Get(string username)
        {
            return new List<string>() { username + "value1", username + "value2" };
        }
    }
}
