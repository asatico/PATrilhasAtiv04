using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Voce tem diploma de ensino superior ?");
			string diploma = (Console.ReadLine());
			Console.WriteLine("Voce tem quantos anos?");
			int anos = Convert.ToInt32(Console.ReadLine());
			
			if ( diploma == "sim" && anos >= 21 ) {
				Console.WriteLine("Parabéns, você está qualificado para a vaga!");
			}else{
				Console.WriteLine("Voce nao ta qualificado para a vaga");
			}
			 
			
			
			Console.WriteLine("Presione algo para sair . . . ");
			Console.ReadKey(true);
		}
	}
}
