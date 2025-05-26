using System;
using Vehicle.Type;

namespace Vehicle.Type
{
  class Auto : Vehiculo
  {
    public string Marca, Modelo;
    public int Anio;

    public Auto(string typeVehicle, string marca, string modelo, int anio) : base(typeVehicle)
    {
      this.TypeVehicle = typeVehicle;
      this.Marca = marca;
      this.Modelo = modelo;
      this.Anio = anio;
    }

    public override void arrancar()
    {
      Console.Write($"{this.Marca}, {this.Modelo} esta arrancado su motor.");
      Console.WriteLine("");
    }

    public override void mostrarInfo()
    {
      Console.Write($"Info. Vehiculo -> Tipo: {this.TypeVehicle}, Marca: {this.Marca}, Modelo: {this.Modelo}, Año: {this.Anio}");
      Console.WriteLine("");
    }
  }
}