// Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

// Inicializar una clase Persona con atributos nombre, edad y dni.
// Crear un constructor sin parámetros que inicialice con valores por defecto.
// Inicializar la clase Persona con solo el nombre.
// Crear un constructor que reciba todos los atributos.

// Crear un método mostrarDatos() que imprima los atributos.

// Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).

using System;

class Program
{
  class Persona {
    public string nombre;
    public int dni;
    private int edad;

    public Persona(){
      this.nombre = "Sin nombre";
      this.dni = 0;
      this.edad = 0;
    }

    public Persona(string nombre){
      this.nombre = nombre;
      this.dni = 0;
      this.edad = 0;
    }

    public Persona(string nombre, int edad, int dni){
      this.nombre = nombre;
      this.edad = edad;
      this.dni = dni;
    }

    public void setEdad(int e){
      if (e > 0) {
        edad = e
      } else {
        Console.WriteLine("Edad no valida. Por favor, ingrese una edad correcta.");
      }
    }

    public int getEdad(){
      return edad;
    }

    public void mostrarDatos(){
      Console.WriteLine("-- IMPRESIÓN DE DATOS --");
      Console.WriteLine($"Nombre: {this.nombre}, Edad: {this.edad}, DNI: {this.dni}");
    }
  }
  static void Main(string[] args) {
    Persona persona1 = new Persona();
    Persona persona2 = new Persona("Gerónimo");
    Persona persona3 = new Persona("Gerónimo", 21, 44941706);

    persona1.nombre = "Andrea";
    persona1.dni = 22715470;
    persona1.setEdad(47);
    persona1.getEdad();
    persona1.mostrarDatos();

    persona2.mostrarDatos();
    persona3.mostrarDatos();
  }
}