using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Section 2: Eliminating Duplicates in C# HashSet

            Console.WriteLine("===============================================================");
            Console.WriteLine("Section 2: Eliminating Duplicates in C# HashSet");            
            Console.WriteLine("===============================================================");

            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeated) 
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };

            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            
            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);
            
            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            
            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            //Section 3: Modify HashSet Using UnionWith() Method

            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Section 3: Modify HashSet Using UnionWith() Method");
            Console.WriteLine("===============================================================");

            string[] names1 = new string[] {
                "mahesh","sabnis","manish","sharma","saket","karnik"
            };

            string[] names2 = new string[] {
                "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
            };
            
            //2.

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

            //Section 4: Modify Hashset Using ExceptWith() Method

            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Section 4: Modify Hashset Using ExceptWith() Method");
            Console.WriteLine("===============================================================");

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

            //Section 5: Modify Hashset using SymmetricExceptWith() method

            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Section 5: Modify Hashset using SymmetricExceptWith() method");
            Console.WriteLine("===============================================================");

            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

            //Section 6: Checking performance of operations like Add, Remove, Contains on HashSet vs List.

            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Section 6: Checking performance of operations like Add, Remove, Contains on HashSet vs List.");
            Console.WriteLine("===============================================================");


            Get_Add_Performance_HashSet_vs_List();

            //HashSets are slower to add elements, as it has to check whether there already exists an element equal to it in the HashSet.
            //Lists add the elements regardless of whether or not an elements equal to it exists in the List.

            Get_Contains_Performance_HashSet_vs_List();

            //HashSets are faster to look up elements, as there are no duplicate data in the HashSet.
            //Lists are slower, as there can be multiple duplicates in the list, thus requiring more time to look up.

            Get_Remove_Performance_HashSet_vs_List();

            //HashSets are also faster to remove elements, as it works in the same way as the Contains operation.
            //The amount of time used by the HashSet to remove elements is the exact same amount of time, it used to look up elements.
            //Lists are still slower to remove elements, but it is even slower at removing than looking up elements.
            //This makes sense, as it would take longer to remove the elements that it would only to look it up.

            Console.ReadLine();
        }

        static string[] names = new string[] {
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
            "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
            "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
            "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
            "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
            "Leena", "Neema", "Sita",
            "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis"};

        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }

        static void Get_Contains_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Contains(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Contains(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }

        static void Get_Remove_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Remove(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Remove(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }
    }
}