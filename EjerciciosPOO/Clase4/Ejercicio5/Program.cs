using System;

class Program
{
  class Biblioteca
  {
    public string nombre, ubicacion, horarioApertura, horarioCierre, telefono;
    public int cantLibros;
    public Autor[] autores;
    public Libro[] libros;

    public Biblioteca(string nombre, string ubicacion, string horarioApertura, string horarioCierre, string telefono, int cantLibros, Autor[] autores, Libro[] libros)
    {
      this.nombre = nombre;
      this.ubicacion = ubicacion;
      this.horarioApertura = horarioApertura;
      this.horarioCierre = horarioCierre;
      this.telefono = telefono;
      this.cantLibros = cantLibros;
      this.autores = autores;
      this.libros = libros;
    }

    public void agregarLibroBiblioteca()
    {
      cantLibros++;
      Console.WriteLine("Se agregro un libro a la biblioteca.");
    }

    public void prestarLibro()
    {
      cantLibros--;
      Console.WriteLine("Se presto un libro.");
    }

    public void devolverLibro()
    {
      cantLibros++;
      Console.WriteLine("Se devolvio un libro a la biblioteca.");
    }

    public void buscarLibroTitulo(Libro[] libros)
    {
      Console.Write("Ingrese el título del libro a buscar: ");
      string tituloBuscado = Console.ReadLine();

      bool encontrado = false;

      foreach (Libro libro in libros)
      {
        if (libro != null && libro.Titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine("Libro encontrado:");
          Console.WriteLine($"Título: {libro.titulo}");
          Console.WriteLine($"Autor: {libro.autor}");
          Console.WriteLine($"Género: {libro.genero}");
          Console.WriteLine($"Año de publicación: {libro.anioPub}");
          Console.WriteLine($"Editorial: {libro.editorial}");
          Console.WriteLine($"Formato: {libro.formato}");
          encontrado = true;
          break;
        }
      }

      if (!encontrado)
      {
          Console.WriteLine("Libro no encontrado.");
      }
    }

    public void buscarLibroAutor(Autor[] autores)
    {
      Console.Write("Ingrese el autor del libro a buscar: ");
      string autorBuscado = Console.ReadLine();

      bool encontrado = false;

      foreach (Autor autor in autors)
      {
        if (autor != null && autor.nombreAutor.Equals(autorBuscado, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Autor encontrado:");
            Console.WriteLine($"Nombre: {autor.nombreAutor}");
            Console.WriteLine($"Apellido: {autor.apellidoAutor}");
            encontrado = true;
            break;
        }
      }

      if (!encontrado)
      {
          Console.WriteLine("Autor no encontrado.");
      }
    }
  }

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
    Biblioteca biblio = new Biblioteca("La biblio de Gero", "LA MATANZA", "9:30hs", "20:30hs", "+111234567", 100, Autor[], Libro[]);
    Libro libro1 = new Libro("Habitos Atomicos", "James Clear", "Autoayuda", 2019, "Palacio", "Digital");
    Autor autor1 = new Autor("James", "Clear", "Habitos Atomicos", "Autoayuda", 2019, "Palacio", "Digital");

    libro1.push(Libro[]);
    autor1.push(Autor[]);

    Console.WriteLine(Libro[]);
    Console.WriteLine(Autor[]);
  }
}
