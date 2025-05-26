// Se requiere un programa que nos ayude a calcular el área de un Triangulo, de un Cuadrado y de
// un Circulo y que éstas clases dependan de la clase Figura, la cual debe tener un método que sea
// mostrarArea, donde debe consulte el valor de la variable area y si no es nulo, mostrar por consola el valor.

class Program
{
  abstract class Figura
  {
    protected string tipoFigura;
    protected float? area;

    public Figura(string tipoFigura)
    {
      this.tipoFigura = tipoFigura;
      this.area = null;
    }

    public abstract void calcularArea(); // Método Abstracto
    public void mostrarArea()
    {
      if (area != null)
      {
        Console.WriteLine($"Área del {tipoFigura}: {area} cm²");
      }
      else
      {
        Console.WriteLine("El área no ha sido calculada todavía.");
      }
    }
  }

  class Triangulo : Figura
  {
    private float baseT, alturaT;

    public Triangulo(float baseT, float alturaT) : base("Triángulo")
    {
      this.baseT = baseT;
      this.alturaT = alturaT;
    }

    public override void calcularArea()
    {
      area = (baseT * alturaT) / 2;
    }
  }

  class Cuadrado : Figura
  {
    private float longitudCuadrado;

    public Cuadrado(float longitudCuadrado) : base("Cuadrado")
    {
      this.longitudCuadrado = longitudCuadrado;
    }
    public override void calcularArea()
    {
      area = longitudCuadrado * longitudCuadrado;
    }
  }

  class Circulo : Figura
  {
    private float radioCirculo, piNumber;

    public Circulo(float radioC, float pi) : base("Circulo")
    {
      this.radioCirculo = radioC;
      this.piNumber = pi;
    }
    public override void calcularArea()
    {
      area = piNumber * (radioCirculo * radioCirculo);
    }
  }
  static void Main(string[] args)
  {
    // Triangulo
    float baseTriangulo, alturaTriangulo;

    baseTriangulo = validarBaseT();
    alturaTriangulo = validarAlturaT();

    Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

    Console.Write("¿Desea calcular el área del triángulo? (s/n): ");
    string resT = Console.ReadLine().Trim().ToLower();
    
    while (resT != "s" && resT != "n") {
      Console.Write("Ingrese correctamente los datos solictados (s/n).");
      resT = Console.ReadLine().Trim().ToLower();
    }

    if (resT == "s") {
      triangulo.calcularArea();   
    } 

    triangulo.mostrarArea();

    Console.WriteLine("");

    // Cuadrado
    float longitudCuadrado;
    longitudCuadrado = validarLongitudC();

    Cuadrado cuadrado = new Cuadrado(longitudCuadrado);
    Console.Write("¿Desea calcular el área del triángulo? (s/n): ");
    string resC = Console.ReadLine().Trim().ToLower();

    while (resC != "s" && resC != "n") {
      Console.Write("Ingrese correctamente los datos solictados (s/n).");
      resC = Console.ReadLine().Trim().ToLower();
    }

    if (resC == "s") {
      cuadrado.calcularArea();
    }

    cuadrado.mostrarArea();

    Console.WriteLine("");

    // Ciruculo
    float radioCirculo, pi;
    radioCirculo = validarRadioC();
    pi = 3.14f;

    Circulo circulo = new Circulo(radioCirculo, pi);
    Console.Write("¿Desea calcular el área del triángulo? (s/n): ");
    string res = Console.ReadLine().Trim().ToLower();

    while (res != "s" && res != "n") {
      Console.Write("Ingrese correctamente los datos solictados (s/n).");
      res = Console.ReadLine().Trim().ToLower();
    }

    if (res == "s") {
      circulo.calcularArea();
    }

    circulo.mostrarArea();
  }

  public static float validarRadioC()
  {
    string input;
    float longitudC;
    bool isNumber;

    do
    {
      Console.Write("Ingrese la altura del circulo en cm (centímentros): ");
      input = Console.ReadLine();

      isNumber = float.TryParse(input, out longitudC);

      if (!isNumber || longitudC <= 0 || input == "" || input.Trim() == "")
      {
        Console.Write("Porfavor ingrese un valor valido.");
        Console.WriteLine("");
      }
    } while (!isNumber || longitudC <= 0 || input == "" || input.Trim() == "");

    return longitudC;
  }
  public static float validarLongitudC()
  {
    string input;
    float longitudC;
    bool isNumber;

    do
    {
      Console.Write("Ingrese la altura del cuadrado en cm (centímentros): ");
      input = Console.ReadLine();

      isNumber = float.TryParse(input, out longitudC);

      if (!isNumber || longitudC <= 0 || input == "" || input.Trim() == "")
      {
        Console.Write("Porfavor ingrese un valor valido.");
        Console.WriteLine("");
      }
    } while (!isNumber || longitudC <= 0 || input == "" || input.Trim() == "");

    return longitudC;
  }
  public static float validarAlturaT()
  {
    string input;
    float alturaT;
    bool isNumber;

    do
    {
      Console.Write("Ingrese la altura del triangulo en cm (centímentros): ");
      input = Console.ReadLine();

      isNumber = float.TryParse(input, out alturaT);

      if (!isNumber || alturaT <= 0 || input == "" || input.Trim() == "")
      {
        Console.Write("Porfavor ingrese un valor valido.");
        Console.WriteLine("");
      }
    } while (!isNumber || alturaT <= 0 || input == "" || input.Trim() == "");

    return alturaT;
  }
  public static float validarBaseT()
  {
    string input;
    float baseT;
    bool isNumber;

    do
    {
      Console.Write("Ingrese la base del triangulo en cm (centímentros): ");
      input = Console.ReadLine();

      isNumber = float.TryParse(input, out baseT);

      if (!isNumber || baseT < 0 || input == "" || input.Trim() == "")
      {
        Console.Write("Porfavor ingrese un valor valido.");
        Console.WriteLine("");
      }
    } while (!isNumber || baseT < 0 || input == "" || input.Trim() == "");

    return baseT;
  }
}