using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Decimal2
    {
        static public Decimal StDecimalSumm(Decimal a, Decimal b)
        {
            Decimal c = new Decimal();
            if (a.Y == b.Y)
            {
                c.X = a.X + b.X;
                c.Y = a.Y;
                return c;
            }
            else
            {
                c.X = a.X * b.Y + a.Y * b.X;
                c.Y = a.Y * b.Y;
                return c;
            }
        }
        static public Decimal StDecimalDifference(Decimal a, Decimal b)
        {
            Decimal c = new Decimal();
            if (a.Y == b.Y)
            {
                c.X = a.X - b.X;
                c.Y = a.Y;
                return c;
            }
            else
            {
                c.X = a.X * b.Y - a.Y * b.X;
                c.Y = a.Y * b.Y;
                return c;
            }
        }
        static public Decimal StDecimalProduct(Decimal a, Decimal b)
        {
            Decimal c = new Decimal();
            c.X = a.X * b.X;
            c.Y = a.Y * b.Y;
            return c;
        }
        static public Decimal StDecimalQuotient(Decimal a, Decimal b)
        {
            Decimal c = new Decimal();
            c.X = a.Y * b.X;
            c.Y = a.X * b.Y;
            return c;
        }
    }
}
