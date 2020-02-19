using System;

namespace exercise6
{
  class Program
  {
    static void Main(string[] args)
    {//ENUNCIADO: Presentamos una interfaz al usuario con tres opciones y en funcion de lo elegido le presentamos lo que ha pedido, si introduce un valor no valido le respondemos que se ha equivocado.
      Console.WriteLine("Introduzca un número para las siguientes acciones 1.Refran 2.Chiste 3. Insultar");
      int numero1 = int.Parse(Console.ReadLine());

      switch (numero1)
      { case 1:
          Console.WriteLine("No por mucho madrugar, amanece mas temprano.");
          break;

        case 2:
          Console.WriteLine("¿Cual es el objeto mas gracioso del mundo? La escoba, porque siempre ba-rriendo");
          break;

        case 3:
          Console.WriteLine("Eres mas tonto que un bocao en los cojones");
          break;

        default:
          Console.WriteLine("Te has equivocado de numero");
          break;
      }
    }
  }
}
