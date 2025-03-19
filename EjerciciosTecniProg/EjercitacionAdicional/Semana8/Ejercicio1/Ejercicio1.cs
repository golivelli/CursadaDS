// Realizar programa que permita crear una función, la cual deberá recibir el nombre
// CalcularMayor(), recibiendo para trabajar tres números distintos e informe el mayor
// de ellos. Crear otra función, la cual deberá recibir el nombre CalcularMenor(),
// recibiendo para trabajar los mismos tres números distintos e informe el menor de
// ellos. El programa principal ingresa (de ser necesario) los datos, y deberá realizar
// convenientes llamados a la función e informar los resultados.

using System;
namespace CalcularMayor;

class Program
{
  public static int CalcularMayor(int num1, int num2, int num3)
  {
    int nMayor = num1;
    if (num2 > nMayor)
    {
      nMayor = num2;
    }

    if (num3 > nMayor)
    {
      nMayor = num3;
    }

    return nMayor;
  }

  public static int CalcularMenor(int num1, int num2, int num3)
  {
    int nMenor = num1;
    if (num2 < nMenor)
    {
      nMenor = num2;
    }

    if (num3 < nMenor)
    {
      nMenor = num3;
    }

    return nMenor;
  }

  public static void CargarNumeros(ref int num1, ref int num2, ref int num3)
  {
    do
    {
      Console.Write("Ingrese el primer número, debe ser mayor o igual a 0: ");
      num1 = int.Parse(Console.ReadLine());
    } while (num1 < 0);

    do
    {
      Console.Write("Ingrese el segundo número, debe ser mayor o igual a 0: ");
      num2 = int.Parse(Console.ReadLine());
    } while (num2 < 0);

    do
    {
      Console.Write("Ingrese el tercer número, debe ser mayor o igual a 0: ");
      num3 = int.Parse(Console.ReadLine());
    } while (num3 < 0);
  }
  static void Main(string[] args)
  {
    int number1 = 0;
    int number2 = 0;
    int number3 = 0;

    CargarNumeros(ref number1, ref  number2, ref number3);

    int resultadoMayor = CalcularMayor(number1, number2, number3);
    int resultadoMenor = CalcularMenor(number1, number2, number3);

    Console.WriteLine("El número menor ingresado es: " + resultadoMenor);
    Console.Write("El número mayor ingresado es: " + resultadoMayor);
  }
} 
