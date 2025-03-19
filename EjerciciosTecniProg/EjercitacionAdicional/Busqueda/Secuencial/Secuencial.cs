using System;
namespace Program;

class Program
{
  static void Main(string[] args)
  {
    static void Ejercicio1()
    {
      // 1) Encontrar un número
      // Crea un arreglo de números enteros desordenado, pide al usuario que ingrese un número a buscar.
      // Implementa la búsqueda secuencial para encontrar el número en el arreglo. 
      // Si encuentra el número, muestra su posición. Si no, indica que no se encontró.
      static void encontrarNumero(int number, int[] numbers)
      {
        bool encontrado = false;

        for (int i = 0; i < numbers.Length; i++)
        {
          if (numbers[i] == number)
          {
            encontrado = true;
            Console.Write($"El número ingresado se encuentra en la posición {i + 1}.");
            break;
          }
        }

        if (!encontrado)
        {
          Console.Write("El número ingresado no se encuentra en el array.");
        }
      }

      Console.Write("Ingresa el número a encontrar: ");
      int number = int.Parse(Console.ReadLine());

      int[] numbers = { 9, 7, 4, 3, 10, 2, 1, 5, 6, 8 };

      encontrarNumero(number, numbers);
    }
    // Ejercicio1();

    static void Ejercicio2()
    {
      // 2) Contar ocurrencias
      // Modifica el ejercicio anterior para que, además de indicar si el número se encuentra, cuente cuántas veces aparece en el arreglo.
      static void encontrarNumero(int number, int[] numbers)
      {
        bool encontrado = false;
        int repeatNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
          if (numbers[i] == number)
          {
            encontrado = true;
            repeatNumber++;
          }
        }

        Console.Write($"El número ingresado se encuentra {repeatNumber} veces en el array.");

        if (!encontrado)
        {
          Console.Write("El número ingresado no se encuentra en el array.");
        }
      }

      Console.Write("Ingresa el número a encontrar: ");
      int number = int.Parse(Console.ReadLine());

      int[] numbers = { 9, 7, 4, 1, 10, 2, 1, 5, 6, 8 };

      encontrarNumero(number, numbers);
    }
    // Ejercicio2();

    static void Ejercicio3()
    {
      // 3) Buscar el elemento más grande
      // Utiliza la búsqueda secuencial para encontrar el elemento más grande de un arreglo.
      static void encontrarNumero(int[] numbers)
      {
        bool encontrado = true;
        int bigNumber = numbers[0];
        int pos = 0;

        for (int i = pos; i < numbers.Length; i++)
        {
          if (encontrado)
          {
            bigNumber = numbers[i];
            pos = i;
            encontrado = false;
          }

          if (bigNumber < numbers[i])
          {
            bigNumber = numbers[i];
            pos = i;
          }
        }

        Console.Write($"El elemento más grande del arreglo es {bigNumber} y se encuentra en la posición {pos}.");
      }

      int[] numbers = { 9, 7, 4, 3, 10, 2, 1, 5, 6, 8 };
      encontrarNumero(numbers);
    }
    // Ejercicio3();

    static void Ejercicio4()
    {
      // 4) Búsqueda de cadenas
      // Dado un arreglo de cadenas de texto (por ejemplo, nombres), busca si una cadena específica se encuentra en el arreglo.
      // Si está, devuelve su posición; si no, devuelve un mensaje indicando que no se encuentra.
      static void encontrarCadena(string cadena, string[] cadenas)
      {
        bool encontrado = false;

        for (int i = 0; i < cadenas.Length; i++)
        {
          if (cadena == cadenas[i])
          {
            encontrado = true;
            Console.Write($"La cadena ingresada se encuentra en la posición {i + 1}.");
            break;
          }
        }

        if (!encontrado)
        {
          Console.Write("La cadena ingresada no se encuentra en el array.");
        }
      }

      Console.Write("Ingrese una palabra: ");
      string cadena = Console.ReadLine().ToLower();

      string[] cadenas = { "hola", "casa", "perro", "geronimo" };
      encontrarCadena(cadena, cadenas);
    }
    // Ejercicio4();
  }
}
