using System;
using Interaface.Exportable;

public class PDF : IExportable
{
  public string TypeArchivo, Contenido;

  public PDF(string typeArchivo, string contenido)
  {
    this.TypeArchivo = typeArchivo;
    this.Contenido = contenido;
  }

  public void Exportar(string Contenido)
  {
    Console.WriteLine($"Exportando archivo PDF...");
    Console.WriteLine(this.Contenido);
  }
}