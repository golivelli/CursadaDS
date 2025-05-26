using System;
using Interface.Vehiculo;

public class Moto : IVehiculo 
{
  public string Marca, Modelo;
  public int Anio;

  public Moto(string marca, string modelo, int anio)
  {
    this.Marca = marca;
    this.Modelo = modelo;
    this.Anio = anio;
  }

  public void Conducir()
  {
    Console.WriteLine($"Conduciendo un {this.Marca}.");
  }
}