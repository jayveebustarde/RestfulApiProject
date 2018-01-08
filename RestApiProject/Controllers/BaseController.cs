using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApiProject.Controllers
{
    public class BaseController<T> : ApiController
        where T: BaseDTO
    {

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        public string Get(Guid id)
        {
            return "value";
        }


        public void Post([FromBody]string value)
        {
        }


        public void Put(Guid id, [FromBody]string value)
        {
        }


        public void Delete(Guid id)
        {
        }
    }
}
