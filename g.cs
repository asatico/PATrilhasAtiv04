using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numero;
			Console.WriteLine("Digite um número:");
			numero = Convert.ToInt32(Console.ReadLine());
			if ( numero % 3 == 0 || numero % 5  == 0 ) {
				Console.WriteLine("O número é  divisível por 3 ou por 5!");
			}else{
				Console.WriteLine("Escreva um número valido");
			}
			
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
