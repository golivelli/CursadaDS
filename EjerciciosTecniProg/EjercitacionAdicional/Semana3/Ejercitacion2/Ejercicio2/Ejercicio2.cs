// Ingresar 15 números. Calcular e informar el promedio de los pertenecientes al
// intervalo cerrado [-10,10] y la cantidad de los restantes.

using System;
namespace Ejercicio2;

class Ejercicio2 
{
  static void Main(string[] args)
  {
    double number;
    double cantNumbers, cantRestantes;
    int numbers, totNumbers;

    numbers = 5; // 15
    cantNumbers = 0;
    cantRestantes = 0; 
    totNumbers = 0;
    
    for (int i = 1; i <= numbers; i++)
    {
      Console.Write("Ingrese un número: ");
      number = int.Parse(Console.ReadLine());

      if (number >= -10 && number <= 10)
      { 
        cantNumbers += number;
      } else
      {
        cantRestantes++;
      }

      totNumbers++;
    }

    if(totNumbers > 0)
    {
      double promItervalo;

      promItervalo = cantNumbers / totNumbers;
      Console.WriteLine("El promedio de los números del intervalo cerrado [-10,10] es de: " + promItervalo);
      Console.Write("La cantidad de los números restantes es de: " + cantRestantes);
    } else 
    {
      Console.Write("No se ingresaron números.");
    }
  }
}