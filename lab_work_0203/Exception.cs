using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0203
{
    internal class Exception
    {
        public static int Exception_1()
        {
            int n = 0;
            bool key = true;
            while (key)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        key = false;
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат, повторите ввод");
                    }
                }
                catch {Console.WriteLine("Неверный формат, повторите ввод");}
            }
            return n;
        }
    }
}
