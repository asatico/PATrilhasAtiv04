using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
			Console.WriteLine("Qual seu  nome ?");
			nome = (Console.ReadLine());
		
			if (nome == "Wilson" || nome == "Gloria") {
				Console.WriteLine("Bem Vido de volta! :)");
			}else {
				Console.WriteLine("Seja bem vindo");
			}
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
