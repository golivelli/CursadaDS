// Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y
// “Produccion” que posea un método que sea verificarDespliegue y comprobar que la información
// del Ambiente sea igual a: “sistema_operativo: linux, ram:4, base_datos: postgresql, app: openjdk”,
// si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que no será posible realizar el despliegue.

using System;

class Program
{
  public class Ambiente
  {
    public string nombre, sistemaOperativo, baseDeDatos, app;
    public int ram;

    public Ambiente(string nombre, string sistemaOperativo, int ram, string baseDeDatos, string app)
    {
      this.nombre = nombre;
      this.sistemaOperativo = sistemaOperativo;
      this.ram = ram;
      this.baseDeDatos = baseDeDatos;
      this.app = app;
    }

    public void VerificarDespliegue()
    {
      if (sistemaOperativo.ToLower() == "linux" && ram == 4 && baseDeDatos.ToLower() == "postgresql" && app.ToLower() == "openjdk")
      {
        Console.WriteLine($"[{nombre}] El despliegue se puede realizar.");
      }
      else
      {
        Console.WriteLine($"[{nombre}] No será posible realizar el despliegue.");
      }
    }
  }

  static void Main(string[] args)
  {
    Ambiente desarrollo = new Ambiente("Desarrollo", "linux", 4, "postgresql", "openjdk");
    Ambiente testing = new Ambiente("Testing", "linux", 2, "mysql", "openjdk");
    Ambiente preproduccion = new Ambiente("Preproduccion", "Linux", 4, "postgresql", "openjdk");
    Ambiente produccion = new Ambiente("Produccion", "LINUX", 4, "PostgreSQL", "OpenJDK");

    desarrollo.VerificarDespliegue();
    testing.VerificarDespliegue();
    preproduccion.VerificarDespliegue();
    produccion.VerificarDespliegue();
  }
}