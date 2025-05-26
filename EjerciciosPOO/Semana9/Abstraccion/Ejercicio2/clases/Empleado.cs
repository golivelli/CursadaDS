using System;

namespace Empl.Jornada
{
	public abstract class Empleado
	{
		public string nombre;
		public int sueldoBase;

		public Empleado(string nombreEmpleado, int sueldoBaseEmpleado)
		{
			this.nombre = nombreEmpleado;
			this.sueldoBase = sueldoBaseEmpleado;
		}
		public abstract void CalcularSueldo();
	} 
}