namespace Dsw2025Ej8.Domain;

public class CuentaBancaria
{
  
    public TipoCuenta Tipo { get; }
    public string Numero { get; }
    public decimal Saldo { get; private set; }
    public Estado MiEstado { get; set; }
    public decimal TasaDeInteres { get; set; }
    public decimal LimiteDeDescubierto { get; set; }
    public decimal Comision { get; set; }
    public string[] Titulares { get; init;  }


    public CuentaBancaria(string numero, decimal saldo, TipoCuenta tipo, string[] titulares)
    {
        Numero = numero;
        Saldo = saldo;
        Tipo = tipo;
        Titulares = titulares;
    }


    #region Getters/Setters
    public string GetNumero()
    {
        return Numero;
    }

    public decimal GetSaldo()
    {
        return Saldo;
    }
    public TipoCuenta GetTipo()
    {
        return Tipo;
    }

    public Estado GetEstado()
    {
        return MiEstado;
    }

    public void SetEstado(Estado estado)
    {
        MiEstado = estado;
    }

    public decimal GetTasaDeInteres()
    {
        return TasaDeInteres;
    }

    public void SetTasaDeInteres(decimal tasaDeInteres)
    {
        TasaDeInteres = tasaDeInteres;
    }

    public decimal GetLimiteDeDescubierto()
    {
        return LimiteDeDescubierto;
    }

    public void SetLimiteDeDescubierto(decimal limiteDeDescubierto)
    {
        LimiteDeDescubierto = limiteDeDescubierto;
    }

    public decimal GetComision()
    {
        return Comision;
    }

    public void SetComision(decimal comision)
    {
        Comision = comision;
    }

    public Cliente[] GetTitulares()
    {
        return Titulares;
    }
    #endregion

    public void Depositar(decimal monto)
    {
        if (Tipo == TipoCuenta.CajaDeAhorro)
        {
            Saldo += monto;
        }
        else if (Tipo == TipoCuenta.CuentaCorriente)
        {
            monto -= monto * Comision;
            Saldo += monto;
        }
    }

    public void Retirar(decimal monto)
    {
        if (Tipo == TipoCuenta.CajaDeAhorro)
        {
            Saldo -= monto;
        }
        else if (Tipo == TipoCuenta.CuentaCorriente)
        {
            if (Saldo - monto >= -LimiteDeDescubierto)
            {
                Saldo -= monto;
            }
            if (Saldo < 0)
            {
                MiEstado = Estado.Suspendida;
            }
        }
    }

    public void AplicarInteres()
    {
        if (Tipo == TipoCuenta.CajaDeAhorro)
        {
            Saldo += Saldo * TasaDeInteres;
        }
    }
}
