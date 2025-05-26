// Crear una interfaz IVehiculo con el método Conducir().
// Implementar las clases Auto, Moto y Bicicleta. Adaptar el método conducir para cada clase. 

using System;
using Interface.Vehiculo;

class Program
{
  private static void Main(string[] args)
  {
    IVehiculo[] vechiculos = new IVehiculo[3];

    vechiculos[0] = new Auto("Audi", "RS6", 2024);
    vechiculos[1] = new Moto("Yamaha", "R1", 2022);
    vechiculos[2] = new Bicicleta("Venzo", "X-Blaze.ex", 2024);

    foreach (IVehiculo v in vechiculos)
    {
      v.Conducir();
      Console.WriteLine("");
    }
  }
} 