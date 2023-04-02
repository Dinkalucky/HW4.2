using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary orderedDictionary1 = new OrderedDictionary();


            orderedDictionary1.Add(1, 23);
            orderedDictionary1.Add(2, 44);
            orderedDictionary1.Add(3, 64);
            orderedDictionary1.Add(4, 11);
            orderedDictionary1.Add(5, 21);

            int[] values1 = new int[orderedDictionary1.Values.Count];

            orderedDictionary1.Values.CopyTo(values1, 0);

            for (int i = 0; i < values1.Length; i++)
            {
                for (int j = 1; j < values1.Length; j++)
                {
                    if (values1[i] > values1[j])
                    {
                        Console.WriteLine(values1[i] + ">" + values1[j]);
                    }
                    else if (values1[i] < values1[j])
                    {
                        Console.WriteLine(values1[i] + "<" + values1[j]);
                    }
                    else if (values1[i] == values1[j])
                    {
                        Console.WriteLine(values1[i] + "==" + values1[j]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
