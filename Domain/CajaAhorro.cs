using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class CajaAhorro : CuentaBancaria
    {

        public CajaAhorro(string numero, decimal saldo)
            : base (numero, saldo)
        {
            this.Tipo = TipoCuenta.CajaDeAhorro;
        }

        public override void Depositar(decimal monto)
        {
            base.Depositar(monto);
            Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            base.Retirar(monto);
            Saldo -= monto;
        }
            

        public void AplicarInteres()
        {
            Saldo += Saldo * TasaDeInteres;
        }
    }
}
