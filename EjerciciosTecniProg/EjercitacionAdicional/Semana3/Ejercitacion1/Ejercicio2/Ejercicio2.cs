// Realizar el diagrama y codificación de un programa que ingrese 5 números y
// calcule e informe la cantidad de pares y el promedio de los impares.

using System;
namespace Ejercicio2;

class Ejercicio2
{
  static void Main(string[] args)
  {
    int cantPares, cantImpares, sumaImpares, promImpares;
    int num, cantNumber;

    cantPares = 0;
    cantImpares = 0;
    sumaImpares = 0;
    cantNumber = 5;
    
    Console.WriteLine("Por favor, ingrese 5 números para poder finalizar el programa.");
    for (int i = 1; i <= cantNumber; i++)
    {
      Console.Write($"Número {i}: ");
      num = int.Parse(Console.ReadLine());

      while (num < 0)
      {
        Console.WriteLine($"El ingreso de números debe ser mayor a 0. Por favor, ingrese nuevamente (Número {i}): ");
        Console.Write($"Número {i}: ");
        num = int.Parse(Console.ReadLine());
      }

      if(num % 2 == 0)
      {
        cantPares += 1;
      } else 
      {
        cantImpares += 1;
        sumaImpares += num;
      }
    }

    Console.WriteLine("La cantidad de pares ingresados es: " + cantPares);

    if(cantImpares > 0)
    {
      promImpares = sumaImpares / cantImpares;
      Console.WriteLine("El promedio de los impares ingresados es: " + promImpares);
    } else
    {
      Console.WriteLine("No se ingresaron números impares.");
    }
  }
}