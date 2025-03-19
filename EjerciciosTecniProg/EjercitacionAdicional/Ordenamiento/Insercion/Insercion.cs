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

      if(esNumero)
      {
        Console.WriteLine("Por favor, ingrese un valor alfebetico.");
      }

      Console.WriteLine("");
    } while (esNumero);

    return input;
  }
  public static int validarNumero()
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
        int j;

        for (int i = 0; i < numbers.Length; i++) 
        { 
          aux = numbers[i];
          j = i - 1;

          while (j >= 0 && numbers[j] > aux) 
          { 
            numbers[j + 1] = numbers[j];
            j--; 
          }

          numbers[j + 1] = aux;
        }

        Console.Write($"{String.Join(", ", numbers)}");
      }

      static void carryArray(int cantElements)
      {
        int[] numbers = new int[cantElements];

        for (int i = 0; i < numbers.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}.");

          int number = validarNumero();
          numbers[i] = number; 
        }

        orderArray(numbers);
      }

      static int validarElements()
      {
        int number;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de elementos del array de forma numérica: ");
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
        int j;

        for (int i = 0; i < names.Length; i++)
        {
          aux = names[i];
          j = i - 1;

          while (j >= 0 && string.Compare(names[j], aux) > 0)
          {
            names[j + 1] = names[j];
            j--;
          }

          names[j + 1] = aux;
        }

        Console.Write($"{String.Join(", ", names)}");
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
        int number;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de nombres que desea ingresar: ");
          input = Console.ReadLine();

          esNumero = int.TryParse(input, out number);

          if (!esNumero)
          {
            Console.WriteLine("Por favor, ingrese un valor de forma numerica.");
          }

          Console.WriteLine("");
        } while (!esNumero);

        return number;
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
        int j;

        for (int i = 0; i < numbers.Length; i++)
        {
          aux = numbers[i]; 
          j = i - 1; 

          while (j >= 0 && numbers[j] < aux)
          {         
            numbers[j + 1] = numbers[j];
            j--;
          }

          numbers[j + 1] = aux;
        }

        Console.Write($"{String.Join(", ", numbers)}");
      }

      static void carryArray(int cantElements)
      {
        int[] numbers = new int[cantElements];

        for (int i = 0; i < numbers.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}");

          int number = validarNumero();
          numbers[i] = number;
        }

        orderDescNumber(numbers);
      }
      
      static int validarElements()
      {
        int number;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de elementos del array de forma numérica: ");
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

      int cantElements = validarElements();
      carryArray(cantElements);
    }
    // Ejercicio3();

    static void Ejericio4()
    {
      // 4) Encuentra el tercer número más pequeño

      static void thirdSmallestNumber(int[] numbers)
      {
        int aux;
        int j;

        for (int i = 0; i < numbers.Length; i++)
        {
          aux = numbers[i];
          j = i - 1;

          while (j >= 0 && numbers[j] > aux)
          {
            numbers[j + 1] = numbers[j];
            j--;
          }

          numbers[j + 1] = aux;
        }

        Console.Write($"El tercer número más pequeño es: {numbers[2]}");
      }

      static void carryArray(int cantElements)
      {
        int[] numbers = new int[cantElements];

        for (int i = 0; i < numbers.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}");

          int number = validarNumero();
          numbers[i] = number;
        }

        thirdSmallestNumber(numbers);
      }

      static int validarElements()
      {
        int number;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de elementos del array de forma numérica: ");
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

      int cantElements = validarElements();
      carryArray(cantElements);
    }
    // Ejericio4();

    static void Ejercicio5()
    {
      // 2) Ordenar precios de productos

      static void orderPrice(int[] listPrice)
      {
        int aux;
        int j;

        for (int i = 0; i < listPrice.Length; i++)
        {
          aux = listPrice[i];
          j = i - 1;

          while (j >= 0 && listPrice[j] > aux)
          {
            listPrice[j + 1] = listPrice[j];
            j--;
          }

          listPrice[j + 1] = aux;
        }

        Console.Write($"Precios Ordenados: {String.Join(", ", listPrice)}");
      }

      static void carryArray(int cantElements)
      {
        int[] listPrice = new int[cantElements];

        for (int i = 0; i < listPrice.Length; i++)
        {
          Console.WriteLine($"Posición {i + 1}");

          int price = validarNumero();
          listPrice[i] = price;
        }

        orderPrice(listPrice);
      }

      static int validarElements()
      {
        int number;
        string input;
        bool esNumero;

        do
        {
          Console.Write("Ingrese la cantidad de precios a cargar (forma numérica): ");
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

      int cantElements = validarElements();
      carryArray(cantElements);
    }
    // Ejercicio5();
  }
}