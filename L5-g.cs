using System;

class Program
{
    static void Main()
    {
       Console.Clear();

     int num; 
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());

     string resultado = (num > 0 ) ? "Positivo" : (num < 0) ? "Negativo" : "Zero";
     Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
