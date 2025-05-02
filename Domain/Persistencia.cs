using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class Persistencia
    {
        private Cliente[] clientes;
        private CuentaBancaria[] cuentas;
        public Persistencia()
        {
            clientes = new Cliente[4];
            cuentas = new CuentaBancaria[4];
        }

        public void CargarDatos() 
        {

            //inicializo a los clientes
            clientes[0] = new Cliente("Bernabé", "Ferreyra", 43289860);
            clientes[1] = new Cliente("Nocturn", "Infernum", 66666666);
            clientes[2] = new Cliente("Astrid", "Colpinto", 45000000);
            clientes[3] = new Cliente("Ana", "Banana", 44599999);
            clientes[4] = new Cliente("Andre", "Robotica", 44030309);

            //inicializo las cuentas
            Random numeroCuenta= new Random();
            cuentas[0] = new CajaAhorro(numeroCuenta.Next().ToString(), 1000) { TasaDeInteres = 3.5M, LimiteDeDescubierto = 500};
            cuentas[0].AddTitular(clientes[0]);
            cuentas[0].AddTitular(clientes[1]);

            cuentas[1] = new CajaAhorro(numeroCuenta.Next().ToString(), 1500) { TasaDeInteres = 3.5M, LimiteDeDescubierto = 500 };
            cuentas[1].AddTitular(clientes[1]);

            cuentas[2] = new CajaAhorro(numeroCuenta.Next().ToString(), 2000) { TasaDeInteres = 5.00M, LimiteDeDescubierto = 600 };
            cuentas[2].AddTitular(clientes[2]);
            cuentas[2].AddTitular(clientes[3]);

            cuentas[3] = new CajaAhorro(numeroCuenta.Next().ToString(), 2500) { TasaDeInteres = 5.00M, LimiteDeDescubierto = 600 };
            cuentas[3].AddTitular(clientes[4]);


        } 
    }
}

