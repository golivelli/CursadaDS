// El supermercado “Eureka” posee un problema al vender productos que no se descuenta del stock existente.
// Se requiere realizar el modelado de las clases del stock de un supermercado, donde se detalle la
// clase Producto con sus dos clases hijas: Bebida y Alimento, que posean un método que haga
// referencia a la venta de un producto y descuente la cantidad vendida del stock existente.

using System;
using System.Linq;

class Program
{
  class Producto
  {
    protected string id;
    public Producto(string idProducto)
    {
      this.id = idProducto;
    }
  }
  class Bebida : Producto
  {
    private string nombre;
    private int stock;

    public Bebida(string idProducto, string nombreBebida, int stockProducto) : base(idProducto)
    {
      this.nombre = nombreBebida;
      this.stock = stockProducto;
    }

    // -----> Evitar errores: que no se pueda vender una bebida que no exista. <-----
    public static Bebida BuscarBebidaPorNombre(Bebida[] bebidas, string bebidaAVender)
    {
      foreach (var bebida in bebidas)
      {
        if (bebida.nombre == bebidaAVender)
        {
          return bebida;
        }
      }

      return null;
    }
    public static void ControlStockBebida(Bebida[] bebidas)
    {
      foreach (var bebida in bebidas)
      {
        if (bebida.stock == 0)
        {
          Console.WriteLine($"{bebida.nombre}: {bebida.stock}, sin stock disponible.");
        }
        else if (bebida.stock <= 3)
        {
          Console.WriteLine($"¡Quedan solo {bebida.stock} unidades en stock de {bebida.nombre}!");
        }
        else
        {
          Console.WriteLine($"{bebida.nombre}: {bebida.stock} unidades disponibles.");
        }
      }
    }
    public static void VentaProductoBebida(Bebida[] bebidas, string bebidaAVender)
    {
      Bebida bebidaABuscar = Bebida.BuscarBebidaPorNombre(bebidas, bebidaAVender);

      if (bebidaABuscar != null) {
        if (bebidaABuscar.nombre == bebidaAVender)
        {
          if (bebidaABuscar.stock > 0)
          {
            bebidaABuscar.stock -= 1;
            Console.WriteLine($"Se vendió un alimento. Stock restante de {bebidaABuscar.nombre}: {bebidaABuscar.stock}.");
          }
          else
          {
            Console.WriteLine($"{bebidaABuscar.nombre}, sin stock disponible.");
          }
        }
      } else {
        Console.WriteLine("Bebida no encontrada");
      }
    }
  }
  class Alimento : Producto
  {
    private string nombre;
    private int stock;

    public Alimento(string idProducto, string nombreAlimento, int stockProducto) : base(idProducto)
    {
      this.nombre = nombreAlimento;
      this.stock = stockProducto;
    }
    public static Alimento BuscarAlimentoPorNombre(Alimento[] alimentos, string alimentoAVender)
    {
      foreach (var alimento in alimentos)
      {
        if (alimento.nombre == alimentoAVender)
        {
          return alimento;
        }
      }

      return null;
    }
    public static void ControlStockAlimento(Alimento[] alimentos)
    {
      foreach (var alimento in alimentos)
      {
        if (alimento.stock == 0)
        {
          Console.WriteLine($"{alimento.nombre}: {alimento.stock}, sin stock disponible.");
        }
        else if (alimento.stock <= 3)
        {
          Console.WriteLine($"¡Quedan solo {alimento.stock} unidades en stock de {alimento.nombre}!");
        }
        else
        {
          Console.WriteLine($"{alimento.nombre}: {alimento.stock} unidades disponibles.");
        }
      }
    }
    public static void VentaProductoAlimento(Alimento[] alimentos, string alimentoAVender)
    {
      Alimento alimentoABuscar = Alimento.BuscarAlimentoPorNombre(alimentos, alimentoAVender);

      if (alimentoABuscar != null)
      {
        if (alimentoABuscar.nombre == alimentoAVender)
        {
          if (alimentoABuscar.stock > 0)
          {
            alimentoABuscar.stock -= 1;
            Console.WriteLine($"Se vendió un alimento. Stock restante de {alimentoABuscar.nombre}: {alimentoABuscar.stock}.");
          }
          else
          {
            Console.WriteLine($"{alimentoABuscar.nombre}, sin stock disponible.");
          }
        }
      }
      else
      {
        Console.WriteLine("Alimento no encontrado.");
      }
    }
  }
  static void Main(string[] args)
  {
    int stockAlimentos, stockBebidas;

    // ALIMENTOS
    stockAlimentos = ingresarStockAlimentos();
    Console.WriteLine("");

    if (stockAlimentos >= 1)
    {
      Alimento[] alimentos = new Alimento[stockAlimentos]; // [{id, nombreAlimento, stockDeAlimento}, {id, nombreAlimento, stockDeAlimento},}];

      for (int i = 0; i < alimentos.Length; i++)
      {
        string id, nombreAlimento;
        int stockDeAlimento;

        Console.WriteLine("--- CARGA DE DATOS ---");
        Console.WriteLine($"Alimento N° {i + 1}");
        id = ingresarIDProducto();

        Console.WriteLine("");
        nombreAlimento = ingresarNombreAlimento();
        Console.WriteLine("");

        stockDeAlimento = ingresarStockDeAlimento();

        alimentos[i] = new Alimento(id, nombreAlimento, stockDeAlimento);
        Console.WriteLine("");
      }

      Console.WriteLine("--- ESTADO INICIAL DEL STOCK ---");
      Alimento.ControlStockAlimento(alimentos);

      Console.WriteLine("");

      Console.WriteLine("--- VENTA DE PRODUCTOS ---");
      string alimentoAVender;

      alimentoAVender = ingresarProductoAVender();
      Alimento.VentaProductoAlimento(alimentos, alimentoAVender);

      Console.WriteLine("");

      Console.WriteLine("--- ESTADO DEL STOCK LUEGO DE UNA VENTA ---");
      Alimento.ControlStockAlimento(alimentos);
    } else
    {
      Console.WriteLine("No hay stock de alimentos.");
    }

    Console.WriteLine("");

    // BEBIDAS
    stockBebidas = ingresarStockBebidas();
    Console.WriteLine("");

    if (stockBebidas >= 1)
    {
      Bebida[] bebidas = new Bebida[stockBebidas]; // [{id, nombreBebida, stockDeBebida}, {id, nombreBebida, stockDeBebida},}];

      for (int i = 0; i < stockBebidas; i++)
      {
        string id, nombreBebida;
        int stockDeBebida;

        Console.WriteLine("--- CARGA DE DATOS ---");
        Console.WriteLine($"Bebida N° {i + 1}");
        id = ingresarIDProducto();

        Console.WriteLine("");
        nombreBebida = ingresarNombreBebida();
        Console.WriteLine("");

        stockDeBebida = ingresarStockDeBebida();

        bebidas[i] = new Bebida(id, nombreBebida, stockDeBebida);
        Console.WriteLine("");
      }

      Console.WriteLine("--- ESTADO INICIAL DEL STOCK ---");
      Bebida.ControlStockBebida(bebidas);

      Console.WriteLine("");

      Console.WriteLine("--- VENTA DE PRODUCTOS ---");
      string bebibaAVender;

      bebibaAVender = ingresarProductoAVender();
      Bebida.VentaProductoBebida(bebidas, bebibaAVender);

      Console.WriteLine("");

      Console.WriteLine("--- ESTADO DEL STOCK LUEGO DE UNA VENTA ---");
      Bebida.ControlStockBebida(bebidas);
    } else
    {
      Console.Write("No hay stock de bebidas.");
    }
  }

  public static string ingresarProductoAVender()
  {
    string input;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el nombre del producto a vender: ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out _);

      if (input == "" || isNumber)
      {
        Console.WriteLine("Por favor ingrese correctamente el nombre del producto a vender.");
        Console.Write("");
      }
    } while (input == "" || isNumber);

    return input;
  }
  public static int ingresarStockDeAlimento()
  {
    string input;
    int stockDeAlimento;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el stock del alimento (caracter numérico): ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out stockDeAlimento);

      if (stockDeAlimento < 0 || !isNumber)
      {
        Console.WriteLine("Por favor ingrese correctamente la cantidad de stock del alimento.");
        Console.Write("");
      }
    } while (stockDeAlimento < 0 || !isNumber);

    return stockDeAlimento;
  }
  public static int ingresarStockDeBebida()
  {
    string input;
    int stockDeBebida;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el stock de la bebida (caracter numérico): ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out stockDeBebida);

      if (stockDeBebida < 0 || !isNumber)
      {
        Console.WriteLine("Por favor ingrese correctamente la cantidad de stock de la bebida.");
        Console.Write("");
      }
    } while (stockDeBebida < 0 || !isNumber);

    return stockDeBebida;
  }
  public static string ingresarNombreAlimento()
  {
    string input;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el nombre del alimento: ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out _);

      if (input == "" || isNumber)
      {
        Console.WriteLine("Por favor ingrese correctamente el nombre del alimento.");
        Console.Write("");
      }
    } while (input == "" || isNumber);

    return input;
  }
  public static string ingresarNombreBebida()
  {
    string input;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el nombre de la bebida: ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out _);

      if (input == "" || isNumber)
      {
        Console.WriteLine("Por favor ingrese correctamente el nombre de la bebida.");
        Console.Write("");
      }
    } while (input == "" || isNumber);

    return input;
  }
  public static string ingresarIDProducto()
  {
    string input;

    do
    {
      Console.Write("Ingrese el ID del producto (exactamente 8 caracteres): ");
      input = Console.ReadLine();

      if (input == "" || input.Length != 8)
      {
        Console.WriteLine("Por favor ingrese correctamente el ID del producto.");
        Console.Write("");
      }
    } while (input == "" || input.Length != 8);

    return input;
  }
  public static int ingresarStockBebidas()
  {
    string input;
    int stockBebidas = 0;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el stock de las bebidas: ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out stockBebidas);

      if (stockBebidas < 0 || !isNumber || input == "")
      {
        Console.WriteLine("Por favor ingrese un número de stock valido, debe ser de caracter numérico.");
        Console.WriteLine("");
      }
    } while (stockBebidas < 0 || !isNumber || input == "");

    return stockBebidas;
  }
  public static int ingresarStockAlimentos()
  {
    string input;
    int stockAlimentos = 0;
    bool isNumber;

    do
    {
      Console.Write("Ingrese el stock de los alimentos: ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out stockAlimentos);

      if (stockAlimentos < 0 || !isNumber || input == "")
      {
        Console.WriteLine("Por favor ingrese un número de stock valido, debe ser de caracter numérico.");
        Console.WriteLine("");
      }
    } while (stockAlimentos < 0 || !isNumber || input == "");

    return stockAlimentos;
  }
}