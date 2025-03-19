// Realizar un programa para la organización de un torneo deportivo, que contenga la
// información correspondiente al número de participante, edad y puntos obtenidos en
// una competencia, y que finalice al ingresar número de participante 0 (inexistente).

// Dicho programa debe calcular e informar:
//  ● ¿Cuántos participantes tienen más de 20 años?
//  ● ¿Cuántos participantes obtuvieron menos de 50 puntos?
//  ● Total de puntos obtenidos.
//  ● Número de participante, edad y puntos obtenidos del participante de menor número. 

using System;
namespace Ejercicio1B;

class Ejercicio1B
{
  static void Main(string[] args)
  {
    int nParticipante, edad, pObtenidos;
    int cantEdades20, menos50, totPuntos;
    int menorNumeroParticipante = 0, menorEdad = 0, menorPuntaje = 0;
    bool primerPuntaje = true;

    cantEdades20 = 0;
    menos50 = 0;
    totPuntos = 0;
    menorNumber = 0;

    do
    {
      Console.Write("Ingresa el N° de participante (Ingrese 0 si desea finalizar): ");
      nParticipante = int.Parse(Console.ReadLine());

      while(nParticipante < 0)
      {
        Console.Write("El N° del participante debe ser mayor a 0, si desea finalizar ingrese 0. Por favor, ingrese nuevamente: ");
        nParticipante = int.Parse(Console.ReadLine());
      }

      if(nParticipante == 0)
      {
        Console.WriteLine("El usuario cancelo la entrada.");
        break;
      }

      Console.Write("Ingrese la edad del participante: ");
      edad = int.Parse(Console.ReadLine());

      while(edad <= 0)
      {
        Console.WriteLine("La edad del participante debe ser mayor a 0. Por favor, ingrese nuevamente: ");
        nParticipante = int.Parse(Console.ReadLine());
      }

      if(edad > 20)
      {
        cantEdades20++;
      }

      Console.Write("Ingrese el puntaje obtenido del participante en la competencia: ");
      pObtenidos = int.Parse(Console.ReaLine());

      while(pObtenidos < 0)
      {
        Console.Write("El puntaje no puede ser un número negativo. Por favor ingrese nuevamente: ");
        pObtenidos = int.Parse(Console.ReaLine());
      }

      if(pObtenidos < 50)
      {
        menos50++;
      }

      totPuntos =+ pObtenidos;

      if(primerPuntaje)
      {
        menorPuntaje = pObtenidos;
        menorNumeroParticipante = nParticipante;
        menorEdad = pObtenidos;
        primerPuntaje = false;
      } else if (pObtenidos < menorPuntaje)
      {
        menorPuntaje = pObtenidos;
        menorNumeroParticipante = nParticipante;
        menorEdad = edad;
      }
    } while (nParticipante != 0);

    Console.WriteLine($"\nCantidad de participantes mayores a 20 años: {cantEdades20}");
    Console.WriteLine($"Cantidad de participantes que obtuvieron menos de 50 puntos: {menos50}");
    Console.WriteLine($"Total de puntos obtenidos por todos los participantes: {totPuntos}");

    if (primerPuntaje == false)
    {
      Console.WriteLine($"Participante con menor puntaje: N° {menorNumeroParticipante}, Edad: {menorEdad}, Puntos: {menorPuntaje}");
    }
  }
}