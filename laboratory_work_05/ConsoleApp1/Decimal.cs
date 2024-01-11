using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Decimal
    {
        private int x;
        private int y;

        public Decimal()
        {
            X = 1;
            Y = 3;
        }
        public Decimal(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { if (value == 0) y = 1; else y = value; }
        }
        public void InputXY()
        {
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());
        }
        public void ConsoleXY()
        {
            Console.WriteLine("\t{0}" + "\n\t---" + "\n\t{1}",X ,Y);

        }
        public void NOD()
        {
            if (X != 0 || Y  != 0)
            {
                int h = Math.Abs(X);
                int q = Math.Abs(Y);
                while (h != q)
                {
                    if (h > q)
                    {
                        h = h - q;
                    }
                    else
                    {
                        q = q - h;
                    }
                }
                if (Math.Abs(X) > Math.Abs(Y))
                {
                    X = X / h;
                    Y = Y / h;
                }
                else
                {
                    X = X / q;
                    Y = Y / q;
                }
                Console.WriteLine("\t{0}" + "\n\t---" + "\n\t{1}", X, Y);

            }
            else
            {
                 Console.WriteLine("\t{0}" + "\n\t---" + "\n\t{1}", X, Y);
            }
         
        }

        
        public Decimal DecimalSumm(Decimal a)
        {
            Decimal c = new Decimal();
            if (a.Y == Y)
            {
                c.X = a.X + X;
                c.Y = a.Y;
                return c;
            }
            else
            {
                c.X = a.X * Y + a.Y * X;
                c.Y = a.Y * Y;
                return c;
            }
        }
        public Decimal DecimalDifference(Decimal a)
        {
            Decimal c = new Decimal();
            if (a.Y == Y)
            {
                c.X = a.X - X;
                c.Y = a.Y;
                return c;
            }
            else
            {
                c.X = a.X * Y - a.Y * X;
                c.Y = a.Y * Y;
                return c;
            }
        }

        public Decimal DecimalProduct(Decimal a)
        {
            Decimal c = new Decimal();
            c.X = a.X * X;
            c.Y = a.Y * Y;
            return c;
        }

        public Decimal DecimalQuotient(Decimal a)
        {
            Decimal c = new Decimal();
            c.X = a.Y * X;
            c.Y = a.X * Y;
            return c;
        }
    }
}
