using System;

class Program
{
    static void Main()
    {
       Console.Clear();

     string num; 
     Console.WriteLine("Digite alguns números");
     num = (Console.ReadLine());

     int resultado = int.TryParse(num, out int convertido) ? convertido : 0;
     Console.WriteLine(resultado);
      

        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
