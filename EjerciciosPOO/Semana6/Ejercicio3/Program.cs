// Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int montoASumar), retirarMonto(int montoARestar) 
// mostrar información de la cuenta (nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
// CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
// En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.

using System;

class Program
{
  class Cuenta 
  {
    protected int nro_cuenta, saldo;
    protected string nombre, estado_cuenta;

    public Cuenta(int nro_cuenta, int saldo, string nombre, string estado_cuenta)
    {
      this.nro_cuenta = nro_cuenta;
      this.saldo = saldo;
      this.nombre = nombre;
      this.estado_cuenta = estado_cuenta;
    }
    public void ingresarMonto(int montoASumar)
    {
      if (montoASumar > 0)
      {
        saldo += montoASumar;
      }
    }
    public int retirarMonto(int montoARestar)
    {
      if (montoARestar > 0)
      {
        saldo -= montoARestar;
      }

      return saldo;
    }
    public void mostrarInfo()
    {
      Console.WriteLine("Información de la cuenta");
      Console.WriteLine($"N° Cuenta: {this.nro_cuenta}, Saldo: {this.saldo}, Titular: {this.nombre}, Estado de Cuenta: {this.estado_cuenta}.");
    }
  }

  class CuentaMayor : Cuenta
  {
    protected int edad;
    protected bool mayor;

    protected CuentaMayor(int nro_cuenta, int saldo, string nombre, string estado_cuenta, int edad, bool mayor) : base(nro_cuenta, saldo, nombre, estado_cuenta)
    {
      this.edad = edad;
      this.mayor = mayor;
    }

    public void validarEdad(int edad)
    {
      if (edad >= 18)
      {
        Console.WriteLine("Edad valida para abrir cuenta de mayoria de edad.");
      } else 
      {
        Console.WriteLine("Edad no valida para una abrir cuenta de mayoria de edad.");
      }
    }
  }

  class CuentaMenor : Cuenta
  {
    protected int edad;
    protected bool menor;

    protected CuentaMenor(int nro_cuenta, int saldo, string nombre, string estado_cuenta, int edad, bool menor) : base(nro_cuenta, saldo, nombre, estado_cuenta)
    {
      this.edad = edad;
      this.menor = menor;
    }
  }

  class CuentaEstudiante : Cuenta
  {
    protected bool estudiante;

    protected CuentaEstudiante(int nro_cuenta, int saldo, string nombre, string estado_cuenta, bool estudiante) : base(nro_cuenta, saldo, nombre, estado_cuenta)
    {
      this.estudiante = estudiante;
    }
  }

  static void Main(string[] args)
  {
    Cuenta c1 = new Cuenta(123, 5000, "Geronimo", "Disponible");
    c1.ingresarMonto(500);
    c1.mostrarInfo();
    Console.WriteLine("");
    c1.retirarMonto(400);
    c1.mostrarInfo();
  }
}