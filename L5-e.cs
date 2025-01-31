using System;

class Program
{
    static void Main()
    {
       Console.Clear();

       bool condicao = true;
       string resutado = condicao ? "Condiçao verdadeira" : "Condiçao falsa";
       Console.WriteLine(resutado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
