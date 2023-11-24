using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord du vill uprepa. (max 9 bokstäver)");
            string ord = Console.ReadLine();
            Console.WriteLine("Hur många gånger ska det upprepas? (max 9 gånger)");
            int antal = int.Parse(Console.ReadLine());

            while(ord.Length > 9 ||  antal > 9) 
            {
                if (ord.Length > 9 && antal <= 9)
                {
                    Console.WriteLine("Ordet får max ha 9 bokstäver så skriv in ett nytt ord.");
                    ord = Console.ReadLine();
                }
                else if (antal > 9 && ord.Length <= 9)
                {
                    Console.WriteLine("Det får max vara 9 ord så skriv in ett nytt antal.");
                    antal = int.Parse(Console.ReadLine());
                }
                else if (antal > 9 && ord.Length > 9)
                {
                    Console.WriteLine("Ordet får max ha 9 bokstäver så skriv in ett nytt ord.");
                    ord = Console.ReadLine();
                    Console.WriteLine("Det får också endast vara max 9 ord så skriv in ett nytt antal.");
                    antal = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < antal; i++)
            {
                Console.Write(ord);
            }
            Console.ReadKey();
        }
    }
}