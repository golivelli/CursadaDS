// Ingresar la nota de 3 alumnos y mostrar el promedio.

using System;
namespace Ejercicio3;

class Ejercicio3{
  static void Main (string [] args)
  {
    float nota1, nota2, nota3;
    float promedio;

      do
      {
        Console.Write("Ingrese la nota del primer alumno (entre 1 y 10): ");
        nota1 = float.Parse(Console.ReadLine());
      } while (nota1 < 1 || nota1 >= 10);

      do
      {
        Console.Write("Ingrese la nota del segundo alumno (entre 1 y 10): ");
        nota2 = float.Parse(Console.ReadLine());
      } while (nota2 < 1 || nota1 >= 10);
      
      do
      {
        Console.Write("Ingrese la nota del tercer alumno (entre 1 y 10): ");
        nota3 = float.Parse(Console.ReadLine());
      } while (nota3 < 1 || nota3 >= 10);
      
      promedio = (nota1 + nota2 + nota3) / 3;
      Console.WriteLine("El promedio de las notas de los tres alumnos es: " + promedio);
  }
}