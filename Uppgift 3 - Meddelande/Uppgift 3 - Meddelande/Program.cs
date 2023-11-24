using System;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ruta = new string[5, 6];
            ruta[0, 0] = "p";
            ruta[1, 0] = "";
            ruta[2, 0] = "";
            ruta[3, 0] = "";
            ruta[4, 0] = "";
            ruta[0, 1] = "a";
            ruta[1, 1] = "";
            ruta[2, 1] = "u";
            ruta[3, 1] = "";
            ruta[4, 1] = "";
            ruta[0, 2] = "";
            ruta[1, 2] = "";
            ruta[2, 2] = "";
            ruta[3, 2] = "";
            ruta[4, 2] = "";
            ruta[0, 3] = "";
            ruta[1, 3] = "";
            ruta[2, 3] = "l";
            ruta[3, 3] = "";
            ruta[4, 3] = "";
            ruta[0, 4] = "";
            ruta[1, 4] = "";
            ruta[2, 4] = "";
            ruta[3, 4] = "";
            ruta[4, 4] = "";
            ruta[0, 5] = "";
            ruta[1, 5] = "";
            ruta[2, 5] = "";
            ruta[3, 5] = "a";
            ruta[4, 5] = "";
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rad {i + 1}:");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(ruta[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}