// Crear la clase Usuario y el método editarForo(nombre foro), donde se debe imprimir por consola "Soy un usuario y edito mi respuesta en el foro {nombre foro}".
// Luego crear la clase hija Administrador y que el método editarForo(nombre foro) imprima "Soy el administrador y puedo configurar el foro completo"

using System;

class Program
{
  class Usuario
  {
    public Usuario() {}
    public virtual void editarForo(string nomForo)
    {
      Console.WriteLine($"Soy un usuario y edito mi respuesta en el foro {nomForo}.");
    }
  }

  class Administrador : Usuario
  {
    public Administrador() : base() {}
    public override void editarForo(string nomForo)
    {
      base.editarForo(nomForo);
      Console.WriteLine($"Soy el administrador y puedo configurar el foro completo.");
    }
  }
  static void Main(string[] args)
  {
    Usuario user1 = new Usuario();
    Administrador adm1 = new Administrador();

    user1.editarForo("Reddit");
    adm1.editarForo("Reddit");
  }
}