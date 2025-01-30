using System;

class Program
{
    static void Main()
    {
       Console.Clear();

       Console.WriteLine("Voce é um menbro inativo do clube (Sim/Não):");
       string resposta = (Console.ReadLine());

       if (resposta == "Sim"|| resposta == "sim" || resposta == "s"){
            Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube.");
       }else{
            Console.WriteLine("Obrigado, por continuar ativo no clube");
       }

       
        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
