using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1: Gebe aus einer Liste von Zahlen nur die Zahlen aus, welche durch 2 Teilbar sind.
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numQuery = from num in numbers
                           where num % 2 == 0
                           select num;

            foreach (int num in numQuery)
            {
                Console.WriteLine(num);
                
            }
            Console.ReadKey();

        }
    }
}
