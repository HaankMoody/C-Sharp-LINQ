﻿using System;
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

            //Aufgabe 7:Gebe die Städte aus, welche mit einem bestimmten Buchstaben beginnen,
            //sowie mit einem weiteren Buchstaben Enden. Gestalte es variabel.

            string[] cities = new string[] {  "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", 
                                                    "NEW DELHI", "AMSTERDAM", "ABUDHABI", "PARIS" };
            Console.WriteLine($"Gebe einen Anfangsbuchstaben ein:");
            string firstLetter = Console.ReadLine().ToUpper();
            Console.WriteLine($"Gebe den Endbuchstaben ein:");
            string lastLetter = Console.ReadLine().ToUpper();

            var Ausgabe1 = cities.Where(a => a.StartsWith(firstLetter)).Select(a => a).ToList();
            var Ausgabe2 = Ausgabe1.Where(a => a.EndsWith(lastLetter)).Select(a => a).ToList();

            foreach(string s in Ausgabe2)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            Console.ReadLine();

            //Aufgabe 8: Lasse den Nutzer eine Zahl eingeben, wie viele Einträge er hinzufügen möchte. 
            //Frage anschließend nach den jeweiligen Werten, bis die Anzahl der Listelemente erreicht ist. 
            //Frage Anschließend nach einer Zahl und gebe nur die Elemente der Liste aus, welche größer als die Eingabe ist.

            Console.WriteLine($"Wie viele Einträge möchtest du in deiner Liste speichern?");

            int anzahlEintrag = Convert.ToInt32(Console.ReadLine());

            List<int> anzahlEintraege = new List<int>(anzahlEintrag);
            int i = 0;
            do
            {

                Console.WriteLine($"Welche Zahlen möchtest du deiner Liste hinzufügen?");
                anzahlEintraege.Add(Convert.ToInt32(Console.ReadLine()));
                i++;

            }
            while (i < anzahlEintrag);

            Console.WriteLine($"Nenn mir eine Zahl:");
            int zahl = Convert.ToInt32(Console.ReadLine());

            var ausgabe = from list in anzahlEintraege
                          where list >= zahl
                          select list;

            foreach (var x in ausgabe)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
