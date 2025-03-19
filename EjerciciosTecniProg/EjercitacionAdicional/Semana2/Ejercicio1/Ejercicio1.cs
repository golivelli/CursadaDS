// Pedir que se ingrese 2 números enteros y mostrar la suma entre ambos.

using System;
using System.Globalization;
namespace Ejercicio1;

class Ejercicio1 
{
  static void Main (string[] args)
  {
    int num1, num2;
    int suma;

    Console.Write("Ingrese el primer número a sumar: ");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número a sumar: ");
    num2 = int.Parse(Console.ReadLine());

    suma = num1 + num2;
    Console.Write($"El resultado de esta suma es: " + suma);
  }
}