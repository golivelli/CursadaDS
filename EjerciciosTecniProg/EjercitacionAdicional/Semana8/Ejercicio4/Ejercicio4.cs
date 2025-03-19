// Por Valor: Realizar un programa, que utilice una función que permita calcular si un
// número es múltiplo de otro, y devuelva el mensaje correspondiente.

using System;
namespace Ejercicio4;

class Program
{
  public static void Multiplo(int number1, int number2)
  {
    if (number1 % number2 == 0)
    {
      Console.Write("El número ingresado es múltiplo.");
    } 
    else 
    {
      Console.Write($"El número ingresado no es múltiplo de {number2}.");
    }
  }
  static void Main(string[] args)
  {
    int number1, number2;

    Console.Write("Ingrese un número: ");
    number1 = int.Parse(Console.ReadLine());

    if(number1 <= 0)
    {
      do
      {
        Console.Write("El número debe ser mayor a 0: ");
        number1 = int.Parse(Console.ReadLine());
      } while (number1 <= 0);
    } 

    Console.Write("Ingrese su múltiplo: ");
    number2 = int.Parse(Console.ReadLine());

    if(number2 <= 0)
    {
      do
      {
        Console.Write("El número debe ser mayor a 0: ");
        number2 = int.Parse(Console.ReadLine());
      } while (number2 <= 0);
    } 

    Multiplo(number1, number2);
  }
}