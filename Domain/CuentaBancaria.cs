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
        MiEstado = Estado.Activa;
    }

    public virtual void Depositar(decimal monto) 
    {
            if (!MiEstado.Equals(Estado.Activa))
            {
                throw new CuentaNoActiva(MiEstado.ToString());
            }

            if (monto <= 0)
            {
                throw new MontoNoValido();
            }
    } 


    public virtual void Retirar(decimal monto) 
    {
            if (!MiEstado.Equals(Estado.Activa))
            {
                throw new CuentaNoActiva(MiEstado.ToString());
            }

            if (monto <= 0)
            {
                throw new MontoNoValido();
            }

            //Este IF plantea la pregunta: ¿El usuario está tratando de retirar más dinero del que tiene INCLUSO si usa su límite de descubierto?
            if (monto > Saldo + LimiteDeDescubierto)
            {
                MiEstado = Estado.Suspendida;
                throw new SaldoInsuficiente();
            }
           //De ser cierto, ENTONCES se procede a la suspensión de la cuenta. En resumen, sólo se suspende una cuenta cuando el usuario trata de retirar más de lo que tiene, aún usando el límite.
    }

    public void AddTitular(Cliente cliente) 
    {
        int indice = 0;
        for (int i = 0; i < Titulares.Length; i++) 
        {
            if(Titulares[i] != null) 
            {
                indice++;
            }
        }
        Titulares[indice] = cliente;
    }

    public abstract void MostrarResumenCuenta();
}
