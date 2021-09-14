using System;

namespace SweentSalty
{
    class Program
    {
        static void Main(string[] args)
        {


            int sweetCounter = 0;
            int saltCounter = 0;
            int bothCounter = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("sweet’nSalty");
                    bothCounter++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Sweet");
                    sweetCounter++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Salty");
                    saltCounter++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Amount of sweets: " + sweetCounter);
            Console.WriteLine("Amount of Salts: " + saltCounter);
            Console.WriteLine("Amount of Boths: " + bothCounter);
        }
    }
}
