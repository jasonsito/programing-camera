using System;

namespace exerxise8
{
  class Program
  {
    static void Main(string[] args)
    {//ENUNCIADO: Usuario introduce una altura y lo clasificamos en función a eso.
      Console.WriteLine("Introduce tu altura en metros. Ej: (1,75)");
      float AlturaIntroducida = float.Parse(Console.ReadLine());
      if (AlturaIntroducida <= 1.50)
      { Console.WriteLine("Tienes una estatura inferior a la media, eres bajito/a"); }
      if (AlturaIntroducida > 1.50)
      { Console.WriteLine("Tienes una altura común");
      }

    }
  }
}
