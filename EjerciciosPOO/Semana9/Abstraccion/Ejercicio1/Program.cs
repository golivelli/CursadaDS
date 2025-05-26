// Crear una clase abstracta Figura con un método abstracto CalcularArea(). 
// Crear las clases Cuadrado, Círculo y Triángulo que hereden de Figura e implementen el método abstracto según su operación para calcular el área.

using System;
using Figure.Types;

namespace Figure.App
{
  class Program
  {
    private static void Main(string[] args)
    {
      // Cuadradro
      Cuadrado cua = new Cuadrado(5);
      cua.CalcularArea();
      cua.MostrarArea();

      Console.WriteLine("");

      // Triángulo
      Triangulo tri = new Triangulo(2, 5);
      tri.CalcularArea();
      tri.MostrarArea();

      Console.WriteLine("");

      // Círculo
      Circulo cir = new Circulo(5); 
      cir.CalcularArea();
      cir.MostrarArea();
    }
  }
}