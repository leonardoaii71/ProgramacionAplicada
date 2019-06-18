using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ModelISC210;
namespace WebApiRPG.Controllers
{
    public class ValuesController : ApiController
    {
        ISC101Entities dbcontext = new ISC101Entities();

        // GET api/values
        public IEnumerable<string> Get()
        {
          return dbcontext.Scores.Take(5).Select(score => score.PlayerName);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
