// Crear la clase abstracta Vehiculo con método abstracto Arrancar() y un método no abstracto que sea acelerar().
// Crear las clases hijas Auto, Moto y Camion que implementen Arrancar().

// En el Main, crear un arreglo de Vehículos y que ejecuten el método arrancar y acelerar.

using System;
using Vehicle.Type;

class Program
{
  private static void Main(string[] args)
  {
    Vehiculo[] vehiculos = new Vehiculo[3];
    vehiculos[0] = new Auto("Auto", "Audi", "RS6", 2024);
    vehiculos[1] = new Moto("Moto", "Yamaha", "R1", 2023);
    vehiculos[2] = new Camion("Camion", "Mercedes Benz", "Arocs", 2021);

    foreach (Vehiculo v in vehiculos)
    {
      v.mostrarTipo();
      v.arrancar();
      v.acelerar();
      Console.WriteLine("");
    }
  }
}
