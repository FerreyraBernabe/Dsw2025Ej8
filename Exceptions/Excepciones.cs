using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8.Exceptions
{
    public class MontoNoValido : Exception
    {
        public MontoNoValido() : base("El monto ingresado no es válido para la operación solicitada")
        { }
        
    }
    public class CuentaNoActiva : Exception
    {
        public CuentaNoActiva(string estado) : base($"No se puede operar con la cuenta {estado}")
        { }
    }

    public class SaldoInsuficiente : Exception
    {
        public SaldoInsuficiente() : base(" La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.")
        { }
    }
}

