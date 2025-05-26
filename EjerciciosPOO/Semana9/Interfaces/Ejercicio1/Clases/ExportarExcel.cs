using System;
using Interaface.Exportable;

public class Excel : IExportable
{
  public string TypeArchivo, Contenido;
  public Excel(string typeArchivo, string contenido)
  {
    this.TypeArchivo = typeArchivo;
    this.Contenido = contenido;
  }
  public void Exportar(string Contenido)
  {
    Console.WriteLine($"Exportando archivo Excel...");
    Console.WriteLine(this.Contenido);
  }
}