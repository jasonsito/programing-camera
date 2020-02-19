using System;

namespace exercise5
{
  class Program
  {
    static void Main(string[] args)
    {//ENUNCIADO: El usuario introduce un numero y le decimos si es positivo, negativo o 0.
      Console.WriteLine("Introduce un numero");
      int numero1 = int.Parse(Console.ReadLine());

      if (numero1 >=1)
      { Console.WriteLine("El numero es positivo"); }
      if (numero1 ==0)
      { Console.WriteLine("La respuesta es 0"); }
      if (numero1 <0) { Console.WriteLine("El numero es negativo"); }
    }
  }
}
