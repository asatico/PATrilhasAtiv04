using System;

class Program
{
    static void Main()
    {
       Console.Clear();

     int num; 
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());
    
     int resultado = (num < 0 ) ? -num : num;
     Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
