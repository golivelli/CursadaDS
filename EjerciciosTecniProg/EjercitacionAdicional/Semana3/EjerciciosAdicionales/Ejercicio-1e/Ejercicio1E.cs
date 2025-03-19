// Pedir el radio de un círculo y calcular su área.

using System;
namespace Ejercicio1E;

class Ejercicio1E
{
  static void Main(string[] args)
  {
    double pi;
    double radio;
    double area;

    pi = 3.14;

    Console.Write("Ingrese el radio de un círculo: ");
    radio = double.Parse(Console.ReadLine());

    while (radio <= 0)
    {
      Console.Write("El radio del círculo debe ser mayor a 0. Por favor, ingresa nuevamente: ");
      radio = double.Parse(Console.ReadLine());
    }

    area = pi * (radio * radio);

    Console.Write("El área del círculo es de: " + area);
  }
}
