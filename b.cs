using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Qual e seu nome?");
			string nome =(Console.ReadLine());
			Console.WriteLine("Voce quer comprar um carro novo?");
			string carro = (Console.ReadLine());
			Console.WriteLine("Voce tme dinheiro para isso?");
			string dinheiro =(Console.ReadLine());
			
			if ( dinheiro == "sim" && carro == "sim" ) {
				Console.WriteLine("Parabéns, você pode comprar um carro novo!");
			}else{
				Console.WriteLine("Voce nao pode compar um carro novo");
			}
			 
			
			
			Console.WriteLine("Presione algo para sair . . . ");
			Console.ReadKey(true);
		}
	}
}
