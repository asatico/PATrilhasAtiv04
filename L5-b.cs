using System;

class Program
{
    static void Main()
    {
       Console.Clear();

       Console.WriteLine("Digite um número:");
       int a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Digite um outro número");
       int b = Convert.ToInt32(Console.ReadLine());
       int resultado = (a > b ) ? a : b;
       Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
