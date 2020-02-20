using System;

namespace exercise11
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Indica cuantos numeros quieres sumar");
      int numbercount = int.Parse(Console.ReadLine());

      int[] numbers = new int[numbercount];
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.Write("Número " + (i + 1) + ": ");
        numbers[i] = int.Parse(Console.ReadLine());
      }
      int total = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        total += numbers[i];


      }
      Console.WriteLine("Suma total: " + total);

    }
  }
}
