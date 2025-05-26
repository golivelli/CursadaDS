// El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra si supero las 20 horas semanales.
using System;
using Empl.Jornada;

namespace Empl.Jornada
{
	class EmpleadoMedioTiempo : Empleado
	{
		public int horasSemanales;

		public EmpleadoMedioTiempo(string nombreEmpleado, int sueldoBaseEmpleado, int horasSem) : base(nombreEmpleado, sueldoBaseEmpleado)
		{
			this.nombre = nombreEmpleado;
			this.sueldoBase = sueldoBaseEmpleado;
			this.horasSemanales = horasSem;
		}
    public override void CalcularSueldo()
    {
      int bono = 4000;
      int sueldoNeto = sueldoBase;

      if (horasSemanales >= 20)
      {
        Console.Write($"Felicidades { this.nombre }!! Completaste el bono semanal de 20 horas.");
        sueldoNeto += bono;

        Console.WriteLine("");

        Console.WriteLine($"Empleado: { this.nombre } - Sueldo neto con bono: ${sueldoNeto}");
      }
      else
      {
        Console.WriteLine($"{ this.nombre } esfuerzate más, tu puedes!! Lamentamos que no hayas podido llegar al bono semanal. Dalo todo la proxima semana!");
        Console.WriteLine($"Empleado: { this.nombre } - Sueldo neto sin bono: ${sueldoBase}");
      }
		}

		public void setHorasSemanales()
		{
			bool isNumber;
			int horasSemanales;
			string input;

			do
			{
				Console.Write("Ingrese la cantidad total de horas semanal trabajadas: ");
				input = Console.ReadLine();

				isNumber = int.TryParse(input, out horasSemanales);

				if (!isNumber || horasSemanales < 0)
				{
					Console.Write("Por favor, ingrese de forma numérica la cant. total de horas semanales trabajadas.");
					Console.WriteLine("");
				}
			} while (!isNumber || horasSemanales < 0);
		}
		public int getHorasSemanales()
		{
			return horasSemanales;
		}
	}
}