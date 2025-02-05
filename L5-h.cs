using System;

class Program
{
    static void Main()
    {
      string numeroTexto = "123";
        if (int.TryParse(numeroTexto, out int numero)){
            Console.WriteLine(numero); // Saída: 123
        }
        else{
            Console.WriteLine("Conversão falhou!");
        }
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
