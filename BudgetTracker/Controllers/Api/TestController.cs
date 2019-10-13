using System.Collections.Generic;
using System.Web.Http;

namespace BudgetTracker.Controllers.Api
{
    public class TestController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
