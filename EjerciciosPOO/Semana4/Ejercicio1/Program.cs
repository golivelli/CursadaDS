using System;

class Program
{
  public class Vehiculo
  {
    public string marca, modelo, tipoVehiculo;
    public int anio, kilometraje, capacidadPasajeros, pasajeros;

    public Vehiculo(string marca, string modelo, string tipoVehiculo, int anio, int kilometraje, int capacidadPasajeros)
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
      Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Tipo Vehiculo: {tipoVehiculo}, Año: {anio}, KM: {kilometraje}, Cant. Pasajeros: {capacidadPasajeros}, Pasajeros: {pasajeros}.");
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
  }

  public class Autobus : Vehiculo
  {
    public string tipoAutobus, rutaAsignada;
    public int cantPuertas;
    public bool tieneBanio;
    public Autobus(string marca, string modelo, int anio, int kilometraje, int capacidadPasajeros, string tipoAutobus, string rutaAsignada, int cantPuertas, bool tieneBanio)
    : base(marca, modelo, "Autobús", anio, kilometraje, capacidadPasajeros)
    {
      this.tipoAutobus = tipoAutobus;
      this.rutaAsignada = rutaAsignada;
      this.cantPuertas = cantPuertas;
      this.tieneBanio = tieneBanio;
    }
  }

  static void Main(string[] args)
  {
    Vehiculo auto = new Vehiculo("Audi", "A5", "Auto", 2008, 55000, 5);

    auto.mostrarInfo();
    Console.WriteLine("");

    for (int i = 0; i <= auto.capacidadPasajeros; i++) 
    {
      auto.subirAlVehiculo();
    }

    Console.WriteLine("");
    auto.mostrarInfo();
    Console.WriteLine("");

    for (int i = auto.capacidadPasajeros; i > 2; i--) 
    {
      auto.descenderDelVehiculo();
    }

    Console.WriteLine("");
    auto.mostrarInfo();
    Console.WriteLine("");

    Autobus bus = new Autobus("Mercedes-Benz", "Sprinter", 2024, 90000, 20, "Urbano", "Bueno Aires", 2, false);

    bus.mostrarInfo();
    Console.WriteLine("");

    for (int i = 0; i <= bus.capacidadPasajeros; i++) 
    {
      bus.subirAlVehiculo();
    }

    Console.WriteLine("");
    bus.mostrarInfo();
    Console.WriteLine("");

    for (int i = bus.capacidadPasajeros; i > 15; i--) 
    {
      bus.descenderDelVehiculo();
    }

    Console.WriteLine("");
    bus.mostrarInfo();
    Console.WriteLine("");
  }
}