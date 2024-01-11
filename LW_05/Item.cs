using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_05
{
    internal class Item
    {
        public int Cost { get; private set; }
        public int Mass { get; private set; }

        public Item()
        {
            Random random = new Random();
            Cost = random.Next(1, 10);
            Mass = random.Next(1, 10);
        }

        public Item(int cost, int mass)
        {
            Cost = cost;
            Mass = mass;
        }

        public override string ToString()
        {
            return $"масса = {Mass}, стоимость = {Cost}";
        }
    }
}
