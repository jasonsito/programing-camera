using System;

namespace exercise_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Introduce tu nota:");
      int grade = int.Parse(Console.ReadLine());

      switch (grade)
      {
        case 10:
        case 9:

          Console.WriteLine("Sobresaliente");
          break;

        case 8:
        case 7:

          Console.WriteLine("Notable");
          break;

        case 6:

          Console.WriteLine("Bien");
          break;

        case 5:

          Console.WriteLine("Suficiente");
          break;

        case 4:
        case 3:
        case 2:
        case 1:
        case 0:

          Console.WriteLine("Insuficiente");
          break;

        default:
          Console.WriteLine("Te has equivocado");
          break;

      }

      }
    }
  }
}
