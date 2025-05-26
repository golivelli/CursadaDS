// Crear una clase abstracta Empleado con los atributos Nombre, SueldoBase, y un método abstracto CalcularSueldo(). 
// Se debe crear las clases hijas EmpleadoTiempoCompleto y EmpleadoMedioTiempo.
// El empleado de tiempo completo calcula su sueldo según su sueldo base + bono de presentismo.
// El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra si supero las 20 horas semanales.

using System;
using Empl.Jornada;

class Program
{
  private static void Main(string[] args)
  {
    // Empleado Medio Tiempo
    EmpleadoMedioTiempo emMT = new EmpleadoMedioTiempo("Geronimo", 10000, 24);
    emMT.CalcularSueldo();

    Console.WriteLine("");

    EmpleadoMedioTiempo emMT1 = new EmpleadoMedioTiempo("Lucas", 10000, 14);
    emMT1.CalcularSueldo();

    Console.WriteLine("");

    // Empleado Tiempo Completo
    EmpleadoTiempoCompleto emCP = new EmpleadoTiempoCompleto("Joaquin", 12000, true);
    emCP.CalcularSueldo();

    Console.WriteLine("");

    EmpleadoTiempoCompleto emCP1 = new EmpleadoTiempoCompleto("Nicolas", 12000, false);
    emCP1.CalcularSueldo();
  }
}