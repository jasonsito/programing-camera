using System;

namespace ejercicio_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Introduzca su edad: ");
      int age = int.Parse(Console.ReadLine());

      if (age >= 18)
      {
        Console.WriteLine("Ya eres mayor de edad.");
      }
      else
      {
        Console.WriteLine("Eres menor de edad.");
      }
    }
  }
}
