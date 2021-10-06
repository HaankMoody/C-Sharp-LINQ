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
            Console.WriteLine();

            //Aufagbe 2: Gebe aus einer Liste von Zahlen nur die ungeraden Werte aus:
            int[] numbers2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numQuery2 = from num in numbers2
                            where num % 2 != 0
                            select num;

            foreach(int num in numQuery2)
            {
                Console.WriteLine(num);

            }
            Console.ReadKey();
            Console.WriteLine();

            //Aufgabe 3: Gebe für die angegebenen Zahlen,
            //die Zahl sowie die Quadratzahl aus, wobei die Quadratzah größer als 20 sein soll:

            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var numQuery3 = from num in arr1
                            where (num * num) > 20
                            select num;
            foreach(var num in numQuery3)
            {
                Console.WriteLine($"{num} {num*num}");
            }
            Console.ReadLine();
            Console.WriteLine();

            //Aufgabe 4: Gehe eine Liste von zahlen durch,
            //und gebe die Zahl sowie die Häufigkeit, wie oft diese in der Liste auftritt:

            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            foreach(var num in arr2.GroupBy(i => i))
            {
                Console.WriteLine("{0} => {1}", num.Key, num.Count());
            }
            Console.ReadKey();
            Console.WriteLine();

            //Aufgabe 5:Gebe die Häufigkeit jeden Buchstabens des angegebenen Strings aus.
            //Lasse den Nutzer ein eigenes Wort eingeben:

            Console.WriteLine($"Bitte gebe ein Wort ein.");
            string wort = Console.ReadLine();
            string newwort = string.Join("", wort);

            foreach(var letter in newwort.GroupBy(i => i))
            {
                Console.WriteLine("{0} => {1}", letter.Key, letter.Count());
            }
            Console.ReadKey();
            Console.WriteLine();

            //Aufgabe 6: Gebe die Zahl, das Auftreten der Zahl im Array,
            //sowie die Multiplikation der Zahl mit der Zahl ihres Auftretens:

            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            foreach(var num in nums.GroupBy(i => i))
            {
                Console.WriteLine($"{num.Key} => {num.Count()}; {num.Key * num.Count()}");
            }
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
