using System;
namespace Uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sidlängd på en triangel");
            short längd = short.Parse(Console.ReadLine());

            for (int i = 1; i <= längd; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine('*');
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}