// Por Referencia: Confeccionar la función OrdenarPorReferencia() que reciba por
// referencia tres enteros y ordene sus valores de menor a mayor.
// Al volver de la ejecución, numeroA debería valer numeroC, numeroB debería valer numeroA y 
// numeroC debería valer numeroB.

using System;
namespace Ejercicio3;

class Program
{
  public static void OrdernarPorRef(ref int numeroA, ref int numeroB, ref int numeroC)
  {
    if (numeroA > numeroB)
    {
      IntercambiarValores(ref numeroA, ref numeroB);
    }
    if (numeroA > numeroC)
    {
      IntercambiarValores(ref numeroA, ref numeroC);
    }
    if (numeroB > numeroC)
    {
      IntercambiarValores(ref numeroB, ref numeroC);
    }
  }

  public static void IntercambiarValores(ref int x, ref int y)
  {
    int temp = x;
    x = y;
    y = temp;
  }
  static void Main(string[] args)
  {
    int numeroA = 5;
    int numeroB = 7;
    int numeroC = 1;

    Console.WriteLine($"Antes de ordenar: A = {numeroA}, B = {numeroB}, C = {numeroC}");
    OrdernarPorRef(ref numeroA, ref numeroB, ref numeroC);

    Console.WriteLine($"Después de ordenar: A = {numeroA}, B = {numeroB}, C = {numeroC}");
  }
}