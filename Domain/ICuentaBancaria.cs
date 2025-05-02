using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public interface ICuentaBancaria
    {
        public void Depositar(decimal monto);

        public void Retirar(decimal monto);
    }
}
