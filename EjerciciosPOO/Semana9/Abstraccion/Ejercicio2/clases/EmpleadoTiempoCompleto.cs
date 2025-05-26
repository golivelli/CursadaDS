// El empleado de tiempo completo calcula su sueldo según su sueldo base + bono de presentismo.
using System;
using Empl.Jornada;

namespace Empl.Jornada
{
  class EmpleadoTiempoCompleto : Empleado
  {
    private bool tuvoAsistenciaPerfecta;

    public EmpleadoTiempoCompleto(string nombre, int sueldoBase, bool asistenciaPerfecta) : base(nombre, sueldoBase)
    {
      this.tuvoAsistenciaPerfecta = asistenciaPerfecta;
    }

    public override void CalcularSueldo()
    {
      int presentismo = 8000;
      int sueldoFinal = sueldoBase;

      if (tuvoAsistenciaPerfecta)
      {
        Console.Write($"Felicidades { this.nombre }!! Completaste el bono de presentismo.");
        sueldoFinal += presentismo;

        Console.WriteLine("");

        Console.WriteLine($"Empleado: { this.nombre } - Sueldo con presentismo: ${sueldoFinal}");
      }
      else
      {
        Console.WriteLine($"{ this.nombre } esfuerzate más, tu puedes!! Lamentamos que no hayas podido llegar al bono de presentismo. Dalo todo le proximo año!");
        Console.WriteLine($"Empleado: { this.nombre } - Sueldo sin presentismo: ${sueldoBase}");
      }
    }
  }
}
