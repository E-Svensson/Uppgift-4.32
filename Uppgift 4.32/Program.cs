using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bestäm kvadraternas sidlängd: "); int Sidlängd = int.Parse(Console.ReadLine());
            Console.Write("Bestäm rutnätets bredd: "); int Bredd = int.Parse(Console.ReadLine());
            Console.Write("Bestäm rutnätets höjd: "); int Höjd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < Höjd; i++)
            {
                for (int j = 0; j < Sidlängd; j++)
                {
                    for (int k = 0; k < Bredd; k++)
                    {
                        Console.Write("***** ");

                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
