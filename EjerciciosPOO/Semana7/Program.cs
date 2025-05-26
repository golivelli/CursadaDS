using System;

class Program
{
  // --- Ejercicio 1 --- 
  // class Vehiculo
  // {
  //   protected string Marca, Modelo;
  //   protected int Anio;

  //   public Vehiculo(string marca, string modelo, int anio)
  //   {
  //     this.Marca = marca;
  //     this.Modelo = modelo;
  //     this.Anio = anio;
  //   }

  //   public void CambiarMarcha()
  //   {
  //     Console.WriteLine("Se cambio de marcha.");
  //   }

  //   public void MostrarInformacion()
  //   {
  //     Console.WriteLine($"Marca: {this.Marca}, Modelo: {this.Modelo}, Año: {this.Anio}.");
  //   }
  // }
  // class Auto : Vehiculo
  // {
  //   protected int CantidadPuertas;
  //   protected bool esAutomatico;

  //   public Auto(string marca, string modelo, int anio, int cantidadPuertas, bool automatico) : base(marca, modelo, anio)
  //   {
  //     this.CantidadPuertas = cantidadPuertas;
  //     this.esAutomatico = automatico;
  //   }
  // }
  // class Camioneta : Vehiculo
  // {
  //   protected int CantidadPuertas;
  //   protected bool es4x4;

  //   public Camioneta(string marca, string modelo, int anio, int cantidadPuertas, bool es4x4) : base(marca, modelo, anio)
  //   {
  //     this.CantidadPuertas = cantidadPuertas;
  //     this.es4x4 = es4x4;
  //   }
  // }
  // class Moto : Vehiculo
  // {
  //   protected string TipoManubrio;

  //   public Moto(string marca, string modelo, int anio, string tipoManubrio) : base(marca, modelo, anio)
  //   {
  //     this.TipoManubrio = tipoManubrio;
  //   }
  // }
  // static void Main(string[] args)
  // {
  //   Auto auto1 = new Auto("Audi", "RS6", 2024, 5, true);
  //   auto1.MostrarInformacion();

  //   Console.WriteLine("");

  //   Camioneta camio1 = new Camioneta("Toyota", "SW4 GR", 2024, 5, true);
  //   camio1.CambiarMarcha();
  //   camio1.MostrarInformacion();

  //   Console.WriteLine("");

  //   Moto moto1 = new Moto("Honda", "XR 200", 2024, "Estandar");
  //   moto1.MostrarInformacion();
  // }

  // --- Ejercicio 2 ---
  // class Persona
  // {
    // protected string Nombre;
    // protected int DNI;
    // private int Edad;
    // public Persona(){}
    // public Persona(string nombre, int edad)
    // {
    //   this.Nombre = nombre;
    //   this.Edad = edad;
    // }
    // public Persona(string nombre, int edad, int dni)
    // {
    //   this.Nombre = nombre;
    //   this.Edad = edad;
    //   this.DNI = dni;
    // }
    // public void MostrarInformacion()
    // {
    //   Console.WriteLine($"Nombre: {this.Nombre}, DNI: {this.DNI}, Edad: {this.Edad}.");
    // }
  // }
  // static void Main(string[] args)
  // {
  //   Persona per1 = new Persona();
  //   per1.MostrarInformacion();

  //   Console.WriteLine("");

  //   Persona per2 = new Persona("Geronimo", 21);
  //   per2.MostrarInformacion();

  //   Console.WriteLine("");

  //   Persona per3 = new Persona("Geronimo", 21, 44941706);
  //   per3.MostrarInformacion();
  // }

  // --- Ejercicio 3 ---
  class Integrante
  {
    protected string Nombre;
    protected int Edad, Antiguedad;

    public Integrante(string nombre, int edad, int antiguedad)
    {
      this.Nombre = nombre;
      this.Edad = edad;
      this.Antiguedad = antiguedad;
    }

    public void sumarAntiguedad(int cantidad)
    {
      if (cantidad >= Antiguedad)
      {
        Console.WriteLine("Incremento de antiguedad");
        this.Antiguedad += cantidad;
      }
    }

    public void sumarAntiguedad(int cantidad, string motivo)
    {
      if (cantidad >= Antiguedad)
      {
        this.Antiguedad += cantidad;
      }
      Console.WriteLine($"Motivo de incremento de antiguedad: {motivo}.");
    }

    public void MostrarInformacion()
    {
      Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Antiguedad: {Antiguedad}.");
    }
  }
  class Jugador : Integrante
  {
    protected string Posicion;

    public Jugador(string nombre, int edad, int antiguedad, string posicion) : base(nombre, edad, antiguedad)
    {
      this.Posicion = posicion;
    }
  }
  class Tecnico : Integrante
  {
    protected string Especialidad;

    public Tecnico(string nombre, int edad, int antiguedad, string especialidad) : base(nombre, edad, antiguedad)
    {
      this.Especialidad = especialidad;
    }
  }
  static void Main(string[] args)
  {
    Jugador jug1 = new Jugador("Geronimo", 21, 5, "Mediocampista");
    jug1.MostrarInformacion();
    jug1.sumarAntiguedad(7);
    jug1.MostrarInformacion();

    Console.WriteLine("");

    Jugador jug2 = new Jugador("Simon", 21, 4, "Delantero");
    jug2.MostrarInformacion();
    jug2.sumarAntiguedad(8, "Buen rendimiento");
    jug2.MostrarInformacion();

    Console.WriteLine("");

    Tecnico tec1 = new Tecnico("Victor", 55, 8, "Entenamientos");
    tec1.MostrarInformacion();
    tec1.sumarAntiguedad(10);
    tec1.MostrarInformacion();

    Console.WriteLine("");

    Tecnico tec2 = new Tecnico("Andrea", 41, 7, "Analista");
    tec2.MostrarInformacion();
    tec2.sumarAntiguedad(11);
    tec2.MostrarInformacion();
  }
}
