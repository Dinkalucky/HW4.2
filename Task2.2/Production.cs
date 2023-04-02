using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Production
    {
        public string Name { get; set; }
        public List<string> Categories { get; set; } = new List<string>();

        public Production(string name)
        {
            Name = name;
        }

        public static void ShowProduction(List<Production> production)
        {
            foreach (var p in production)
            {
                Console.WriteLine(p.Name);
                foreach (var c in p.Categories)
                {
                    Console.WriteLine("-"+ c);
                }
            }
            
        }

        public static void AddBayer(List<Production> production, string name, string category)
        {
            foreach (var p in production)
            {
                if (p.Name != name)
                {
                    production.Add(new Production(name)
                    {
                        Categories = new List<string>()
                        {
                            category
                        }
                    });
                    break;
                }
                else
                {
                    p.Categories.Add(category);
                    break;
                }
            }
            
        }

        public static void ShowProductionByName(List<Production> production,string name)
        {
            foreach (var p in production)
            {
                if (p.Name == name)
                {
                    foreach (var c in p.Categories)
                    {
                        Console.WriteLine("-" + c);
                    }
                }
                
            }

        }
        public static void ShowByersByCategory(List<Production> production, string category)
        {
            foreach (var p in production)
            {
                    foreach (var c in p.Categories)
                    {
                        if (category == c)
                        {
                            Console.WriteLine(p.Name);
                        }
                    }
                
            }

        }
    }
}
