using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Voce nao e um robo ?");
        string robo = (Console.ReadLine());

        if (robo == "sim" || robo =="Sim" || robo == "s"){
            Console.WriteLine("Porfavor, prove que vc nao e um robo ");
        }else{
            Console.WriteLine("Robo e para la");
        }
    }
}
