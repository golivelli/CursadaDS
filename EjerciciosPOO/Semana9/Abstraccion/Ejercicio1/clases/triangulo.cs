using System;
using Figure.Types;

namespace Figure.Types
{
  class Triangulo : Figura
  {
    public double baseT, heightT;

    public Triangulo(double baseTR, double heightTR)
    {
      this.baseT = baseTR;
      this.heightT = heightTR;
    }

    public override void CalcularArea()
    {
      area = (baseT * heightT) / 2;
    }

    public override void MostrarArea()
    {
      Console.WriteLine($"El área del triángulo es: {area} cm²");
    }
  }
}