using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on võitja
            //täringuid visatakse kolm korda
            //programm kuulutab võitja ja pakub kasutajale uuesti mängida

            int cpuScore = 0;
            int userScore = 0;

            Algus:
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine("Vajuta Enter, et täringut veeretada!");
                Console.ReadLine();
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");
                if (cpuRandom < userRandom)
                {
                    userScore++;
                }
                else if (cpuRandom > userRandom)
                {
                    cpuScore++;
                }
                else
                {

                }
            }
            if (userScore < cpuScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else if (userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud.");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
            Console.WriteLine("Kas soovid uuesti mängida? (jah/ei)");
            string userInput = Console.ReadLine();
            if(userInput == "jah")
            {
                goto Algus;
            }
            else
            {
                Console.WriteLine("Kena päeva!"); 
            }

        }
    }
}
