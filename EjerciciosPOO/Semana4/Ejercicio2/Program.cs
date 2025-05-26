using System;

class Program
{
  public class Vehiculo
  {
    public string marca, modelo, tipoVehiculo;
    public int anio, numSerie, kilometraje, capacidadPasajeros, pasajeros;

    public Vehiculo(string marca, string modelo, string tipoVehiculo, int anio, int numSerie, int kilometraje, int capacidadPasajeros)
    {
      this.marca = marca;
      this.modelo = modelo;
      this.tipoVehiculo = tipoVehiculo;
      this.anio = anio;
      this.kilometraje = kilometraje;
      this.capacidadPasajeros = capacidadPasajeros;
      this.pasajeros = 0;
    }

    public void mostrarInfo()
    {
      Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Tipo Vehiculo: {tipoVehiculo}, Año: {anio}, N° Serie: {numSerie} KM: {kilometraje}, Cant. Pasajeros: {capacidadPasajeros}, Pasajeros: {pasajeros}.");
    }

    public void subirAlVehiculo()
    {
      if (pasajeros < capacidadPasajeros)
      {
        pasajeros++;
        Console.WriteLine($"Alguien ha subido al {tipoVehiculo}.");
      }
      else
      {
        Console.WriteLine($"El {tipoVehiculo} está lleno.");
      }
    }

    public void descenderDelVehiculo()
    {
      if (pasajeros > 0)
      {
        pasajeros--;
        Console.WriteLine($"Alguien ha descendido del {tipoVehiculo}.");
      }
      else
      {
        Console.WriteLine($"No hay pasajeros en el {tipoVehiculo}.");
      }
    }

    public void arrancarVehiculo()
    {
      Console.WriteLine($"El {tipoVehiculo} arranco el motor.");
    }

    public void detenerVehiculo()
    {
      Console.WriteLine($"El {tipoVehiculo} detuvo el motor.");
    }

    public void acelerarVehiculo()
    {
      Console.WriteLine($"El {tipoVehiculo} esta acelarando.");
    }

    public void frenarVehiculo()
    {
      Console.WriteLine($"El {tipoVehiculo} esta frenando.");
    }

    public void cagarNafta()
    {
      Console.WriteLine($"El {tipoVehiculo} esta cargando nafta.");
    }
  }

  public class Autobus : Vehiculo
  {
    public string tipoAutobus, rutaAsignada;
    public int cantPuertas;
    public bool tieneBanio;
    public Autobus(string marca, string modelo, int anio, int numSerie, int kilometraje, int capacidadPasajeros, string tipoAutobus, string rutaAsignada, int cantPuertas, bool tieneBanio)
    : base(marca, modelo, "autobus", anio, numSerie, kilometraje, capacidadPasajeros)
    {
      this.tipoAutobus = tipoAutobus;
      this.rutaAsignada = rutaAsignada;
      this.cantPuertas = cantPuertas;
      this.tieneBanio = tieneBanio;
    }
  }

  public class Moto : Vehiculo
  {
    public int cantRuedas;
    public string tipoMoto, cilindradad;
    public bool tieneBaul;

    public Moto(string marca, string modelo, int anio, int numSerie, int kilometraje, int capacidadPasajeros)
    : base(marca, modelo, "moto", anio, numSerie, kilometraje, capacidadPasajeros)
    {
      this.cantRuedas = cantRuedas;
      this.tipoMoto = tipoMoto;
      this.cilindradad = cilindradad;
      this.tieneBaul = tieneBaul;
    }
  }

  public class Auto : Vehiculo 
  {
    public int cantPuertas, capacidadBaul;
    public string tipoAuto, traccion;

    public Auto (string marca, string modelo, int anio, int numSerie, int kilometraje, int capacidadPasajeros)
    : base(marca, modelo, "auto", anio, numSerie, kilometraje, capacidadPasajeros)
    {
      this.cantPuertas = cantPuertas;
      this.tipoAuto = tipoAuto;
      this.capacidadBaul = capacidadBaul;
      this.traccion = traccion;
    }
  }

  static void Main(string[] args)
  {
    Autobus bus = new Autobus("Mercedes-Benz", "Sprinter", 2024, 90323232, 90000, 20, "Urbano", "Bueno Aires", 2, false);
    Moto moto = new Moto("Yamaha", "FZ", 2023, 65843230, 2000, 2);
    Auto auto = new Auto("Audi", "A5", 2008, 4320492, 10000, 5);
    Console.WriteLine("");

    auto.subirAlVehiculo();
    auto.arrancarVehiculo();
    auto.acelerarVehiculo();
    auto.frenarVehiculo();
    auto.detenerVehiculo();
    auto.cagarNafta();

    Console.WriteLine("");
    auto.mostrarInfo();
  }
}