// Definir la clase Empleado, con nombre, apellido, telefono, email, dni y sueldo.
// Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la
// que trabaja de Sistemas, si posee titulo relacionado a su trabajo, si posee una computadora laboral a su cargo y cantidad de gente a cargo.
// Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si es senior, semisenior o junior y la cantidad de veces que tumbó producción.
// Crear un método mostrar información del empleado en la clase Programador donde muestre toda la información requerida.

using System;

class Program{
  class Empleado
  {
    protected string nombre, apellido, email, telefono, dni;
    protected int sueldo;

    public Empleado(string nombre, string apellido, string email, string telefono, string dni, int sueldo)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.email = email;
      this.telefono = telefono;
      this.dni = dni;
      this.sueldo = sueldo;
    }
  }

  class DptoSistemas
  {
    protected string areaDeSistemas;
    protected bool poseeTitulo, poseeComputadora;
    protected int cantGenteACargo;

    public DptoSistemas(string areaDeSistemas, bool poseeTitulo, bool poseeComputadora, int cantGenteACargo)
    {
      this.areaDeSistemas = areaDeSistemas;
      this.poseeTitulo = poseeTitulo;
      this.poseeComputadora = poseeComputadora;
      this.cantGenteACargo = cantGenteACargo;
    }
  }

  class Programador : Empleado
  {
    protected string lenguajeTrabajado, seniority;

    public Programador(string nombre, string apellido, string email, string telefono, string dni, int sueldo, string lenguajeTrabajado, string seniority) : base(nombre, apellido, email, telefono, dni, sueldo)
    {
      this.lenguajeTrabajado = lenguajeTrabajado;
      this.seniority = seniority;
    }

    public void mostrarInfo()
    {
      Console.WriteLine("Información Empleado : Programador");
      Console.WriteLine($"Nombre: {this.nombre}, Apellido: {this.apellido}, Email: {this.email}, Telefono: {this.telefono}, DNI: {this.dni}, Sueldo: {this.sueldo}, Lenguaje de Trabajo: {this.lenguajeTrabajado}, Seniority: {this.seniority}.");
    }
  }

  static void Main(string[] args)
  {
    Programador prog1 = new Programador("Geronimo", "Olivelli", "gero@gmail.com", "3492565946", "44941706", 5000, "C#", "Junior");
    prog1.mostrarInfo();
  }
}