using System;

namespace Ciencias.Naturales
{
  public abstract class Animal
  {
    public string TypeAnimal;
    public Animal(string typeAnimal)
    {
      this.TypeAnimal = typeAnimal;
    }
    public abstract void ejecutarSonido();

    public virtual void mostrarInfo()
    {
      Console.WriteLine($"Tipo animal: {this.TypeAnimal}");
    }
  }
}