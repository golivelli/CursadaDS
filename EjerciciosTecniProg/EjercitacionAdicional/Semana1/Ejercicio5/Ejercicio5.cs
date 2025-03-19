// Una familia de 4 personas desea irse de viaje. Para esto deben tener en
// cuenta lo siguiente: a) Precio de pasajes aéreos. b) Precio de un hotel por
// noche. c) Cantidad de noches. d) Alquiler de un auto (precio por día). El
// programa debe calcular el total que saldrá el viaje, teniendo en cuenta que el
// alquiler del auto será alquilado solo la mitad de la estadía.

using System;
namespace Ejercicio5;

class Ejercicio5
{
  static void Main(string[] args)
  {
    // DECLARACIÓN DE VARIABLES
    int precioPasajes, precioHotelPorNoche, cantNoches, rentaAuto;
    int totAuto, totHotel, totViaje;
    int personas = 4;
    int nochesConAuto;

    // VALIDAR E INDICAR LOS VALORES
    Console.Write("Indique el precio de los pasajes aéros: ");
    precioPasajes = int.Parse(Console.ReadLine()) * personas;

    while(precioPasajes <= 0)
    {
      Console.Write("El precio de los pasajes debe ser mayor a 0. Por favor, ingrese nuevamente: ");
      precioPasajes = int.Parse(Console.ReadLine()) * personas;
    }

    Console.Write("Indique el precio del hotel: ");
    precioHotelPorNoche = int.Parse(Console.ReadLine());

    while(precioHotelPorNoche <= 0)
    {
      Console.Write("El precio del hotel por noche no pueden ser menores o iguales a 0. Por favor, ingrese nuevamente: ");
      precioHotelPorNoche = int.Parse(Console.ReadLine());
    }

    Console.Write("Indique la cantidad de noches de la estadia: ");
    cantNoches = int.Parse(Console.ReadLine());

    while(cantNoches <= 0)
    {
      Console.Write("La cantidad de noches no pueden ser menores o iguales a 0. Por favor, ingrese nuevamnte: ");
      cantNoches = int.Parse(Console.ReadLine());
    }

    Console.Write("Indique el alquiler del auto por día: ");
    rentaAuto = int.Parse(Console.ReadLine());

    while(rentaAuto <= 0)
    {
      Console.Write("El precio del auto por día debe ser mayor a 0. Por favor, ingrese nuevamente: ");
      rentaAuto = int.Parse(Console.ReadLine());
    }

    // CALCULOS
    nochesConAuto = cantNoches / 2;
    totAuto = rentaAuto * nochesConAuto;
    totHotel = precioHotelPorNoche * cantNoches * personas;
    totViaje = precioPasajes + totAuto + totHotel;
    
    // SALIDA
    Console.Write($"El total del viaje es de: $" + totViaje);
  }
}