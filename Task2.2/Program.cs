using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, categories;
            Console.OutputEncoding = Encoding.UTF8;
            List<Production> production = new List<Production>();
            production.Add(new Production("Dina")
                {
                    Categories = new List<string>()
                    {
                        "Food",
                        "Games",
                        "Medicines",
                    }
            });
            production.Add(new Production("Svitlana")
            {
                Categories = new List<string>()
                {
                    "Home",
                    "Clothes",
                    "Sport",
                }
            });
            production.Add(new Production("Anatolii")
            {
                Categories = new List<string>()
                {
                    "Food",
                    "Medicines",
                    "Clothes",
                }
            });

            Production.ShowProduction(production);
            Console.WriteLine("\nВведіть ім'я покупця, якого хочете додати");
            name = Console.ReadLine();

            Console.WriteLine("\nВведіть категорію товарів, яку хочете додати");
            categories = Console.ReadLine();

            Production.AddBayer(production,name,categories);
            Production.ShowProduction(production);

            Console.WriteLine("\nВведіть ім'я покупця, категорії товарів якого ви бажаєте отримати");
            name = Console.ReadLine();

            Console.WriteLine($"Покупець {name} має такі категорії товарів:");
            Production.ShowProductionByName(production,name);

            Console.WriteLine("\nВведіть назву категорії, щоб побачити, хто її купував");
            categories = Console.ReadLine();

            Console.WriteLine($"{categories} купували такі покупці:");
            Production.ShowByersByCategory(production, categories);
            Console.ReadLine();
        }
    }
}
