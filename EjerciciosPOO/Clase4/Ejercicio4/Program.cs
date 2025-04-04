using System;

class Program {
  public class Libro
  {
    public string titulo, autor, genero, editorial, formato;
    public int anioPub;

    public Libro(string titulo, string autor, string genero, int anioPub, string editorial, string formato)
    {
      this.titulo = titulo;
      this.autor = autor;
      this.genero = genero;
      this.anioPub = anioPub;
      this.editorial = editorial;
      this.formato = formato;
    }
    public void abrirLibro()
    {
      Console.WriteLine("El libro se abrio por el lector");
    }

    public void cerrarLibro()
    {
      Console.WriteLine("El libro fue cerrado por el lector.");
    }

    public void leerLibro()
    {
      Console.WriteLine("asd");
    }
  }

  public class Autor : Libro
  {
    public string nombreAutor, apellidoAutor;
    public Autor(string nombreAutor, string apellidoAutor, string titulo, string genero, int anioPub, string editorial, string formato)
    : base (titulo, nombreAutor + " " + apellidoAutor, genero, anioPub, editorial, formato)
    {
      this.nombreAutor = nombreAutor;
      this.apellidoAutor = apellidoAutor;
    }
  }
  static void Main(string[] args)
  {
    Autor james = new Autor("James", "Clear", "Hábitos Atómicos", "Autoayuda", 2019, "Planeta", "Físico");

    james.abrirLibro();
  }
}