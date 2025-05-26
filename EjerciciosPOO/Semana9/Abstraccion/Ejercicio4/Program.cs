// Nos encontramos trabajando en el  Museo Argentino de Ciencias Naturales "Bernardino Rivadavia" y nos solicitaron un desarrollo para almacenar el sonido de diversos animales.
// Ayuda: Deberíamos tener en el Main un arreglo de animales y ejecutar un método que tengan todos en común para escuchar los diversos sonidos catalogados por los científicos.

using System;
using Ciencias.Naturales;

class Program
{
  private static void Main(string[] args)
  {
    Animal[] animales = new Animal[2];
    animales[0] = new Perro("Perro", "Luz", "Boxer", 3);
    animales[1] = new Gato("Gato", "Ades", "Maine Coon", 2);

    foreach (Animal a in animales)
    {
      a.ejecutarSonido();
      Console.WriteLine("");
    }
  }
}
