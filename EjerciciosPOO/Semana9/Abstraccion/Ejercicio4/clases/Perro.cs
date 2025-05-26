using System;

namespace Ciencias.Naturales
{
  class Perro : Animal
  {
    public string Nombre, Raza;
    public int Edad;

    public Perro(string typeAnimal, string nombre, string raza, int edad) : base(typeAnimal)
    {
      this.TypeAnimal = typeAnimal;
      this.Nombre = nombre;
      this.Raza = raza;
      this.Edad = edad;
    }

    public override void ejecutarSonido()
    {
      Console.WriteLine($"{this.Nombre} esta haciendo su sonido: Guau... Guau..");
    }
    
    public override void mostrarInfo()
    {
      Console.WriteLine($"Nombre: {this.Nombre}, Raza: {this.Raza}, Edad: {this.Edad}");
    }
  }
}