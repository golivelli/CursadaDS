// Se ingresan Número de documento, edad, y sexo (F o M) de un conjunto de
// personas. Este conjunto de datos finaliza al ingresar el Número de documento 0 (inexistente). 
// Se pide:
//  a. ¿Cuántas personas tienen más de 40 años?
//  b. Cantidad de hombres y cantidad de mujeres.
//  c. Promedio de edades.

using System;
namespace Ejercicio4;

class Ejercicio4 
{
  static void Main(string[] args)
  {
    char genero;
    int dni, edad, sumaEdades, totPersonas;
    int mas40, cantH, cantM;

    do
    {
      Console.Write("Ingrese su DNI, si desea finalizar ingrese 0: ");
      dni = Console.ReadLine();

      if (dni != 0)
      {
        Console.Write("Ingrese su edad:");
        edad = int.Parse(Conosle.ReadLine());

        while (edad <= 0)
        {
          Console.Write("La edad debe ser mayor a 0, ingrese nuevamente:");
          edad = int.Parse(Conosle.ReadLine());
        }

        if (edad > 40)
        {
          mas40++;
        }

        Console.Write("Ingrese su genero (F/M):");
        genero = char.toUpper(Conosle.ReadLine());

        while (genero != "F" || genero != "M")
        {
          Console.Write("Por favor, ingrese un genero valido (F/M):");
          genero = char.toLower(Conosle.ReadLine());
        }

        if (genero == "F")
        {
          cantF++;
        } 
        else if (genero == "M")
        {
          cantM++;
        }

        sumaEdades += edad;
        totPersonas++;
      }
    } while (dni != 0)

    Console.WriteLine($"\nPersonas con más de 40 años: {mas40}");
    Console.WriteLine($"Cantidad de hombres: {cantM}");
    Console.WriteLine($"Cantidad de mujeres: {cantF}");

    if(totPersonas > 0)
    {
      double promEdades;
      
      promEdades = sumaEdades / totPersonas;
      Console.Write("El promedio todas las edades es: " + promEdades);
    } else 
    {
      Console.Write("No se ingresaron datos.");
    }
  }
}