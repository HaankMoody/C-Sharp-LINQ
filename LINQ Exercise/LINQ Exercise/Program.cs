using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static LINQ_Exercise.Program;

namespace LINQ_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe4();
            //Aufgabe5();
            //Aufgabe6();
            //Aufgabe7();
            //Aufgabe8und9();
            //Aufgabe10();
            //Aufgabe11();
            //Aufgabe12();
            //Aufgabe13();
            //Aufgabe14und15();
            //Aufgabe16();
            //Aufgabe17();
            //AufgabeSheet1();
            //AufgabeSheet2();
            //AufgabeSheet3();
            //AufgabeSheet20();
            //AufgabeSheet21();
            //AufgabeSheet22();
            //AufgabeSheet25();
            //AufgabeSheet26();
            AufgabeSheet27();
            //AufgabeSheet28();
            //AufgabeSheet29();
            //AufgabeSheet30();
        }
        static void Aufgabe1()
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
        }
        static void Aufgabe2()
        {
            //Aufagbe 2: Gebe aus einer Liste von Zahlen nur die ungeraden Werte aus:
            int[] numbers2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numQuery2 = from num in numbers2
                            where num % 2 != 0
                            select num;

            foreach (int num in numQuery2)
            {
                Console.WriteLine(num);

            }
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Aufgabe3()
        {
            //Aufgabe 3: Gebe für die angegebenen Zahlen,
            //die Zahl sowie die Quadratzahl aus, wobei die Quadratzah größer als 20 sein soll:

            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var numQuery3 = from num in arr1
                            where (num * num) > 20
                            select num;
            foreach (var num in numQuery3)
            {
                Console.WriteLine($"{num} {num * num}");
            }
            Console.ReadLine();
            Console.WriteLine();
        }
        static void Aufgabe4()
        {
            //Aufgabe 4: Gehe eine Liste von zahlen durch,
            //und gebe die Zahl sowie die Häufigkeit, wie oft diese in der Liste auftritt:

            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            foreach (var num in arr2.GroupBy(i => i))
            {
                Console.WriteLine("{0} => {1}", num.Key, num.Count());
            }
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Aufgabe5()
        {
            //Aufgabe 5:Gebe die Häufigkeit jeden Buchstabens des angegebenen Strings aus.
            //Lasse den Nutzer ein eigenes Wort eingeben:

            Console.WriteLine($"Bitte gebe ein Wort ein.");
            string wort = Console.ReadLine();
            string newwort = string.Join("", wort);

            foreach (var letter in newwort.GroupBy(i => i))
            {
                Console.WriteLine("{0} => {1}", letter.Key, letter.Count());
            }
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Aufgabe6()
        {
            //Aufgabe 6: Gebe die Zahl, das Auftreten der Zahl im Array,
            //sowie die Multiplikation der Zahl mit der Zahl ihres Auftretens:

            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            foreach (var num in nums.GroupBy(i => i))
            {
                Console.WriteLine($"{num.Key} => {num.Count()}; {num.Key * num.Count()}");
            }
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Aufgabe7()
        {
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

            foreach (string s in Ausgabe2)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            Console.ReadLine();
        }
        static void Aufgabe8und9()
        {
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
            //Aufgabe 9: Frage den Nutzer wie viele Einträge er ausgeben möchte,
            //sortiere die Liste den Werten nach absteigend und
            //gebe anschließend die n Einträge aus die der Nutzer sehen möchte. (Verwende die .Take() - Methode)

            Console.WriteLine($"Wie viele Einträge möchtest du ausgeben?");
            int ausgabeAnzahlEintrag = Convert.ToInt32(Console.ReadLine());


            var output = anzahlEintraege.OrderByDescending(zahl => zahl).Take(ausgabeAnzahlEintrag).ToList();

            foreach (var x in output)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            Console.WriteLine();
        }
        static void Aufgabe10()
        {
            //Aufgabe 10: Lasse den Nutzer einen Satz eingeben, in welchen er bestimmte Wörter in UPPER CASE schreibt. 
            //Gebe anschließend nur die Wörter aus welche komplett mit UPPERCASE geschrieben wurden.

            Console.WriteLine($"Bitte gebe einen Satz ein und schreibe hierbei ein paar Wörter in UPPERCASE:");
            string str = Console.ReadLine();
            string transformed = str.Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("!", "").Replace("?", "");

            //List<string> words = new List<string>() { str };
            var upperCase = transformed.Split(' ').Where(x => String.Equals(x, x.ToUpper()));

            Console.WriteLine($"Das sind deine Großgeschriebenen Wörter:");

            foreach (var y in upperCase)
            {
                Console.WriteLine(y);
            }
        }
        static void Aufgabe11()
        {
            //Aufgabe 11: Speichere die Werte des angegeben String[] in einem gesamten String mit einem Komma separiert.
            //Gebe diesen String anschließend aus.

            string[] arr1 = new string[4] { "cat", "dog", "cow", "tiger" };

            string newstring = String.Join(", ", arr1.Select(s => s.ToString()));

            Console.WriteLine(newstring);
        }

        static void Aufgabe12()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = "Joseph", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            var queryPoints = from student in stulist
                              group student by student.GrPoint into newGroup
                              orderby newGroup.Key descending
                              select newGroup;

            List<int> points = new List<int>();
            foreach (var student in queryPoints)
            {
                points.Add(student.Key);
            }

            Console.WriteLine($"Welche Maximale Punktzahl suchst du? 1, 2, 3, 4, 5, 6?");
            int rang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Das sind die Studenten mit den jeweiligen Punkten:");
            foreach (Students s in stulist)
            {
                if (s.GrPoint == points[rang - 1])
                {
                    Console.WriteLine(s.StuName + " " + s.GrPoint + " Punkte");
                }
            }
        }
        /*static void Aufgabe13()
        {
            //Zähle die Anzahl der jeweiligen File-Extensions im gegebenen Array.
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };




            Console.WriteLine($"{count} File(s) with {extension} Extension")
        }*/
        static void Aufgabe14und15()
        {
            //Entferne ein Element mittels der Remove Methode indem du davor über FirstOrDefault das Element „o“ erst findest.
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");

            var firstO = listOfString.FirstOrDefault(letter => letter == "o");

            listOfString.Remove(firstO);

            listOfString.Remove("p");

            foreach(var x in listOfString)
            {
                Console.WriteLine(x);
            }
        }
        static void Aufgabe16()
        {
            //Verkette die zwei Arrays indem das erste Element der ersten Liste mit dem ersten Element der zweiten Liste(2.Element der 1.Liste mit 2.Element der 2.Liste ….) als String gespeichert wird. 
            var set1 = new string[] { "X", "Y", "Z" };
            var set2 = new int[] { 1, 2, 3 };
            //var result1 = string.Join("", set1).ToCharArray();
            //var result2 = string.Join("", set2).ToCharArray();

            var query = set1.Select((listone, index) => (listone, set2[index]));

            foreach (var x in query)
            {
                Console.WriteLine(x);
            }
        }
        static void Aufgabe17()
        {
            var set1 = new string[] { "X", "Y", "Z" };
            var set2 = new int[] { 1, 2, 3 };

            var queryTest = from charackter in set1
                            from sequence in set2
                            select charackter + sequence;

            var testtest = queryTest.Aggregate((concat, name) => concat + name);

            Console.WriteLine(testtest);
        }
        static void AufgabeSheet1()
        {
            int[] digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var query = from num in digits
                        where (num % 2) == 0
                        select num;



            foreach (var xy in query)
            {
                Console.WriteLine(xy);
            }
        }
        static void AufgabeSheet2()
        {
            int[] digits = new int[] { 0, -1, 2, 3, -4, 5, -6, 7, -8, 9, 10, 11 };

            var query = from num in digits
                        where num > 0
                        where num < 12
                        select num;

            foreach(var y in query)
            {
                Console.WriteLine(y);
            }

        }
        static void AufgabeSheet3()
        {
            int[] digits = new int[] { 2, 5, 6, 8, 9, 10, 15 };

            var query = from num in digits
                        where num * num > 40
                        select num;

            foreach(var x in query)
            {
                Console.WriteLine($"{x} => {x * x}");
            }
        }
        static void AufgabeSheet20()
        {
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");

            listOfString.RemoveAt(3);

            foreach(var sign in listOfString)
            {
                Console.WriteLine(sign);
            }
        }
        static void AufgabeSheet21()
        {
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");

            listOfString.RemoveRange(1, 3);

            foreach(var sign in listOfString)
            {
                Console.WriteLine(sign);
            }
        }
        static void AufgabeSheet22()
        {
            string[] str = new string[] { "this", "is", "a", "string" };

            Console.WriteLine("Input the minimu Lenght the string you want to find:");
            int lenght = Convert.ToInt32(Console.ReadLine());

            var query = from s in str
                        where s.Length >= lenght
                        orderby s.Length
                        select s;

            foreach(var y in query)
            {
                Console.WriteLine(y);
            }
        }
        internal class Item_mast
        {
            public int ItemId { set; get; }
            public string ItemDes { set; get; }

            
        }
        internal class Purchase
        {
            public int InvNo { get; set; }
            public int ItemId { get; set; }
            public int PurQty { get; set; }

            
        }
        static void AufgabeSheet25()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
                new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
                new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
                new Item_mast { ItemId = 3, ItemDes = "Butter   " },
                new Item_mast { ItemId = 4, ItemDes = "Brade    " },
                new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };
        
            List<Purchase> purchlist = new List<Purchase>
            {
                new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
                new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
                new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
                new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
                new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };


            var innerjoin = from i in itemlist
                            join p in purchlist
                            on i.ItemId equals p.ItemId
                            select new
                            {
                                a = i.ItemId,
                                b = i.ItemDes,
                                c = p.PurQty
                            };

            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("--------------------------------------------------");

            foreach (var data in innerjoin)
            {
                Console.WriteLine(data.a + "\t\t" + data.b + "\t" + data.c);
            }
        }
        static void AufgabeSheet26()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
                new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
                new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
                new Item_mast { ItemId = 3, ItemDes = "Butter   " },
                new Item_mast { ItemId = 4, ItemDes = "Brade    " },
                new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
                new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
                new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
                new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
                new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
                new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            var result = from i in itemlist
                         join p in purchlist
                         on i.ItemId equals p.ItemId into iGroup
                         from p in iGroup.DefaultIfEmpty()
                         select new
                         {
                             a = i.ItemId,
                             b = i.ItemDes,
                             c = p == null ? 0 : p.PurQty
                         };

            foreach (var data in result) 
            {
                Console.WriteLine(data.a + "\t\t" + data.b + "\t" + data.c);
            }
        }
        static void AufgabeSheet27()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
                new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
                new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
                new Item_mast { ItemId = 3, ItemDes = "Butter   " },
                new Item_mast { ItemId = 4, ItemDes = "Brade    " },
                new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
                new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
                new Purchase { InvNo=101, ItemId = 5,  PurQty = 650 },
                new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
                new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
                new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
                new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            var result = from p in purchlist
                         join i in itemlist
                         on p.ItemId equals i.ItemId 
                         into z
                         from b in z.DefaultIfEmpty()
                         select new
                         {
                             a = b.ItemId,
                             b = b.ItemDes,
                             //c = p == null ? 0 : p.PurQty
                             c = p.PurQty
                         };

            foreach (var data in result)
            {
                Console.WriteLine(data.a + "\t\t" + data.b + "\t" + data.c);
            }

        }
        static void AufgabeSheet28()
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS", "NEY YORK"
            };

            var query = from s in cities
                        orderby s.Length
                        select s;

            foreach(var c in query)
            {
                Console.WriteLine(c);
            }


        }
        static void AufgabeSheet29()
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS", "NEW YORK"
            };

            var query = from city in Enumerable.Range(0, cities.Length)
                        group cities[city] by city / 3;

            foreach (var x in query)
                cityView(string.Join("; ", x.ToArray()));

        }
        static void cityView(string xyz)
        {
            Console.WriteLine(xyz);
            Console.WriteLine("-- here is a group of cities --\n");
        }
        static void AufgabeSheet30()
        {
            var query = (from c in Item_Mast.GetItemMast()
                        select c.ItemDes)
                        .Distinct()
                        .OrderBy(x => x).ToList();
                
                
                

            foreach(var y in query)
            {
                Console.WriteLine(y);
            }
        }
        class Item_Mast
        {
            public int ItemId { get; set; }
            public string ItemDes { get; set; }

            public static List<Item_Mast> GetItemMast()
            {
                List<Item_Mast> itemlist = new List<Item_Mast>();
                itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
                itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
                itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
                itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
                itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
                itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
                return itemlist;
            }
        }
    }
}
