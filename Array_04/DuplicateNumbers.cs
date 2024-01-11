using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
{
    internal class DuplicateNumbers
    {


        public  DuplicateNumbers()
        {
            Console.Write("Длина: ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[lenght];

            for (var i = 0; i < array.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nДубликаты: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[Math.Abs(array[i])] > 0)
                {
                    array[Math.Abs(array[i])] = -array[Math.Abs(array[i])];
                }
                else
                {
                    Console.Write($"{Math.Abs(array[i])} ");
                }
            }
        }


    }
}
