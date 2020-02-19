using System;

namespace exercise4
{
  class Program
  {
    static void Main(string[] args)
    {//ENUNCIADO: Introduce dos numeros y responde si son multiplo o no.
      Console.WriteLine("Introduzca un numero");
      int numero1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Introduzca segundo numero");
      int numero2 = int.Parse(Console.ReadLine());

      if (numero1 % numero2 == 0)
      { Console.WriteLine("el numero es un multiplo"); }

      if (numero1 % numero2 != 0)
      { Console.WriteLine("el numero no es un multiplo"); }

    }
  }
}
