using System;
namespace Program;

class Program
{
  static void Main(string[] args)
  {
    static void Ejercicio1()
    {
      // Buscar un número en un arreglo ordenado.
      // Dado un arreglo de números enteros ordenado, implementa la búsqueda binaria para encontrar la posición de un número.
      // Solicita al usuario el número que desea buscar y devuelve la posición en el arreglo o -1 si no se encuentra.

      static void encontrarNumero(int number, int[] numbers)
      {
        int posDesde = 0;
        int posHasta = numbers.Length - 1;
        int pivote = 0;
        bool encontrado = false;

        while (posDesde <= posHasta && !encontrado)
        {
          pivote = (posDesde + posHasta);

          if (numbers[pivote] == number)
          {
            encontrado = true;
            Console.Write($"Número ingresado, encontrado en la posición {numbers[pivote]}.");
            break;
          }
          else
          {
            if (number < numbers[pivote])
            {
              posHasta = pivote - 1;
            }
            else
            {
              posDesde = pivote + 1;
            }
          }
        }

        if (encontrado == false)
        {
          Console.Write("Número ingresado no encontrado en el array.");
        }
      }

      Console.Write("Ingresa el número a encontrar: ");
      int number = int.Parse(Console.ReadLine());

      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      encontrarNumero(number, numbers);
    }
    // Ejercicio1();

    static void Ejercicio2()
    {
      // 2) Comprobar si un número está presente.
      // Escribe una función que reciba un número y un arreglo de enteros ordenado y utilice la búsqueda binaria para verificar si el número está presente en el arreglo. 
      // Si está, devuelve true; si no, devuelve false.

      static void encontrarNumero(int number, int[] numbers)
      {
        int posDesde = 0;
        int posHasta = numbers.Length - 1;
        int pivote = 0;
        bool encontrado = false;

        while (posDesde <= posHasta && !encontrado)
        {
          pivote = (posDesde + posHasta) / 2;

          if (numbers[pivote] == number)
          {
            encontrado = true;
          }
          else
          {
            if (number < numbers[pivote])
            {
              posHasta = pivote - 1;
            }
            else
            {
              posDesde = pivote + 1;
            }
          } 
        }

        if (encontrado == true)
        {
          Console.Write(encontrado);
        }
        else
        {
          Console.Write(encontrado);
        }
      }

      Console.Write("Ingresa el número a buscar: ");
      int number = int.Parse(Console.ReadLine());

      int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

      encontrarNumero(number, numbers);
    }
    // Ejercicio2();

    static void Ejercicio3()
    {
      // 3) Buscar un rango de valores.
      // Dado un arreglo de números enteros ordenado, busca el primer y el último índice en el que aparece un número específico. 
      // Usa la búsqueda binaria para encontrar la primera aparición y luego expande la búsqueda para encontrar la última aparición.

      static void encontrarIndices(int number, int[] numbers)
      {
        static int primeraAparicion(int number, int[] numbers)
        {
          int posDesde = 0;
          int posHasta = numbers.Length - 1;
          int pivote = 0;
          int resultado = -1;

          while (posDesde <= posHasta)
          {
            pivote = posHasta + (posDesde - posHasta) / 2;

            if (numbers[pivote] == number)
            {
              resultado = pivote;
              posHasta = pivote - 1;
            }
            else
            {
              if (number < numbers[pivote])
              {
                posDesde = pivote + 1;
              }
              else
              {
                posHasta = pivote - 1;
              }
            }
          }
          return resultado;
        }

        static int ultimaAparicion(int number, int[] numbers)
        {
          int posDesde = 0;
          int posHasta = numbers.Length - 1;
          int pivote = 0;
          int resultado = -1;

          while (posDesde <= posHasta)
          {
            pivote = posDesde + (posDesde - posHasta) / 2;

            if (numbers[pivote] == number)
            {
              resultado = pivote;
              posDesde = pivote + 1;
            }
            else
            {
              if (number < numbers[pivote])
              {
                posDesde = pivote + 1;
              }
              else
              {
                posHasta = pivote - 1;
              }
            }
          }
          return resultado;
        }

        int primerAparicion = primeraAparicion(number, numbers);
        int ultAparicion = ultimaAparicion(number, numbers); 

        Console.WriteLine($"Índice de la primera aparición: {primerAparicion}");
        Console.WriteLine($"Índice de la última aparición: {ultAparicion}");
      }

      int[] numbers = { 3, 3, 3, 12, 15, 18, 21, 24, 27, 30 };
      int number = 3;

      encontrarIndices(number, numbers);
    }
    Ejercicio3();
  }
}