using System;

class Program
{
    static void Main()
    {
        Console.Clear(); // Limpa o terminal antes de exibir as mensagens

        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine().Trim();

        if (!string.IsNullOrEmpty(palavra))
        { 
            Console.WriteLine("A palavra não é vazia.");
        }
        else
        {
            Console.WriteLine("Você não digitou nenhuma palavra.");
        }
    }
}
