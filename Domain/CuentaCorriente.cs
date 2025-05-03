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

        public CuentaCorriente(string numero, decimal saldo)
            : base (numero,saldo)
        {
            this.Tipo = TipoCuenta.CuentaCorriente;
        }

        public override void Depositar(decimal monto)
        {
            try
            {
                base.Depositar(monto);
                monto -= monto * Comision;
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
        public override void MostrarResumenCuenta()
        {
            var resumen = new { _nroCuenta = this.Numero, _tipo = this.Tipo, _saldo = Saldo };
            Console.WriteLine($"Número de cuenta: {resumen._nroCuenta}, Tipo de cuenta: {resumen._tipo.ToString()}, Saldo: ${resumen._saldo}");
        }
    }
}

