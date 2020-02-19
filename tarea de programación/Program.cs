using System;

namespace tarea_de_programación
{
  class Program
  {
    static void Main(string[] args)
    {//se introducen dos numeros al azar
      Console.WriteLine("Introduzca primer numero");
      int numero1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Introduzca segundo numero:");
      int numero2 = int.Parse(Console.ReadLine());
      //Si los dos numeros son iguales se ejecuta esta orden
      if (numero1 == numero2)
      {
        Console.WriteLine("Ambos numeros son iguales");
      }
      //Si el numero 1 es mayor que el numero 2 se ejecuta esta orden
      else if (numero1 > numero2)
      { Console.WriteLine("Ambos numeros son distintos, el mayor es:");
        Console.WriteLine(numero1);

      }
      //Si el numero 1 es menor que el numero 2 se ejecuta esta orden
      else if (numero1 < numero2)
      { Console.WriteLine("Ambos numeros son distintos, el mayor es");
        Console.WriteLine(numero2);
      }

    }
  }
}
