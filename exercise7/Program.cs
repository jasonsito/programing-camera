using System;

namespace exercise7
{
  class Program
  {
    static void Main(string[] args)
    {//ENUNCIADO: El usuario introduce tres notas y vamos a mostrarle la media que ha sacado.
      Console.WriteLine("Introduce la nota obtenida en cada una de las 3 asignaturas:");
      float Nota1 = float.Parse(Console.ReadLine());
      float Nota2 = float.Parse(Console.ReadLine());
      float Nota3 = float.Parse(Console.ReadLine());

      Console.WriteLine("La nota media obtenida entre las tres asiganutas es:");
      Console.WriteLine((Nota1 + Nota2 + Nota3) / 3);

    }
  }
}
