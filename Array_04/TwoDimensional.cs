using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
{
    internal class TwoDimensional
    {
        public int[,] two_array;

        public TwoDimensional(int x, int y)
        {
            Random random = new Random();
            two_array = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    two_array[i, j] = random.Next(10);
                }
            }

            for (int i = 0; i < two_array.GetLength(0); i++)
            {
                for (int j = 0; j < two_array.GetLength(1); j++)
                {
                    Console.Write($"{two_array[i, j]}\t");
                }
                Console.WriteLine();
            }

            bool[] rows = new bool[two_array.GetLength(0)];
            bool[] column = new bool[two_array.GetLength(1)];

            for (int i = 0; i < two_array.GetLength(0); i++)
            {
                for (int j = 0; j < two_array.GetLength(1); j++)
                {
                    if (two_array[i, j] == 0)
                    {
                        rows[i] = true;
                        column[j] = true;
                    }
                }
            }

            Console.WriteLine("Измененный\n");

            for (int i = 0; i < two_array.GetLength(0); i++)
            {
                for (int j = 0; j < two_array.GetLength(1); j++)
                {
                    if (rows[i] == true || column[j] == true)
                    {
                        two_array[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < two_array.GetLength(0); i++)
            {
                for (int j = 0; j < two_array.GetLength(1); j++)
                {
                    Console.Write($"{two_array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }        
    }
}
