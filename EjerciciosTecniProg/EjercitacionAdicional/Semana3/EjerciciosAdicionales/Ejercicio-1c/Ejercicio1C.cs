// Pedir los coeficientes de una ecuación de 2do grado, y muestre sus
// soluciones reales. Si no existen, debe indicarlo.

using System;
namespace Ejercicio1C;

class Ejercicio1C
{
  static void Main(string[] args)
  {
    double x1, x2;
    double a, b, c;
    double determinante;

    Console.Write("Ingrese el valor de la variable de 2do grado: ");
    a = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor de la variable de 1er grado: ");
    b = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor del número independiente: ");
    c = double.Parse(Console.ReadLine());

    determinante = (b * b) - 4 * a * c;

    if (determinante < 0)
    {
      Console.Write("No existen soluciones reales.");
    } else
    {
      double raiz;
      
      raiz = Math.Sqrt(determinante);

      x1 = (- b + raiz) / 2 * a;
      x2 = (- b - raiz) / 2 * a;

      Console.WriteLine("Solución N° 1: " + x1);
      Console.Write("Solución N° 2: " + x2);
    }
  }
}
