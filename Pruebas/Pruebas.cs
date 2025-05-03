using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Domain;
using Dsw2025Ej8.Exceptions;

namespace Dsw2025Ej8.Pruebas
{
    public static class Pruebas
    {
        public static void IniciarPruebas()
        { 
                Persistencia.CargarDatos();
                Persistencia.RealizarRetiros();
                Persistencia.RealizarDepositos();
                Persistencia.MostrarCuentas();
        }
    }
}
