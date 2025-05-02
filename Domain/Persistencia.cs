using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class Persistencia
    {
        private Cliente[] _clientes;
        private CuentaBancaria[] cuentas;
        public Persistencia()
        {
            _clientes = new Cliente[4];
            cuentas = new CuentaBancaria[4];
        }

        public void Ejecutar() 
        {

            //inicializo a los _clientes
            _clientes[0] = new Cliente("Bernabé", "Ferreyra", 43289860);
            _clientes[1] = new Cliente("Nocturn", "Infernum", 66666666);
            _clientes[2] = new Cliente("Astrid", "Colpinto", 45000000);
            _clientes[3] = new Cliente("Ana", "Banana", 44599999);

            //inicializo las cuentas
            Random numeroCuenta= new Random();
            cuentas[0] = new CajaAhorro(numeroCuenta.Next().ToString(), 1000) { TasaDeInteres = 3.5M, LimiteDeDescubierto = 500, Titulares[0] = _clientes[0] };
        } 
    }
}

