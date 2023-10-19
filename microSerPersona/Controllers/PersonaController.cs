using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microSerPersona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<List<Persona>> Get()
        {
            List<Persona> personas = new List<Persona>();
            for (int i = 0; i < 10; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Apellido = $"Apellido {i}",
                    Edad = i + 10
                });
            }
            return personas;
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post(Persona value)
        {
            Console.WriteLine("Post");
            Console.WriteLine(value);
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, Persona value)
        {
            Console.WriteLine("Put ID : " + id);
            Console.WriteLine(value);
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine("Del ID : " + id);
        }
    }
}
