using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPISample.Controllers.api
{
    public class BuildsController : ApiController
    {
        // GET: api/Builds
        public IEnumerable<string> Get()
        {

            return new string[] { " " };
        }

        // GET: /api/Builds/?Project=
        public IEnumerable<string> Get(string Project)
        {
            string[] BuildList;
            switch (Project)
            {
                case "Proj":
                    BuildList = new string[] { "Build2", "Build3" };
                    break;
                case "value2":
                    BuildList = new string[] { "Build5", "Build6" };
                    break;
                case "Proj2":
                    BuildList = new string[] { "Build8", "Build9" };
                    break;
                case "value666":
                    BuildList = new string[] { "Build66666", "Build99999" };
                    break;
                default:
                    BuildList = new string[] { "" };
                    break;
            }

            return BuildList;
        }

        // POST: api/Builds
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Builds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Builds/5
        public void Delete(int id)
        {
        }
    }
}
