using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_work_06
{
    class StepMas
    {
        int t;
        public int[][] stmay; 
        public int[] may;  
        public StepMas(int t)
        {
            T = t;
            stmay = new int[t][];
            may = new int[T];
        }
        public int T
        {
            get { return t; }
            set { t = value; }
        }
        public void InputStMas()
        {
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("#######################################");
                Console.WriteLine("\nМассив №{0}", i + 1);
                Console.Write("Введите количество строк в {0}-ом массиве:", i + 1);
                int k = Convert.ToInt32((Console.ReadLine()));
                stmay[i] = new int[k];
                may[i] = k;
                for (int j = 0; j < k; j++)
                {

                    Console.WriteLine("\nВведите {0}-е значение массива", j + 1);
                    stmay[i][j] = Convert.ToInt32((Console.ReadLine()));
                }
            }
        }
        public void Onedimensional()
        {
            int count = 0; //количество позиций одномерного массива
            int ii = 0;
            for (int i = 0; i < T; i++)
            {
                count += stmay[i].Length;
            }
            int[] soloarr = new int[count];
            Console.WriteLine("#######################################");
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < stmay[i].Length; j++)
                {
                    soloarr[ii] = stmay[i][j];
                    Console.Write(soloarr[ii] + " ");
                    ii += 1;
                }
            }
            for (int i = 0; i < ii - 1; i++)
            {
                for (int j = i + 1; j < ii; j++)
                {
                    if (soloarr[i] > soloarr[j])
                    {
                        int vv = soloarr[i];
                        soloarr[i] = soloarr[j];
                        soloarr[j] = vv;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("#######################################");
            Console.WriteLine("Одномерный массив после сортировки:");
            for (int i = 0; i < soloarr.Length; i++)
            {
                Console.Write(soloarr[i] + " ");
            }
            ii = 0;
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < may[i]; j++)
                {
                    stmay[i][j] = soloarr[ii];
                    ii += 1;
                }
            }

        }
        public void StepParametr()
        {
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < stmay[i].Length; j++)
                {
                    Console.Write("{0,5:0}", stmay[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
