using System;

namespace exercise3
{
  class Program
  {
    static void Main(string[] args)
    {//ENUNCIADO: El usuario introduce un numero y respondemos si es par o impar.
      Console.WriteLine("Introduzca un numero");
      int numero1 = int.Parse(Console.ReadLine());

      if (numero1 % 2 == 0)
      { Console.WriteLine("el numero es par"); }

      if (numero1 %2 != 0)
      { Console.WriteLine("el numero es impar"); }

    }
  }
}
