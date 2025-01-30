using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Qual e seu nome?");
			string nome = Console.ReadLine();
			int veri = nome.Length;
			Console.WriteLine("Informe sua idade:");
			int idade = Convert.ToInt32(Console.ReadLine());
			
			if (veri < 3 || idade < 18) {
				Console.WriteLine("Acesso negado");
				Console.ReadKey(true);
			}else{
				Console.WriteLine("Acesso liberado");
			}
			
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
