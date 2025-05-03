using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public class CajaAhorro : CuentaBancaria
    {

        public CajaAhorro(string numero, decimal saldo)
            : base(numero, saldo)
        {
            this.Tipo = TipoCuenta.CajaDeAhorro;
        }

        public override void Depositar(decimal monto)
        {
            try
            {
                base.Depositar(monto);
                Saldo += monto;
            }
            
            catch (MontoNoValido montoEx) { Console.WriteLine(montoEx.Message); }
            catch (CuentaNoActiva cuentaEx) { Console.WriteLine(cuentaEx.Message); }
            catch (SaldoInsuficiente saldoEx) { Console.WriteLine(saldoEx.Message); }
        }

        public override void Retirar(decimal monto)
        {
            try
            {
                base.Retirar(monto);
                Saldo -= monto;
            }
            catch (MontoNoValido montoEx) { Console.WriteLine(montoEx.Message); }
            catch (CuentaNoActiva cuentaEx) { Console.WriteLine(cuentaEx.Message); }
            catch (SaldoInsuficiente saldoEx) { Console.WriteLine(saldoEx.Message); }


        }
        public void AplicarInteres()
        {
            Saldo += Saldo * TasaDeInteres;
        }

        public override void MostrarResumenCuenta()
        {
            this.AplicarInteres();
            var resumen = new { _nroCuenta = this.Numero, _tipo = this.Tipo, _saldo = Saldo };
            Console.WriteLine($"Número de cuenta: {resumen._nroCuenta}, Tipo de cuenta: {resumen._tipo.ToString()}, Saldo: ${resumen._saldo}");
        }
    }
}
