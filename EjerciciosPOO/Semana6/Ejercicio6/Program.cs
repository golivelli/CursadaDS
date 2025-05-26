// Crear la clase Persona, con un método que compare la edad de una persona con otra.
// (Se deben crear dos objetos de la clase persona, y ejecutar el método compararEdad en persona2,
// pasando como parámetro la edad de persona1).

using System;

class Program
{
  public class Persona
  {
    protected string nombre;
    public int edad;

    public Persona(string nombre, int edad)
    {
      this.nombre = nombre;
      this.edad = edad;
    }

    public void CompararEdad(int otraEdad)
    {
      if (edad > otraEdad)
      {
        Console.WriteLine($"{nombre} es mayor.");
      }
      else if (edad < otraEdad)
      {
        Console.WriteLine($"{nombre} es menor.");
      }
      else
      {
        Console.WriteLine($"{nombre} tiene la misma edad.");
      }
    }
  }

  static void Main(string[] args)
  {
    Persona persona1 = new Persona("Geronimo", 21);
    Persona persona2 = new Persona("Simon", 21);

    persona2.CompararEdad(persona1.edad);
  }
}