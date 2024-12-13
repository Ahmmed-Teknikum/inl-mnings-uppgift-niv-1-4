using System;

namespace inlämningsUppgift_._nivå1_._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            do
            {
                Console.WriteLine("Ange lösenordet");
                password = Console.ReadLine();
            }
            while (password != "hemligt");
            Console.WriteLine("Rätt lösenord");

        }
    }
}