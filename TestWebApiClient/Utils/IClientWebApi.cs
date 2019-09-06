using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;

namespace TestWebApiClient.Utils
{

     [HttpHost("http://localhost:51768/")]
     public interface IClientWebApi : IHttpApi
     {
        // GET api/values?username=
        [HttpGet("api/values?username={username}")]
         ITask<IList<string>> GetValuesByUserNameAsync(string username);
     }
}
