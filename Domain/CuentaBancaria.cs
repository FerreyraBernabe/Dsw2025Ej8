using Dsw2025Ej8.Exceptions;

namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria : ICuentaBancaria
{
    public TipoCuenta Tipo { get; protected set; }
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado MiEstado { get; set; }
    public decimal TasaDeInteres { get; init; }
    public decimal LimiteDeDescubierto { get; init; }
    public decimal Comision { get; set; }
    public Cliente[] Titulares { get;}


    public CuentaBancaria(string numero, decimal saldo)
    {
        Numero = numero;
        Saldo = saldo;
        Titulares = new Cliente[2];
    }

    public virtual void Depositar(decimal monto) 
    {
        if (monto <= 0)
        {
            throw new MontoNoValido();
        }
    }

    public virtual void Retirar(decimal monto) 
    {
        if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        if (monto > Saldo + LimiteDeDescubierto) 
        { 
            throw new SaldoInsuficiente(); 
        }
    }

    public void AddTitular(Cliente cliente) 
    {
        int indice = Titulares.Length;
        Titulares[indice] = cliente;
    }
}
