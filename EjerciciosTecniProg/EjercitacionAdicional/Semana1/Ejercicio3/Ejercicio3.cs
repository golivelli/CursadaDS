// Una maratón tiene 26 millas y 385 yardas. Sabiendo que una milla tiene 1760
// yardas, calcular la distancia de la maratón en yardas.

using System;
namespace Ejercicio3;

class Ejercicio3
{
  static void Main(string[] args)
  {
    int milla, distanciaMaraton, resultado;

    milla = 1760;

    distanciaMaraton = (milla * 26) + 385;
    resultado = distanciaMaraton;
    Console.Write("La distancia de la maratón en yardas es de: " + resultado);
  }
}
