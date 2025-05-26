using System;

namespace Vehicle.Type
{
  public abstract class Vehiculo
  {
    public string TypeVehicle;
    public Vehiculo(string typeVehicle)
    {
      this.TypeVehicle = typeVehicle;
    }
    public abstract void arrancar();
    public void acelerar()
    {
      Console.WriteLine($"{this.TypeVehicle} esta acelarando.");
    }
    public void mostrarTipo()
    {
      Console.WriteLine($"Tipo Vehiculo: {this.TypeVehicle}");
    }
    public virtual void mostrarInfo()
    {
      Console.Write($"Info. Vehiculo -> Tipo: {this.TypeVehicle}");
    }
  }
}