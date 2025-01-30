using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			string cafe;
			
			Console.WriteLine("Dejesa adicionar açúca ou leite no seu café? ");
			cafe = Console.ReadLine();
			if (cafe == "Açuca" || cafe =="açuca" && cafe == "leite" || cafe == "Leite" ) {
				Console.WriteLine("Café com adicional preparado !.");
			}else{
				Console.WriteLine("Aproveite seu café.");
		}
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
