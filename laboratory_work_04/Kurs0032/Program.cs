using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs0032
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[,];
            Random random = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = random.Next(-100, 100);
                }
            }

            for (int y = 0; y < mas.GetLength(0); y++)
            {
                for (int x = 0; x < mas.GetLength(1); x++)
                {
                    Console.Write(mas[x, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
