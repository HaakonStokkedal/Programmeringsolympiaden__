using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in värdet på tal N.");
            int N = int.Parse(Console.ReadLine());
            int treigaTal = 0;
            int a = 0;

            for (int i = 0; i < N; i++)
            {
                a = i * (i + 1) * i * (i + 2);
                if (a < N)
                    treigaTal++;
            }
            Console.WriteLine($"Svar: Det är {treigaTal} treiga tal som är mindre än {N}.");
            Console.ReadKey();
        }
    }
}