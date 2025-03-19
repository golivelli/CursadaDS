// Por Valor: implementar una función que reciba dos enteros y luego imprima de uno
// en uno desde el valor menor hasta el valor mayor.

using System;
namespace Ejercicio2;
class Program
{
  public static void mostrarNumeros(int vInicial, int vMax)
  {
    for (int i = vInicial; i <= vMax; i++)
    {
      Console.WriteLine(i);
    }
  }

  static void Main(string[] args)
  {
    int vInicial, vMax;

    Console.Write("Ingrese el valor incial a mostrar: ");
    vInicial = int.Parse(Console.ReadLine());

    if(vInicial < 0)
    {
      do
      {
        Console.Write("Ingrese el valor incial a mostrar, debe ser mayor o igual a 0: ");
        vInicial = int.Parse(Console.ReadLine());
      } while (vInicial < 0);
    } 

    Console.Write("Ingrese el valor máximo a mostrar: ");
    vMax = int.Parse(Console.ReadLine());

    if(vMax < 0)
    {
      do
      {
        Console.Write("Ingrese el valor máximo a mostrar, debe ser mayor o igual a 0: ");
        vMax = int.Parse(Console.ReadLine());
      } while (vMax < 0);
    }

    if (vMax < vInicial)
    {
      return Console.Write("El valor máximo a mostrar no puede ser mayor al número incial a mostrar, porfavor ingrese nuevamente.");
    } 
    else
    {
      mostrarNumeros(vInicial, vMax);
    }
  }
}