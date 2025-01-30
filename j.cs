using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número inteiro
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verifica se o número é maior que 10 ou menor que 0
        if (numero > 10 || numero < 0)
        {
            Console.WriteLine("Número inválido!");
        }
        else
        {
            Console.WriteLine("Número válido.");
        }
    }
}
