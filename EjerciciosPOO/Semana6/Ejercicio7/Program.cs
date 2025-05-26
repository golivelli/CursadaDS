// Definir la clase Tren y su hija, Vagón. Se deben crear los métodos vagonLleno, acelerar(int velocidad) y frenar.

using System;

class Program{
  class Tren
  {
    protected int velocidadActual;

    public Tren()
    {
      this.velocidadActual = 0;
    }

    public void Acelerar(int velocidad)
    {
      velocidadActual += velocidad;
      Console.WriteLine($"El tren aceleró hasta {velocidadActual} km/h.");
    }

    public void Frenar()
    {
      velocidadActual = 0;
      Console.WriteLine("El tren frenó completamente.");
    }
  }

  class Vagon : Tren
  {
    protected int capacidad;
    protected int ocupados;

    public Vagon(int capacidad)
    {
      this.capacidad = capacidad;
      this.ocupados = 0;
    }

    public bool VagonLleno()
    {
      return ocupados >= capacidad;
    }

    public void SubirPasajeros(int cantidad)
    {
      ocupados += cantidad;

      if (VagonLleno())
      {
        Console.WriteLine("El vagón está lleno.");
      }
      else
      {
        Console.WriteLine($"Hay {ocupados}/{capacidad} pasajeros en el vagón.");
      }
    }
  }

  static void Main(string[] args)
    {
      Vagon vagon1 = new Vagon(30);
      vagon1.SubirPasajeros(10);
      vagon1.Acelerar(50);
      vagon1.Frenar();
      vagon1.SubirPasajeros(20);

      // Console.WriteLine($"¿El tren se encuentra lleno? {vagon1.VagonLleno()}");
    }
}