using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public abstract class Persona
    {
        public Persona(string nombre, string apellido, int dni, string domicilio = "")
        {
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Dni = dni;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
    }
}
