using System;

class Program
{
    static void Main()
    {
       Console.Clear();

      List<int> lista = new List<int>();
      string resultado = (lista.Count == 0) ? "Lista vazia" : "Lista não esta vazia";
      Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
