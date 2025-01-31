using System;

class Program
{
    static void Main()
    {
       Console.Clear();

     object num = null;
     
     string resultado = (num == null) ? "nula" : "Nao nula";
     Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
