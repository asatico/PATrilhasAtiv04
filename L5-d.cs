using System;

class Program
{
    static void Main()
    {
       Console.Clear();

      string texto = "";
      string resultado = string.IsNullOrEmpty(texto) ? "String vazia" : "String não esta vazia";
      Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
