using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted by Year:\n");
            SortedList<short, string> sortByYear = new SortedList<short, string>
            {
                { 2000, "C#" },
                { 1995, "Java" },
                { 1991, "Python" },
                { 1972, "C" },
                { 1985, "C++" }
            };

            foreach (KeyValuePair<short,string> item in sortByYear)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Sorted by Name:\n");
            SortedList<string, short> sortByName = new SortedList<string, short>
            {
                { "C#", 2000 },
                { "Java", 1995 },
                { "Python", 1991 },
                { "C", 1972 },
                { "C++", 1985 }
            };


            foreach (KeyValuePair<string,short> item in sortByName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
