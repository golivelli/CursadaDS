// CREAR NUEVO PROYECTO: dotnet new console --name Clase1
using System;
namespace clase1;

class Program {
  public class Persona {
    // PROPIEDADES
    public string nombre = "";
    public string apellido = "";
    public string nacionalidad = "";
    public int edad;

    // MÉTODOS
    public string caminar(){
      string camino = "Estoy caminando.";
      return camino;
    }
    public string sentarse(){
      string sentado = "Estoy sentado";
      return sentado;
    }
    public string comer(){
      string como = "Estoy comiendo";
      return como;
    }
    public string entrenar(){
      string entreno = "Estoy entrenando";
      return entreno;
    }
  }
  static void Main (string[] args) {
    string caminar, sentarse, comer, entrenar;
    Persona persona1 = new Persona(); // Crea una instancia de Persona()

    // CARGA DE DATOS
    persona1.nombre = "Geronimo";
    persona1.apellido = "Olivelli";
    persona1.edad = 21;
    persona1.nacionalidad = "Argentina"; 

    // LLAMADO DE ACCIONES
    caminar = persona1.caminar();
    sentarse = persona1.sentarse();
    comer = persona1.comer();
    entrenar = persona1.entrenar();

    // IMPRIMIR RESULTADOS
    Console.WriteLine($"Nombre: {persona1.nombre}, Apellido: {persona1.apellido}, Edad: {persona1.edad}, Nacionalidad: {persona1.nacionalidad}.");
    Console.WriteLine(caminar);
    Console.WriteLine(sentarse);
    Console.WriteLine(comer);
    Console.WriteLine(entrenar);
  }
}
