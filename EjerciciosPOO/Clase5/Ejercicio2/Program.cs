// Crear una clase Calculadora.

// Crear un método sumar(int a, int b) que devuelva una suma.
// Crear un método sumar(double a, double b, double c) para sumar tres números.
// Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
// Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).

using System;

class Program {
  class Calculadora{
    public int sumar(int a, int b){
      int suma;

      suma = a + b;
      return suma;
    }

    public double sumar(double a, double b, double c){
      double suma;
      double redondeado;

      suma = a + b + c;
      redondeado = Math.Round(suma, 2);
      return redondeado;
    }

    public void sumar(string msj, int a, int b){
      int suma;
      string cadena;

      suma = a + b;
      cadena = msj + " " + suma; // suma.ToString();
      Console.WriteLine($"{msj} {suma}");
    }

    public bool esPar(int a){
      bool esPar = false;

      if (a % 2 == 0){
        esPar = true; // true;
      } else {
        esPar = false; // false;
      }

      return esPar;
    }
  }

  static void Main(string[] args){
    Calculadora sumador = new Calculadora();

    int suma1;
    double suma2;

    suma1 = sumador.sumar(2, 5); // 7
    Console.WriteLine(suma1);

    suma2 = sumador.sumar(2.1, 2.2, 2.2); // 6.4
    Console.WriteLine(suma2);

    sumador.sumar("Suma:", 5, 5); // "Suma: 10"

    Console.WriteLine(sumador.esPar(5)); 
  }
}