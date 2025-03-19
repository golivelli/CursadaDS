using System;
namespace Program;

class Program
{
  public static string validarName()
  {
    int number;
    string input;
    bool esNumero;

    do
    {
      Console.Write("Ingrese un nombre: ");
      input = Console.ReadLine();

      esNumero = int.TryParse(input, out number);

      if (esNumero)
      {
        Console.WriteLine("Por favor, ingrese un valor alfebetico.");
      }

      Console.WriteLine("");
    } while (esNumero);

    return input;
  }
  public static int validarNumber()
  {
    int number;
    string input;
    bool esNumero;

    do
    {
      Console.Write("Ingrese un número de forma numerica: ");
      input = Console.ReadLine();

      esNumero = int.TryParse(input, out number);

      if (!esNumero)
      {
        Console.WriteLine("Por favor, ingrese un valor numérico.");
      }

      Console.WriteLine("");
    } while (!esNumero);

    return number;
  }

  static void Main(string[] args)
  {
    static void Ejercicio1()
    {
      // 1) Ordenar un arreglo de números enteros

      static void orderArray(int[] numbers)
      {
        int aux;

        for (int a = 1; a < numbers.Length; a++)
        {    
          for (int b = numbers.Length - 1; b >= a; b--) // Preguntar Profe
          {             
            if (numbers[b - 1] > numbers[b])
            {
              aux = numbers[b - 1];
              numbers[b - 1] = numbers[b];
              numbers[b] = aux;
            }
          }
        }

        Console.Write($"{String.Join(", ", numbers)}");
      }

      static void carryArray(int cantElements)
      {
        int[] numbers = new int[cantElements];

        for (int i = 0; i < numbers.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}");

          int number = validarNumber();

          numbers[i] = number;
        }

        orderArray(numbers);
      }

      static int validarElements()
      {
        int cantElements;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese cantidad de elementos que contendra el arreglo: ");
          input = Console.ReadLine();

          esNumero = int.TryParse(input, out cantElements);

          if (!esNumero)
          {
            Console.Write("Ingrese un valor numerico. Ingrese nuevamente.");
          }
        } while (!esNumero);

        return cantElements;
      }

      int cantElements = validarElements();

      carryArray(cantElements);
    }
    // Ejercicio1();

    static void Ejercicio2()
    {
      // 2) Ordenar nombres alfabéticamente

      static void orderNames(string[] names)
      {
        string aux;

        for (int i = 1; i < names.Length; i++) 
        { 
          for (int j = names.Length - 1; j >= i; j--)
          {
            if (string.Compare(names[j - 1], names[j]) > 0)
            {
              aux = names[j - 1];
              names[j - 1] = names[j];
              names[j] = aux;
            }
          }
        }

        Console.Write($"Nombres Ordenados: {String.Join(", ", names)}");
      }

      static void carryArray(int cantElements)
      {
        string[] names = new string[cantElements];

        for (int i = 0; i < names.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}");

          string name = validarName();
          names[i] = name;
        }

        orderNames(names);
      }

      static int validarElements()
      {
        int cantElements;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de nombres a ingresar: ");
          input = Console.ReadLine();

          esNumero = int.TryParse(input, out cantElements);

          if (!esNumero)
          {
            Console.Write("Por favor ingrese valores numericos.");
          } 
        } while (!esNumero);

        return cantElements;
      }

      int cantElements = validarElements();
      carryArray(cantElements);
    }
    // Ejercicio2();

    static void Ejercicio3()
    {
      // 3) Ordenar números en orden descendente

      static void orderDescNumber(int[] numbers)
      {
        int aux;

        for (int i = 1; i < numbers.Length; i++)
        {
          for (int j = numbers.Length - 1; j >= i; j--)
          {
            if (numbers[j - 1] < numbers[j])
            {
              aux = numbers[j - 1];
              numbers[j - 1] = numbers[j];
              numbers[j] = aux; 
            }
          }
        }

        Console.Write($"Números ordenados de forma descendente: {String.Join(", ", numbers)}");
      }

      static void carryArray(int cantElements)
      {
        int[] numbers = new int[cantElements];

        for (int i = 0; i < numbers.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}");

          int number = validarNumber();
          numbers[i] = number;
        }

        orderDescNumber(numbers);
      }

      static int validarElements()
      {
        int cantElements;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de números a ingresar: ");
          input = Console.ReadLine();

          esNumero = int.TryParse(input, out cantElements);

          if (!esNumero)
          {
            Console.Write("Por favor ingrese valores numericos.");
          } 
        } while (!esNumero);

        return cantElements;
      }

      int cantElements = validarElements();
      carryArray(cantElements);
    }
    Ejercicio3();
  }
}
