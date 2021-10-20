using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kasutajanime ja parooli
            //kui sisestatud kasutajatunnus on "admin" ja parool "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul kuvatakse "Vale kasutajanimi või parool. Proovi uuesti."

            //OR || (pipes

            // true || true --> true
            // false || true --> true
            // true || false --> true
            // false || false --> false


            Console.WriteLine("Kasutajanimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Parool:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajanimi või parool. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
