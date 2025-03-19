// Pedir dos números y decir si son iguales o no.

using System;
namespace Ejercicio1G;

class Ejercicio1G
{
  static void Main(string[] args)
  {
    int num1, num2;

    Console.Write("Ingrese el primer número: ");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    num2 = int.Parse(Console.ReadLine());

    if(num1 == num2)
    {
      Console.Write("Los números ingresados, son iguales.");
    } else
    {
      Console.Write("Los números ingresados, son diferentes.");
    }
  }
}
