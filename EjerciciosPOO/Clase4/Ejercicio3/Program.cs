using System;

class Program {
  public class Animal 
  {
    public string nombre, especie, genero, tipoAlimentacion;
    public int edad;
    public bool esDomestico;

    public Animal(string nombre, string especie, string genero, int edad, string tipoAlimentacion, bool esDomestico)
    {
      this.nombre = nombre;
      this.especie = especie;
      this.genero = genero;
      this.edad = edad;
      this.tipoAlimentacion = tipoAlimentacion;
      this.esDomestico = esDomestico;    
    }

    public void comer()
    {
      Console.WriteLine($"{nombre} esta comiendo.");
    }

    public void dormir()
    {
      Console.WriteLine($"{nombre} esta durmiendo.");
    }

    public void moverse()
    {
      Console.WriteLine($"{nombre} se esta moviendo.");
    }
  }

  public class Volador : Animal 
  {
    public string tipoVuelo, tamanioAlas;
    public bool puedeMigrar;

    public Volador(string nombre, string genero, int edad, string tipoAlimentacion, bool esDomestico, string tipoVuelo, bool puedeMigrar, string tamanioAlas) 
    : base (nombre, "Volador", genero, edad, tipoAlimentacion, esDomestico)
    {
      this.tipoVuelo = tipoVuelo;
      this.puedeMigrar = puedeMigrar;
      this.tamanioAlas = tamanioAlas;
    }

    public void volar()
    {
      Console.WriteLine($"{nombre} esta volando");
    }
  }

  public class Terrestre : Animal
  {
    public string tipoPiel;
    public bool tieneCola;
    public int cantPatas;

    public Terrestre(string nombre, string genero, int edad, string tipoAlimentacion, bool esDomestico, string tipoPiel, bool tieneCola, int cantPatas)
    : base (nombre, "Terreste", genero, edad, tipoAlimentacion, esDomestico)
    {
      this.tipoPiel = tipoPiel;
      this.tieneCola = tieneCola;
      this.cantPatas = cantPatas;    
    }

    public void correr()
    {
      Console.WriteLine($"{nombre} esta corriendo.");
    }
  }

  public class Acuario : Animal 
  {
    public string tipoAgua;
    public bool tieneAletas, puedeRespirarFuera;

    public Acuario(string nombre, string genero, int edad, string tipoAlimentacion, bool esDomestico, string tipoAgua, bool tieneAletas, bool puedeRespirarFuera)
    : base (nombre, "Acuario", genero, edad, tipoAlimentacion, esDomestico)
    {
      this.tipoAgua = tipoAgua;
      this.tieneAletas = tieneAletas;
      this.puedeRespirarFuera = puedeRespirarFuera;
    }

    public void nadar()
    {
      Console.WriteLine($"{nombre} esta nadando.");
    }
  }
  static void Main(string[] args) 
  {
    Volador tucan = new Volador("Flavio", "Masculino", 1, "Frutas", false, "Planeo", false, "Pequeñas");
    Terrestre pandaRojo = new Terrestre("Miranda", "Femenino", 7, "Huevo de Aves con bambú sofrito", false, "Suave", true, 4);
    Terrestre pinguino = new Terrestre("Rico", "Masculino", 17, "De todo", false, "Mucha GRASA", true, 2);
    Acuario pulpoDumbo = new Acuario("LA PEPA", "Femenina", 2, "Gusanos", false, "Salada", true, false);

    Console.WriteLine("");

    tucan.comer();
    tucan.volar();

    Console.WriteLine("");

    pinguino.comer();
  }
}