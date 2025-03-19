// Pedir el radio de una circunferencia y calcular su longitud.

using System;
namespace EjercicioF;

class EjercicioF
{
  static void Main(string[] args)
  {
    double pi, logitud;
    double diametro;

    pi = 3.14;

    Console.Write("Ingrese la logitud de la circunferencia: ");
    logitud = double.Parse(Console.ReadLine());

    while(logitud <= 0)
    {
      Console.Write("La logitud debe ser mayor a 0. Por favor, ingrese nuevamente la logitud de la circunferencia: ");
      logitud = double.Parse(Console.ReadLine());
    }

    diametro = logitud * pi;
    Console.Write("La longitud de la circunferencia es: " + diametro);
  }
}