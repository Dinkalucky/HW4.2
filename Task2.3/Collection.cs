using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    public class Collection
    {
        public int Number { get; set; }
        public double Summa { get; set; }

        public Collection(int number, double summa)
        {
            Number = number;
            Summa = summa;
        }
    }
}
