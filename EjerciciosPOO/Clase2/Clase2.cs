using System;
namespace clase2;

class Program {
  public class Persona {
    public string nombre;
    public string apellido;
    public string nacionalidad;
    public int edad;

    public string caminar(){
      string camino = "Estoy caminando...";
      return camino;
    }
    public string sentarse(){
      string sentado = "Estoy sentado...";
      return sentado;
    }
  }
  
  public class Celular {
    public string marca;
    public string modelo;
    public int cantAlmacenamiento;

    public string Encender(){
      string encenderCelular = "Prendiendo celular...";
      return encenderCelular;
    }

    public string Apagar(){
      string apagarCelular = "Apagando celular...";
      return apagarCelular;
    }
  }
  static void Main (string[] args) {
    string modelo, marca, input;
    int cantAlmacenamiento;
    string caminar, sentarse;
    string apagar, prender;
    bool isNumber;

    Persona persona1 = new Persona();
    Celular celular1 = new Celular();

    // CARGA DE DATOS
    persona1.nombre = "Geronimo";
    persona1.apellido = "Olivelli";
    persona1.edad = 21;
    persona1.nacionalidad = "Argentina";

    do{
      Console.Write("Ingrese la marca de su celular: ");
      marca = Console.ReadLine();

      isNumber = int.TryParse(marca, out _);

      if (isNumber || marca == "") {
        Console.WriteLine("Por favor ingrese un valor valido. Debe ser de tipo texto.");
      }
    } while (isNumber || marca == "");

    do{
      Console.Write("Ingrese el modelo de su celular: ");
      modelo = Console.ReadLine();

      isNumber = int.TryParse(modelo, out _);

      if (isNumber || modelo == "") {
        Console.WriteLine("Por favor ingrese un valor valido. Debe ser de tipo texto.");
      }
    } while (isNumber || modelo == "");

    do{
      Console.Write("Ingrese la cantidad de almacenamiento en GB de su celular (Ingrese el dato de forma numérica): ");
      input = Console.ReadLine();

      isNumber = int.TryParse(input, out cantAlmacenamiento);

      if (!isNumber || cantAlmacenamiento <= 0) {
        Console.WriteLine("Por favor ingrese un valor valido. Debe ser de tipo numérico.");
      }
    } while (!isNumber || cantAlmacenamiento <= 0);

    celular1.marca = marca;
    celular1.modelo = modelo;
    celular1.cantAlmacenamiento = cantAlmacenamiento;

    Console.WriteLine("");

    // LLAMADO DE ACCIONES
    caminar = persona1.caminar();
    sentarse = persona1.sentarse();

    apagar = celular1.Apagar();
    prender = celular1.Encender();

    // IMPRIMIR RESULTADOS
    Console.WriteLine("Impresión de los datos Persona:");
    Console.WriteLine($"Nombre: {persona1.nombre}, Apellido: {persona1.apellido}, Edad: {persona1.edad}, Nacionalidad: {persona1.nacionalidad}.");
    Console.WriteLine("Acciones de Persona:");
    Console.WriteLine(caminar);
    Console.WriteLine(sentarse);

    Console.WriteLine("");

    Console.WriteLine("Impresión de los datos Celular:");
    Console.WriteLine($"Marca: {celular1.marca}, Modelo: {celular1.modelo}, Cant. Almacenamiento: {celular1.cantAlmacenamiento}.");
    Console.WriteLine("Acciones de Celular:");
    Console.WriteLine(apagar);
    Console.WriteLine(prender);
  }
}
