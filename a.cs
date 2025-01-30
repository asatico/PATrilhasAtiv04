using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Voce tem quantos anos:");
			int anos =Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Voce tem carteira de motorista:");
			string carteira= (Console.ReadLine());
			
			if (anos >= 18 || carteira == "sim" ) {
				Console.WriteLine("Voce pode dirigir");
			}else{
				Console.WriteLine("Voce nao pode dirigir");
			}
			 
			
			
			Console.WriteLine("Presione algo para sair . . . ");
			Console.ReadKey(true);
		}
	}
}
