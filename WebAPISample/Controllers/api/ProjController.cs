using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPISample.Controllers.api
{
    public class ProjController : ApiController
    {
        // GET: api/Test
        public IEnumerable<string> Get()
        {

            return new string[] { " " };
        }

        // GET: /api/Proj/?Collection=
        public IEnumerable<string> Get(string Collection)
        {
            string[] ProjList;
            switch (Collection)
            {
                case "test" :
                    ProjList = new string[] { "Proj", "value2" };
                    break;
                case "test2":
                    ProjList = new string[] { "Proj2", "value666" };
                    break;
                default:
                    ProjList = new string[] { "" };
                    break;
            }

            return ProjList;
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
