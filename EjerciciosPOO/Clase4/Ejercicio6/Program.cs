using System;

class Program
{
  class CajeroAutomico
  {
    public int idCajero, limtieExtraccion, saldoExtraccion, saldoDeposito, saldo;
    public bool soportaDespositos, soportaTranferencias;
    public string ubicacion, bancoAsociado, estado;

    public CajeroAutomico(int idCajero, int limtieExtraccion, string ubicacion, string bancoAsociado, string estado, bool soportaDespositos, bool soportaTranferencias, int saldoExtraccion, int saldoDeposito, int saldo)
    {
      this.idCajero = idCajero;
      this.limtieExtraccion = limtieExtraccion;
      this.ubicacion = ubicacion;
      this.bancoAsociado = bancoAsociado;
      this.estado = estado;
      this.soportaDespositos = soportaDespositos;
      this.soportaTranferencias = soportaTranferencias;
      this.saldoExtraccion = saldoExtraccion;
      this.saldoDeposito = saldoDeposito;
      this.saldo = saldo;
    }

    public void retirarDinero()
    {
      Console.WriteLine($"Se retiro ${saldoExtraccion} del cajero.");
    }

    public void depositarDinero()
    {
      Console.WriteLine($"Se deposito ${saldoDeposito} del cajero.");
    }

    public void consultarSaldo()
    {
      Console.WriteLine($"Saldo de la cuenta: ${saldo}.");
    }
  }
  static void Main(string[] args)
  {
    CajeroAutomico cajero1 = new CajeroAutomico(01, 50000, "Av. Rosas 51", "Galicia", "Disponible", true, true, 1000, 1000, 5000);
    Console.WriteLine(cajero1);
    Console.WriteLine("");

    cajero1.retirarDinero();

    Console.WriteLine("");
    Console.WriteLine(cajero1);
  }
}