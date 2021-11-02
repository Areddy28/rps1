using System;

namespace RPSLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Welcome to the Rock paper scissors game!!");
                Console.WriteLine();
                UserPlayer u = new UserPlayer();

                u.GenerateRPS();

                UserPlayer p = new UserPlayer();
                Console.WriteLine(p.GenerateRPS());

                Rocky r = new Rocky();
                Console.WriteLine(r.GenerateRPS());

                Randa randa = new Randa();
                Console.WriteLine(randa.GenerateRPS());



                goOn = u.Continue(); 

            }



             
        }
    }
}
