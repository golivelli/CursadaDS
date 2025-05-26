using System;
using Interaface.Exportable;

public class CSV : IExportable
{
  public string TypeArchivo, Contenido;

  public CSV(string typeArchivo, string contenido)
  {
    this.TypeArchivo = typeArchivo;
    this.Contenido = contenido;
  }

  public void Exportar(string Contenido)
  {
    Console.WriteLine($"Exportando archivo CSV...");
    Console.WriteLine(this.Contenido);
  }
}