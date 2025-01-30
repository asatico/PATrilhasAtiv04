using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			string produto;
			Console.WriteLine("Deseja comparar um produto?");
			produto = (Console.ReadLine());
			if (produto == "sim" || produto == "Sim" || produto == "S"|| produto == "s" ) {
				Console.WriteLine("Obrigado pela compra! :)");
			}else{
				Console.WriteLine("Beleza. Cuidado quando for na rua pra nao ser pego por um camiao preto. >:(");
				Console.ReadKey(true);
			}
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
