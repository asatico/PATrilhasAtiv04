using System;

class Program
{
    static void Main()
    {
       Console.Clear();

     int num; 
     Console.WriteLine("Digite um número");
     num = int.Parse (Console.ReadLine());
     Console.WriteLine("Digite outro número");
     int num2 = int.Parse (Console.ReadLine());

     string resultado = (num % num2 == 0) ? "Divisivel" : "Nao divisivel";
     Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
