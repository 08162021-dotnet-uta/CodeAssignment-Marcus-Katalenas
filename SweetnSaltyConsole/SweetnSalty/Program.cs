using System;

namespace SweentSalty
{
    class Program
    {
        static void Main(string[] args)
        {

            //Counters used to hold the number of special cases in the program
            int sweetCounter = 0;
            int saltCounter = 0;
            int bothCounter = 0;

            string currentLine = "";

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    currentLine += "sweet’nSalty ";
                    //Console.WriteLine("sweet’nSalty");
                    bothCounter++;
                }
                else if (i % 3 == 0)
                {
                    currentLine += "sweet ";
                    //Console.WriteLine("Sweet");
                    sweetCounter++;
                }
                else if (i % 5 == 0)
                {
                    currentLine += "salty ";
                   // Console.WriteLine("Salty");
                    saltCounter++;
                }
                else
                {
                    currentLine += i + " ";
                    //Console.WriteLine(i);
                }
                if(i % 10 == 0)
                {
                    Console.WriteLine(currentLine);
                    currentLine = "";
                }
            }

            Console.WriteLine();
            Console.WriteLine("Amount of sweets: " + sweetCounter);
            Console.WriteLine("Amount of Salts: " + saltCounter);
            Console.WriteLine("Amount of Boths: " + bothCounter);
        }
    }
}
