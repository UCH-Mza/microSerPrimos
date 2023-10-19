using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microSerPrimos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroPar : ControllerBase
    {
        // GET: api/<NumeroPar>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<NumeroPar>/5
        [HttpGet("{v}")]
        public async Task<bool> Get(int v)
        {
            if(v%2 > 0) return false;

            return true;
        }

        [HttpGet]
        public async Task<bool> GetH([FromHeader] int v)
        {
            if (v % 2 > 0) return false;

            return true;
        }

        // POST api/<NumeroPar>
        [HttpPost]
        public async Task<bool> Post(int v)
        {
            return true;
        }

        //// PUT api/<NumeroPar>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<NumeroPar>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
