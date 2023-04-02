using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(1, "d");
            list.Add(6, "j");
            list.Add(2, "m");
            list.Add(8, "a");
            list.Add(9, "z");

            var sortedList = list.OrderBy(v => v.Value);
            foreach (var l in sortedList)
            {
                Console.WriteLine(l.Key + " - " + l.Value);
            }

            Console.WriteLine("");
            var sortedListDescending = list.OrderByDescending(v => v.Value);
            foreach (var l in sortedListDescending)
            {
                Console.WriteLine(l.Key + " - " + l.Value);
            }

            Console.ReadLine();
        }
    }
}
