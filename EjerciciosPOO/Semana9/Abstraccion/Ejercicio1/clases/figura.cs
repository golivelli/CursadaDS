using System;

namespace Figure.Types
{
  public abstract class Figura
  {
    protected double area;
    public virtual void MostrarArea()
    {
      if (area < 0)
      {
        Console.WriteLine($"El área no se ha calculado.");
      }
      else
      {
        Console.WriteLine($"El área es: {area} cm²");
      }
    }
    public abstract void CalcularArea();
  }
}