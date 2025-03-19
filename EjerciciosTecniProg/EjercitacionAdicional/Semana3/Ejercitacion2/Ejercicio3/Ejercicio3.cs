// Se ingresa un valor correspondiente a la altura en centímetros de 20
// estudiantes. Calcular e informar el promedio de altura de los que miden
// menos de 160 cm y el promedio de altura de los restantes.

using System;
namespace Ejercicio3;

class Ejercicio3
{
  static void Main(string[] args)
  {
    int altura, cantEstudiantes;
    int sumAlt, sumAltMenor160;
    int totAlturasMenor160, totAlturas;

    cantEstudiantes = 4; // 20
    sumAlt = 0;
    sumAltMenor160 = 0;
    totAlturas = 0;
    totAlturasMenor160 = 0;

    for (int i = 1; i <= cantEstudiantes; i++)
    {
      Console.Write($"Ingrese la altura (en centimetros) del estudiante N° {i}: ");
      altura = int.Parse(Console.ReadLine());

      while (altura <= 0)
      {
        Console.Write($"La altura (en centimetros) del estudiante N° {i}, debe ser mayor a 0. Por favor, ingrese nuevamente: ");
        altura = int.Parse(Console.ReadLine());
      }

      if (altura < 160)
      {
        sumAltMenor160 += altura;
        totAlturasMenor160++;
      } else 
      {
        sumAlt += altura;
        totAlturas++;
      }
    }

    if (totAlturas > 0)
    {
      double promMenor160, promMayor160;

      promMenor160 = sumAltMenor160 / totAlturasMenor160;
      promMayor160 = sumAlt / totAlturas;

      Console.WriteLine("Promedio de los estudiantes con una altura menor a 160cm: " + promMenor160 + "cm.");
      Console.WriteLine("Promedio de los estudiantes con una altura mayor a 160cm: " + promMayor160 + "cm.");
    } else 
    {
      Console.Write("No se ingresaron datos.");
    }
  }
}