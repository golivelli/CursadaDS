// Elaborar un algoritmo que lea los 3 lados de un triángulo cualquiera y calcule
// su perímetro considerando A, B y C como lados

using System;
namespace Ejercicio2;

class Ejercicio2
{
  static void Main(string[] args)
  {
    float ladoA, ladoB, ladoC, perimetro;

    do
    {
      Console.Write("Ingrese el lado N° 1: ");
      ladoA = float.Parse(Console.ReadLine());

      Console.Write("Ingrese el lado N° 2: ");
      ladoB = float.Parse(Console.ReadLine());

      Console.Write("Ingrese el lado N° 3: ");
      ladoC = float.Parse(Console.ReadLine());

      if(ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
      {
        Console.WriteLine("Los lados de un triángulo deben ser mayores que 0. Por favor, ingrese nuevamente.");
      }
    } while (ladoA <= 0 || ladoB <= 0 || ladoC <= 0);

    perimetro  = ladoA + ladoB + ladoC;
    Console.Write("El perimetro del triangulo dado es de: " + perimetro);
  }
}

