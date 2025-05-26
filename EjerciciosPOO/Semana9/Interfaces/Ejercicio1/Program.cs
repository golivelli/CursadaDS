// Nos encontramos desarrollando una aplicación para administrar, recopilar y procesar información para un set de datos de personas que fueron encuestadas 
// con la finalidad de ofrecer una segmentación del mercado. 

// Se nos requiere que la información se pueda descargar en Excel, PDF y CSV.

// Por lo que se nos ocurre una idea para manejar todos los tipos de Exportables como una sola clase, por lo que creamos la Interfaz IExportable con método Exportar(string contenido) y
// se la aplicamos a las clases ExportarExcel, ExportarPDF y ExportarCSV.

// Nuestro main debería permitirnos instanciar cualquier tipo de clase que implemente la interfaz y ejecutar el método exportar().
// Código de ejemplo del main:
using System;
using Interaface.Exportable;

class Program
{
  private static void Main(string[] args)
  {
    string contenido = "Este es el informe de las personas encuestadas.";
    
    IExportable[] exportadores = new IExportable[3];
    exportadores[0] = new Excel("Excel", contenido);
    exportadores[1] = new PDF("PDF", contenido);
    exportadores[2] = new CSV("CSV", contenido);

    foreach (IExportable exportador in exportadores)
    {
      exportador.Exportar(contenido);
      Console.WriteLine("");
    }
  }
}