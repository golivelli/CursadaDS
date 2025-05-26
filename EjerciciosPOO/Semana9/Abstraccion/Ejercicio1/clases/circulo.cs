using System;
using Figure.Types;

namespace Figure.Types
{
  class Circulo : Figura
  {
    public double radio;
    public Circulo(double radioC)
    {
      this.radio = radioC;
    }
    public override void CalcularArea()
    {
      area = (Math.PI * (radio * radio));
    }
    public override void MostrarArea()
    {
      Console.WriteLine($"El área del círuclo es: {area} cm²");
    }
  }
}