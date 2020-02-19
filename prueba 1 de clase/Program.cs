using System;

namespace prueba_1_de_clase
{
  class Program
  {
    static void Main(string[] args)
    {
      //Declaracion de variable de tipo integer llamada "x".
      int x;
      //Inicializacion de variable llamada "x" con el valor 4.
      x = 4;
      //Declaración e inicialización. Numerico por orden de tamaño, float y double admiten decimales.
      int y = 3;
      float z = 3.14f;
      double w = 45.2d;
      //Codigo para letras o frases completas representadas con 'si es una letra unica o con " si es frase.
      char letra = 'a';
      string Frase = "Frase de prueba";
      //Codigo para verdadero o falso.
      bool booleanofalso = false;
      bool boleanoverdadero = true;
    

      Console.WriteLine("Introduzca el primer número");
      int numero = int.Parse(Console.ReadLine());
      Console.WriteLine("Introduzca el segundo número");
      int numero2 = int.Parse(Console.ReadLine());
      Console.WriteLine("La suma es:");
      Console.WriteLine(numero + numero2);
    }
  }
}
