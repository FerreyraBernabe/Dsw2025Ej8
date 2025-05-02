using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class Cliente : Persona
    {
        private int nroCliente;
        public Cliente(string nombre, string apellido, int dni, string domicilio = "")
            : base (nombre, apellido, dni, domicilio)
        {
            
        }

    }
}
