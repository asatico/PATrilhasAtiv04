using System;

class Program
{
    static void Main()
    {
       Console.Clear();

       Console.WriteLine("Voce quer cancelar nosso programa?:");
       string resposta = (Console.ReadLine());

        if (resposta == "Sim"|| resposta == "sim" || resposta == "s"){
            Console.WriteLine("Porfavor, confirme o cancelamento da operaçao.");
        }else{
            Console.WriteLine("Aproveite o programa ;)");
        }
      

       
        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
