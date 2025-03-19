// Realizar un programa, con una función, la cual deberá nombrarse como “cuenta”,
// recibiendo para trabajar dos números correspondientes al número de cuenta
// bancaria y el importe que se desea extraer, y en la cual se deberá solicitar el saldo
// de la cuenta. Si el saldo es suficiente, deberá calcular e informar el nuevo saldo. En
// caso contrario informar “Saldo insuficiente”. El programa principal ingresa (de ser
// necesario) los datos, y deberá realizar convenientes llamados a la función e informar
// de ser requerido los resultados.

using System;
namespace Ejercicio5;

class Program
{
  static void Main(string[] args)
  {
    int cuentaBancaria, importeAExtraer;

    Console.Write("Ingrese el número de cuenta: ");
    cuentaBancaria = int.Parse(Console.ReadLine());

    if ()

    do
    {
      Console.Write("El número de cuenta no puede ser un número nulo o negativo, ingrese nuevamente: ");
      cuentaBancaria = int.Parse(Console.ReadLine());
    } while (cuentaBancaria <= 0);

    Console.Write("Ingrese el saldo a extraer: ");
    importeAExtraer = int.Parse(Console.ReadLine());

    do
    {
      Console.Write("El saldo debe ser mayor a 0: ");
      importeAExtraer = int.Parse(Console.ReadLine());
    } while (importeAExtraer <= 0);
  }
}