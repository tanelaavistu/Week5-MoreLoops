using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kasutajanime ja parooli
            //kui sisestatud kasutajatunnus on "admin" ja parool "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul kuvatakse "Vale kasutajanimi või parool. Proovi uuesti."

            Console.WriteLine("Kasutajanimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Parool:");
            string userPassword = Console.ReadLine();

            //AND (&&)

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin122" --> false
            //"admin132" AND "addd" --> false

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajanimi või parool. Proovi uuesti.");
            }
        }
    }
}
