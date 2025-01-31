using System;

class Program
{
    static void Main()
    {
       Console.Clear();

       Console.WriteLine("Digite um número:");
       int numero = Convert.ToInt32(Console.ReadLine());
       string resultado = (numero % 2 == 0) ? "par" : "impar";
       Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
