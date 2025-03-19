// Pedir un número e indicar si es positivo o negativo.

using System;
namespace Ejercicio1H;

class Ejercicio1H
{
  static void Main(string[] args)
  {
    int num1;

    Console.Write("Ingrese un número: ");
    num1 = int.Parse(Console.ReadLine());

    if(num1 < 0)
    {
      Console.Write("El número ingresado es negativo.");
    } else if (num1 > 0)
    {
      Console.Write("El número ingresado es positivo.");
    } else
    {
      Console.Write("El número ingresado es nulo.");
    }
  }
}
