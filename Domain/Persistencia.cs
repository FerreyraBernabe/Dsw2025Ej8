using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public static class Persistencia
    {

            public static Cliente[]? Clientes { get; private set; }
            public static CuentaBancaria[]? Cuentas { get; private set; }


            public static void CargarDatos() 
            {
                Clientes = new Cliente[5]; 
                Cuentas = new CuentaBancaria[4];

                //inicializo a los Clientes
                Clientes[0] = new Cliente("Bernabé", "Ferreyra", 43289860);
                Clientes[1] = new Cliente("Nocturn", "Infernum", 66666666);
                Clientes[2] = new Cliente("Astrid", "Colapinto", 45000000);
                Clientes[3] = new Cliente("Ana", "Banana", 44599999);
                Clientes[4] = new Cliente("Andre", "Robotica", 44030309);


                //inicializo las Cuentas
                Random numeroCuenta= new Random();
                Cuentas[0] = new CajaAhorro(numeroCuenta.Next().ToString(), 1000) { TasaDeInteres = 0.35M, LimiteDeDescubierto = 500M};
                Cuentas[0].AddTitular(Clientes[0]);
                Cuentas[0].AddTitular(Clientes[1]);

                Cuentas[1] = new CajaAhorro(numeroCuenta.Next().ToString(), 1500) { TasaDeInteres = 0.35M, LimiteDeDescubierto = 500M };
                Cuentas[1].AddTitular(Clientes[2]);

                Cuentas[2] = new CuentaCorriente(numeroCuenta.Next().ToString(), 2000) { TasaDeInteres = 0.25M, LimiteDeDescubierto = 2000M };
                Cuentas[2].AddTitular(Clientes[1]);
                Cuentas[2].AddTitular(Clientes[3]);

                Cuentas[3] = new CuentaCorriente(numeroCuenta.Next().ToString(), 2500) { TasaDeInteres = 0.250M, LimiteDeDescubierto = 2000M };
                Cuentas[3].AddTitular(Clientes[4]);


            }

            public static void MostrarCuentas()
            {
                foreach (CuentaBancaria c in Cuentas)
                {
                    c.MostrarResumenCuenta();
                }
            }

            public static void RealizarRetiros() 
            {
                foreach(CuentaBancaria c in Cuentas) 
                {
                        c.Retirar(0);
                        c.Retirar(1600);
                        c.Retirar(500);
                }
             }
            public static void RealizarDepositos()
            {
                foreach (CuentaBancaria c in Cuentas)
                {
                    c.Depositar(0);
                    c.Depositar(1600);
                    c.Depositar(-200);
                }
            }


    }
    }
 


