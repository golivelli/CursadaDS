// Crear una clase padre Persona con el método presentarse() que imprima por consola "Hola, mi nombre es {nombre atributo}".
// Luego crear la clase hija Alumno y sobreescribir la clase padre Persona haciendo que ejecuta su funcionalidad inicial y agregar extra " 
// y soy alumno del instituo {instituto atributo}".

using System;

class Program
{
  class Persona
  {
    public string Nombre, Apellido;
    public Persona(string n, string a)
    {
      this.Nombre = n;
      this.Apellido = a;
    }

    public virtual void presentarse()
    {
      Console.WriteLine($"Hola, mi nombre es {this.Nombre} y mi apellido {this.Apellido}.");
    }
  }

  class Alumno : Persona
  {
    public string nombreInstituto;

    public Alumno(string n, string a, string nInstituto) : base(n, a)
    {
      this.nombreInstituto = nInstituto;
    }

    public override void presentarse()
    {
      base.presentarse(); // Llama al método original. 
      Console.WriteLine($"Hola, mi nombre es {this.Nombre} y mi apellido {this.Apellido}. Soy alumno del instituto {this.nombreInstituto}.");
    }
  }
  static void Main(string[] args)
  {
    Alumno alm1 = new Alumno("Geronimo", "Olivelli", "IFTS N° 11");

    Persona prs1 = new Persona("Geronimo", "Olivelli");

    alm1.presentarse();

    prs1.presentarse();
  }
}