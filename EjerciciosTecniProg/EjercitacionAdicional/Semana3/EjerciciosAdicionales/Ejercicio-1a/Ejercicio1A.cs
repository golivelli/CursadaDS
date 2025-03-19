// Se necesita un programa que pida 3 valores numéricos y muestre por
// pantalla la suma de todos.

using System; 
namespace Ejercicio1A;

class Ejercicio1A
{
  static void Main(string[] args)
  {
    int number, cantnumbers, sumNumbers;
    int numbers;

    cantnumbers = 3;
    sumNumbers = 0;
    numbers = 0;

    for (int i = 1; i <= cantnumbers; i++)
    {
      Console.WriteLine($"Ciclo N°{i}.");
      Console.Write("Ingrese un número: ");
      number = int.Parse(Console.ReadLine());

      numbers += number;
    }
    Console.Write(numbers);
  }
}

