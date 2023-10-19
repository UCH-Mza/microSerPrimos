using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Persona
    {
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public int Edad { get; set;}


        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public Persona()
        {
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} {Edad}";
        }
    }
}
