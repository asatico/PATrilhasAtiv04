using System;

class Program
{
    static void Main()
    {
       Console.Clear();
        
       Console.WriteLine("Escreva um número:");

       if (double.TryParse(Console.ReadLine(), out double num)){
            if(num != 0){
                Console.WriteLine("O número e diferente de zero.");
            }else{
                Console.WriteLine("O número e zero.");
            }
       }else{
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
       }
        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
