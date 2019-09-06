using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TestWebApiClient.Utils;
using WebApiClient;

namespace TestWebApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        [HttpGet]
        public async Task<IList<string>> Get(string username)
        {
            var api = HttpApi.Resolve<IClientWebApi>();
            var user = await api.GetValuesByUserNameAsync(username);


            return user;
        }


    }
}
