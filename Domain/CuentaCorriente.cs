using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {

        public CuentaCorriente(string numero, decimal saldo, Cliente[] titulares)
            : base (numero,saldo,titulares)
        {
            this.Tipo = TipoCuenta.CuentaCorriente;
        }

        public override void Depositar(decimal monto)
        {
                base.Depositar(monto);
                monto -= monto * Comision;
                Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            base.Retirar(monto);
            if (Saldo - monto >= -LimiteDeDescubierto)
            {
                Saldo -= monto;
            }
            if (Saldo < 0)
            {
                MiEstado = Estado.Suspendida;
            }
        }

        public override string ToString()
        {
            return "Caja de Ahorro";
        }
    }
}

