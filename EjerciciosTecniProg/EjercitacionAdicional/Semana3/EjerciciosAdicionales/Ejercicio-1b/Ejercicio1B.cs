// Se necesita un programa que pida el nombre de una persona y que luego lo muestre por la pantalla.

using System;
namespace Ejercicio1B;

class Ejercicio1B
{
  static void Main(string[] args)
  {
    string nombre;

    Console.Write("Ingrese su nombre: ");
    nombre = Console.ReadLine();
    
    while (nombre == "" || nombre == null)
    {
      Console.Write("Por favor, ingrese su nombre: ");
      nombre = Console.ReadLine();
    }

    Console.Write($"Hola {nombre}!!");
  }
}