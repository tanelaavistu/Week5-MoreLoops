using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kasutajanime ja parooli
            //kui sisestatud kasutajatunnus on "admin" ja parool "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul kuvatakse "Vale kasutajanimi või parool. Proovi uuesti."
            //kasutajal on 3 katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Kasutajanimi:");
                string userName = Console.ReadLine();
                Console.WriteLine("Parool:");
                string userPassword = Console.ReadLine();

                if(userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Vale kasutajanimie või parool. {2 - i} katset jäänud.");
                    i++;
                }
            }


        }
    }
}
