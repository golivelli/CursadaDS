// Una empresa comercializa 3 productos y desea saber cuál es de mayor
// porcentaje de ventas. Para esto debe ingresar el total recaudado por cada
// producto y el valor de cada uno. Debe informar la cantidad vendida de cada
// producto, su total de ventas y el porcentaje que dicha cantidad de ventas
// significa del total.

using System;
namespace Ejercicio4;

class Ejercicio4
{
  static void Main(string[] args)
  {
    // DECLARACIÓN DE VARIABLES
    float prod1, prod2, prod3;
    float totRecaudado1, totRecaudado2, totRecaudado3, totVendido;
    float cantVendidoProd1, cantVendidoProd2, cantVendidoProd3;
    float porcentaje1, porcentaje2, porcentaje3;

    
    do
    {
      // VALOR DE CADA PRODUCTO
      Console.Write("Ingrese el valor del primer producto: ");
      prod1 = float.Parse(Console.ReadLine());

      Console.Write("Ingrese el valor del segundo producto: ");
      prod2 = float.Parse(Console.ReadLine());

      Console.Write("Ingrese el valor del tercer producto: ");
      prod3 = float.Parse(Console.ReadLine());

      // TOTAL RECAUDACIÓN DE CADA PRODUCTO 
      Console.Write("Ingrese el total recaudado del producto 1: ");
      totRecaudado1 = float.Parse(Console.ReadLine());

      Console.Write("Ingrese el total recaudado del producto 2: ");
      totRecaudado2 = float.Parse(Console.ReadLine());

      Console.Write("Ingrese el total recaudado del producto 3: ");
      totRecaudado3 = float.Parse(Console.ReadLine());

      if(prod1 <= 0 || prod2 <= 0 || prod3 <= 0 || totRecaudado1 < 0 || totRecaudado2 < 0 || totRecaudado3 < 0)
      {
        Console.Write("Los productos deben tener un precio mayor que 0 y las recaudaciones no pueden ser negativas. Por favor, ingrese nuevamente.");
      }
    } (prod1 <= 0 || prod2 <= 0 || prod3 <= 0 || totRecaudado1 < 0 || totRecaudado2 < 0 || totRecaudado3 < 0);

    // TOTAL VENTAS
    totVendido = totRecaudado1 + totRecaudado2 + totRecaudado3;

    // CANTIDAD VENDIDA DE CADA PRODUCTO
    cantVendidoProd1 = totRecaudado1 / prod1;
    cantVendidoProd2 = totRecaudado2 / prod2;
    cantVendidoProd3 = totRecaudado3 / prod3;

    // PORCENTAJE DE VENTAS PRODUCTO 1
    porcentaje1 = (totRecaudado1 / totVendido) * 100;

    // PORCENTAJE DE VENTAS PRODUCTO 2
    porcentaje2 = (totRecaudado2 / totVendido) * 100;

    // PORCENTAJE DE VENTAS PRODUCTO 3
    porcentaje3 = (totRecaudado3 / totVendido) * 100;

    // SALIDA DE DATOS
    Console.WriteLine("Cantidad vendido del producto 1: " + cantVendidoProd1 + '\n' + "El porcentaje de esta venta es del: %" + porcentaje1);
    Console.WriteLine("Cantidad vendido del producto 2: " + cantVendidoProd2 + '\n' + "El porcentaje de esta venta es del: %" + porcentaje2);
    Console.WriteLine("Cantidad vendido del producto 3: " + cantVendidoProd3 + '\n' + "El porcentaje de esta venta es del: %" + porcentaje3);
    Console.WriteLine("Total vendido: " + totVendido);
  }
}

