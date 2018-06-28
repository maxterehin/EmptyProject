using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace EmptyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
         // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var position = new { Latitude = 25, Longitude = 134 };
            var values = new string[] { "value1", "value2" };

            var input = new { Latitude = 25, Longitude = 134 };
            var time = 34;

            Log.Information("Processed {@SensorInput} in {TimeMS:000} ms.", input, time);

            return values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
