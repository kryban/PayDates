using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PayDates.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaydatesController : ControllerBase
    {
        // GET: api/Paydates
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "PaydatesValue1", "PaydatesValue2" };
        }

        // GET: api/Paydates/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "PaydatesValue id: " + id;
        }

        // POST: api/Paydates
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Paydates/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
