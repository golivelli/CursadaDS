// Realizar el pseudocódigo que calcule los metros cuadrados que tiene una
// casa dadas las dimensiones de cada habitación. Preguntar al usuario cuántas
// habitaciones hay en la casa y después pida las dimensiones de cada
// habitación. Informar el resultado.

using System;
namespace Ejercicio1;

class Ejercicio1
{
  static void Main(string[] args)
  {
    int cantHab;
    double metCuadrado;

    Console.Write("Ingrese la cantidad de habitaciones: ");
    cantHab = int.Parse(Console.ReadLine());

    while (cantHab <= 0)
    {
      Console.Write("Las habitaciones deben ser mayores a 0. Por favor, ingrese nuevamente: ");
      cantHab = int.Parse(Console.ReadLine());
    }

    if(cantHab > 0)
    {
      Console.WriteLine("Por favor, ingrese las dimensiones de las habitaciones.");

      for(int i = 1; i <= cantHab; i++)
      {
        double largo, ancho;

        Console.Write($"Ingrese el largo de la habitación N° {i}: ");
        largo = Convert.ToDouble(Console.ReadLine());

        while (largo <= 0)
        {
          Console.Write("El largo de la habitación debe ser mayor a 0. Por favor, ingrese nuevamente: ");
          largo = double.Parse(Console.ReadLine());
        }

        Console.Write($"Ingrese el ancho de la habitación N° {i}: ");
        ancho = Convert.ToDouble(Console.ReadLine());

        while (ancho <= 0)
        {
          Console.Write("El ancho de la habitación debe ser mayor a 0. Por favor, ingrese nuevamente: ");
          ancho = double.Parse(Console.ReadLine());
        }

        metCuadrado = largo * ancho;
        Console.WriteLine($"El metro cuadrado de esta habitación (N° {i}), es de: " + metCuadrado);
      }
    } else 
    {
      Console.Write("No se ingresaron datos.");
    }
  }
}