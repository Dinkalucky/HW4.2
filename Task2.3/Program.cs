using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,double> dictionary = new Dictionary<int,double>();

            dictionary.Add(111222, 4563.9);
            dictionary.Add(422123, 3133.7);
            dictionary.Add(432113, 5432.9);
            dictionary.Add(834957, 9765.3);

            Console.WriteLine("Словник");
            Console.WriteLine("Рахунок - Сума");
            foreach (var d in dictionary)
            {
                Console.WriteLine(d.Key+ " - " + d.Value + "грн");
            }
            
            List<Collection> list = new List<Collection>();

            list.Add(new Collection(422123, 3133.7));
            list.Add(new Collection(837485, 3467.5));
            list.Add(new Collection(123283, 8664.1));
            list.Add(new Collection(119834, 8754.6));

            Console.WriteLine("Список");
            Console.WriteLine("Рахунок - Сума");
            foreach (var d in list)
            {
                Console.WriteLine(d.Number + " - " + d.Summa + "грн");
            }

            Console.ReadLine();
        }
    }
}
