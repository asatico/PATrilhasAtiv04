using System;

namespace name
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Voce tem NetFrix?");
			string netfrix = (Console.ReadLine());
			if (netfrix == "nao" || netfrix =="Nao") {
				Console.WriteLine("Presione alguma tecla . . . ");
			    Console.ReadKey(true);
			}else{
			   Console.WriteLine("Ja viu One Pice duplado?");
			   string one_pice =(Console.ReadLine());
			
			   if ( netfrix == "sim" && one_pice =="sim" || netfrix == "Sim" && one_pice == "Sim" ) {
				Console.WriteLine("Otimo, agora voce pode assistir a nova temporada!");
			   }else{
				Console.WriteLine("Voce nao pode ver a nova temporada de One Pice :(");
			 }
			
			
			
			   Console.WriteLine("Presione algo para sair . . . ");
			   Console.ReadKey(true);
			}
		}
	}
}
