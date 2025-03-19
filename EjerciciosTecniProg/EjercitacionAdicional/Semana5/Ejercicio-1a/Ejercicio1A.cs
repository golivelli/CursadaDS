// Ingresar 5 números. Calcular e informar el mayor número negativo, promedio de los
// positivos y cantidad de ceros.

using System;
namespace Ejercicio1A;

class Ejercicio1A
{
  static void Main(string[] args)
  {
    int firstNumber, numbers;
    int cantCeros, sumNumbers, totNumbers;
    int mayorNeg;
    bool hayNegativos = false;

    numbers = 5;
    cantCeros = 0;
    sumNumbers = 0;
    totNumbers = 0;
    mayorNeg = 0;

    for (int i = 1; i <= 5; i++)
    {
      Console.WriteLine($"Ciclo N° {i}/5.");
      Console.Write("Ingrese un número: ");
      firstNumber = int.Parse(Console.ReadLine());

      if (firstNumber == 0)
      {
        cantCeros++;
      }

      if (firstNumber < 0)
      {
        if(!hayNegativos || firstNumber > mayorNeg)
        {
          mayorNeg = firstNumber;
          hayNegativos = true;
        } 
      }

      if (firstNumber > 0)
      {
        sumNumbers += firstNumber;
        totNumbers++;
      }
    }

    Console.WriteLine("Cantidad de ceros: " + cantCeros);

    if(hayNegativos)
    {
      Console.WriteLine("El mayor número negativo es: " + mayorNeg);
    } else
    {
      Console.WriteLine("No se ingresaron números negativos.");
    }
    

    if(totNumbers > 0)
    {
      double promPositivos;

      promPositivos = sumNumbers / totNumbers;
      Console.WriteLine("El promedio de los números positivos es: " + promPositivos);
    } else
    {
      Console.WriteLine("No hay números positivos");
    }
  }
}
