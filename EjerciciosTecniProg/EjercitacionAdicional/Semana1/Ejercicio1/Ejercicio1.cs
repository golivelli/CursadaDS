// Dadas las horas mensuales trabajadas de un empleado y el valor en pesos
// de cada hora, calcular el sueldo que se abonará al finalizar el mes.

using System;
namespace Ejercicio1;

class Ejercicio1
{
    static void Main(string[] args)
    {
        int horasTrabajadas;
        int precioPorHora;
        int sueldoFinal;

        Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el monto por hora: ");
        precioPorHora = int.Parse(Console.ReadLine());

        while (horasTrabajadas <= 0 || precioPorHora <= 0)
        {
          Console.WriteLine("La cantidad de horas trabajas debe ser mayor a 0. Por favor, ingrese las horas trabajas: ");
          horasTrabajadas = int.Parse(Console.ReadLine());

          Console.WriteLine("El precio por hora de debe ser mayor a 0. Por favor, ingrese las el monto por hora: ");
          precioPorHora = int.Parse(Console.ReadLine());
        }

        sueldoFinal = precioPorHora * horasTrabajadas;
        Console.WriteLine("El sueldo a abonar es de: $" + sueldoFinal);
    }
}
