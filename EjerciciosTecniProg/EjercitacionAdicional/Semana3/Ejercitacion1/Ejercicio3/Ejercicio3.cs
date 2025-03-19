// Se ingresan 50 saldos de cuentas de un banco. Calcular e informar:
//  a. Cantidad de saldos superiores a $1000.
//  b. Promedio de los restantes.

using System;
namespace Ejercicio3;

class Ejercicio3
{
  static void Main(string[] args)
  {
    int saldosSup1000;
    int  cantSaldos;

    double saldo; // o FLOAT
    double sumaRestantes, promRestantes; // o FLOAT
    int cantRestantes;

    cantSaldos = 5; // 50 SALDOS
    saldosSup1000 = 0; 
    cantRestantes = 0;
    sumaRestantes = 0;

    for (int i = 1; i <= cantSaldos; i++)
    { 
      Console.WriteLine($"Ingrese el saldo número {i}: ");
      saldo = int.Parse(Console.ReadLine());

      while(saldo < 0)
      {
        Console.Write($"El saldo no puede ser negativo. Por favor ingresa el saldo número {i} para continuar: ");
        saldo = int.Parse(Console.ReadLine());
      }

      if (saldo > 1000)
      {
        saldosSup1000++;
      } else { 
        sumaRestantes += saldo;
        cantRestantes++;
      }
    }

    Console.WriteLine($"La cantidad de saldos superiores a $1000 es: {saldosSup1000}" );
    if (cantRestantes > 0)
    {
      promRestantes = sumaRestantes / cantRestantes;
      Console.Write("El promedio de los restantes es: " + promRestantes);
    } else
    {
      Console.Write("No hay saldos inferiores a $1000.");
    }
  }
}