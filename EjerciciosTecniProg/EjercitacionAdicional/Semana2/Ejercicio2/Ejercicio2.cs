// Ingresar valores del tipo real en las variables numero1 y numero2. Una vez
// ingresadas, invertir los valores, es decir, que lo cargado en numero1 quede
// guardado en numero2 y viceversa.

using System;
namespace Ejercicio2;

class Ejercicio2
{
  static void Main (string[] args)
  {
    float num1, num2, temp;

    Console.Write("Ingrese el primer número: ");
    num1 = float.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    num2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Número 1 (Original): " + num1);
    Console.WriteLine("Número 2 (Original): " + num2);

    temp = num1;
    num1 = num2;
    num2 = temp;

    Console.WriteLine("Número 1 (Invertido): " + num1);
    Console.WriteLine("Número 2 (Invertido): " + num2);
  }
}