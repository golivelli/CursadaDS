using System;
using Figure.Types;

namespace Figure.Types
{
  class Cuadrado : Figura
  {
    public double side;

    public Cuadrado(double sideSquare)
    {
      this.side = sideSquare;
    }

    public override void CalcularArea()
    {
      area = side * side;
    }

    public override void MostrarArea()
    {
      Console.WriteLine($"El área del cuadrado es: {area} cm²");
    }
  }
}