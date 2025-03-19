// Escribir un algoritmo que sume los número pares por un lado y los impares
// por otro, mientras que se ingresen números positivos (Distintos de cero).
// Realizarlo utilizando el ciclo while y luego utilizando el ciclo do-while. 

using System;
namespace Ejercicio1;

class Ejercicio1
{
  static void Main (string[] args)
  {
    int sumaPar, sumaImpar;
    int number;

    sumaPar = 0;
    sumaImpar = 0;

    Console.Write("Ingrese un número positivo, entero: ");
    number = int.Parse(Console.ReadLine());

    while(number <= 0)
    {
      Console.Write("Por favor, ingrese un número positivo, entero: ");
      number = int.Parse(Console.ReadLine());
    }

    // WHILE
    // while(number > 0)
    // {
    //   if(number % 2 == 0)
    //   {
    //     sumaPar =+ number;
    //   } else 
    //   {
    //     sumaImpar =+ number;
    //   }

    //   Console.Write("Ingrese otro número positivo para continuar, o un número negativo para terminar: ");
    //   number = int.Parse(Console.ReadLine());
    // }

    // doWhile
    do
    {
      if(number % 2 == 0)
      {
        sumaPar =+ number;
      } else 
      {
        sumaImpar =+ number;
      }

      Console.Write("Ingrese otro número positivo para continuar, o un número negativo para terminar: ");
      number = int.Parse(Console.ReadLine());
    } while (number <= 0);

    Console.Write("Suma pares: " + sumaPar);
    Console.Write("Suma impares: " + sumaImpar);
  }
}