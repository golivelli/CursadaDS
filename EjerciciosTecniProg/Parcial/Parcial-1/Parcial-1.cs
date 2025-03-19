using System;
namespace Program;

class Program
{
  // ORDENAR POR CANT VENTAS
  static void orderVolumenVentas(int[] ventasAcumuladas, string[] namesEmployee, int[] nLegajo, string[] category)
  {
    int auxVentas;
    string auxNames, auxCategory;
    int auxLegajo;

    for (int i = 1; i < ventasAcumuladas.Length; i++)
    {
      for (int j = ventasAcumuladas.Length - 1; j >= i; j--)
      {
        if (ventasAcumuladas[j - 1] < ventasAcumuladas[j])
        {
          auxVentas = ventasAcumuladas[j - 1];
          auxNames = namesEmployee[j - 1];
          auxLegajo = nLegajo[j - 1];
          auxCategory = category[j - 1];

          ventasAcumuladas[j - 1] = ventasAcumuladas[j];
          namesEmployee[j - 1] = namesEmployee[j];
          nLegajo[j - 1] = nLegajo[j];
          category[j - 1] = category[j];

          ventasAcumuladas[j] = auxVentas;
          namesEmployee[j] = auxNames;
          nLegajo[j] = auxLegajo;
          category[j] = auxCategory;
        }
      }
    }
  }

  // LISTAR EMPLEADOS
  static void listEmployee(string[] namesEmployee, int[] nLegajo, string[] category, int[] ventasAcumuladas)
  {
    Console.Write("Lista de empleados");
    Console.WriteLine("");

    for (int i = 0; i < namesEmployee.Length; i++)
    {
      Console.WriteLine($"Nombre y Apellido: {namesEmployee[i]}");
      Console.WriteLine($"N° de legajo: {nLegajo[i]}");
      Console.WriteLine($"Ventas en el mes: {ventasAcumuladas[i]}");
      Console.WriteLine($"Porcentaje por categoria: %{porcentajeComision(category[i], ventasAcumuladas[i])}");
      Console.WriteLine($"Comision: {comision(category[i], ventasAcumuladas[i])}");

      Console.WriteLine("");
    }
  }

  // CALCULO COMISIONES
  static double porcentajeComision(string category, int ventasAcumuladas)
  {
    double porComision = 0;

    switch (category)
    {
      case "A":
        porComision = 5;
        break;

      case "B":
        if (ventasAcumuladas > 50000)
        {
          porComision = 8;
        }
        else
        {
          porComision = 6;
        }
        break;

      case "C":
        if (ventasAcumuladas > 40000)
        {
          porComision = 7;
        }
        else
        {
          if (ventasAcumuladas > 20000 && ventasAcumuladas <= 40000)
          {
            porComision = 4;
          }
          else
          {
            porComision = 2;
          }
        }
        break;
    }

    return porComision;
  }
  static double comision(string category, int ventasAcumuladas)
  {
    return porcentajeComision(category, ventasAcumuladas) * ventasAcumuladas / 100;
  }

  // CARGA DE DATOS
  static string validateCategory()
  {
    string category;

    do
    {
      Console.Write("Ingrese su categoría (A - B - C): ");
      category = Console.ReadLine().ToUpper();

      if (category != "A" && category != "B" && category != "C")
      {
        Console.WriteLine("Ingrese un valor correcto (A - B - C).");
      }

      Console.Write("");
    } while (category != "A" && category != "B" && category != "C");

    return category;
  }

  static void cargarEmpleado(string[] namesEmployee, int[] nLegajo, string[] category, int[] ventasAcumuladas)
  {
    for (int i = 0; i < nLegajo.Length; i++)
    {
      Console.WriteLine($"Vendedor {i + 1}");

      do
      {
        Console.Write("Ingrese el número de legajo: ");
        nLegajo[i] = int.Parse(Console.ReadLine());
      } while (nLegajo[i] < 0);

      Console.Write("Ingrese el nombre y apellido del vendedor: ");
      namesEmployee[i] = Console.ReadLine();

      category[i] = validateCategory();

      Console.Write("Ingrese el monto de las ventas acumuladas: ");
      ventasAcumuladas[i] = int.Parse(Console.ReadLine());

      Console.WriteLine("");
    }
  }

  // BUSQUEDA POR LEGAJO
  static int searchXLegajo(int[] nLegajo, int searchLegajo)
  {
    for (int i = 0; i < nLegajo.Length; i++)
    {
      if (nLegajo[i] == searchLegajo)
      {
        return i;
      }
    }

    return -1;
  }

  static void searchVendedor(string[] namesEmployee, int[] nLegajo, string[] category, int[] ventasAcumuladas)
  {
    int legajo;

    do
    {
      Console.Write("Ingrese el número de legajo a buscar: ");
      legajo = int.Parse(Console.ReadLine());

      if (legajo < 0)
      {
        Console.Write("Ingrese un número de legajo valido.");
      }
    } while (legajo < 0);

    int searchLegajo = searchXLegajo(nLegajo, legajo);

    if (searchLegajo != -1)
    {
      Console.WriteLine($"Nombre y Apellido: {namesEmployee[searchLegajo]}");
      Console.WriteLine($"N° de legajo: {nLegajo[searchLegajo]}");
      Console.WriteLine($"Ventas en el mes: {ventasAcumuladas[searchLegajo]}");
      Console.WriteLine($"Porcentaje por categoria: %{porcentajeComision(category[searchLegajo], ventasAcumuladas[searchLegajo])}");
      Console.WriteLine($"Comision: {comision(category[searchLegajo], ventasAcumuladas[searchLegajo])}");
    }
    else
    {
      Console.Write("Vendedor inexistente.");
    }
  }

  // FUNCION MAIN
  static void Main(string[] args)
  {
    int cantEmployee;

    Console.Write("Ingrese la cantidad de empleados que desea calcular las comisiones: ");
    cantEmployee = int.Parse(Console.ReadLine());
    
    Console.WriteLine("");

    string[] namesEmployee = new string[cantEmployee];
    int[] nLegajo = new int[cantEmployee];
    string[] category = new string[cantEmployee];
    int[] ventasAcumuladas = new int[cantEmployee];

    cargarEmpleado(namesEmployee, nLegajo, category, ventasAcumuladas);

    orderVolumenVentas(ventasAcumuladas, namesEmployee, nLegajo, category);
    listEmployee(namesEmployee, nLegajo, category, ventasAcumuladas);
    searchVendedor(namesEmployee, nLegajo, category, ventasAcumuladas);
  }
}