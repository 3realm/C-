using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_work_06
{
    class SortMas
    {
        private int[] may;
        public SortMas()
        {
            may = new int[1];
        }
        public SortMas(int a)
        {
            may = new int[a];
        }
        public int this[int ind]
        {
            get { return may[ind]; }
            set { may[ind] = value; }
        }
        public void MasEnter()
        {
            for (int i = 0; i < may.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент массива", i);
                string Enter = Console.ReadLine();
                while (!Int32.TryParse(Enter, out may[i]))
                {
                    Console.WriteLine("Неккоректный ввод, повторите");
                    Enter = Console.ReadLine();
                }
            }
        }
        public void BubbleSort()
        {
            Console.WriteLine("1 - сортировка по убыванию" +
                "\n2 - сортировка по возрастанию");
            string s = Console.ReadLine();
            while (s != "1" && s != "2")
            {
                Console.WriteLine("Повторите ввод");
                s = Console.ReadLine();
            }
            for (int i = 0; i < (may.Length - 1); i++)
            {
                for (int j = i + 1; j < may.Length; j++)
                {
                    if ((s == "1" && may[i] < may[j]) || (s == "2" && may[i] > may[j]))
                    {
                        int c = may[i];
                        may[i] = may[j];
                        may[j] = c;
                    }
                }
            }
        }
        public void ShakerSort()
        {
            Console.WriteLine("1 - сортировка по убыванию" +
                "\n2 - сортировка по возрастанию");
            string s = Console.ReadLine();
            while (s != "1" && s != "2")
            {
                Console.WriteLine("Повторите ввод");
                s = Console.ReadLine();
            }
            for (int i = 0; i < may.Length / 2; i++)
            {
                for (int j = i; j < may.Length - i - 1; j++)
                {
                    if ((s == "1" && may[j] < may[j + 1]) || (s == "2" && may[j] > may[j + 1]))
                    {
                        int c = may[j];
                        may[j] = may[j + 1];
                        may[j + 1] = c;
                    }
                }
                for (int j = may.Length - 2 - i; j > i; j--)
                {
                    if ((s == "1" && may[j] < may[j + 1]) || (s == "2" && may[j] > may[j + 1]))
                    {
                        int c = may[j];
                        may[j] = may[j - 1];
                        may[j - 1] = c;
                    }
                }
            }
        }
        public void ShellSort()
        {
            Console.WriteLine("1 - сортировка по убыванию" +
                "\n2 - сортировка по возрастанию");
            string s = Console.ReadLine();
            while (s != "1" && s != "2")
            {
                Console.WriteLine("Повторите ввод");
                s = Console.ReadLine();
            }
            int d = may.Length / 2;
            while (d >= 1)
            {
                for (int i = 0; i < may.Length; i++)
                {
                    for (int j = 0; j < may.Length - d; j++)
                    {
                        if ((s == "2" && may[j] > may[j + d]) || (s == "1" && may[j] < may[j + d]))
                        {
                            int c = may[j];
                            may[j] = may[j + d];
                            may[j + d] = c;
                        }
                    }
                }
                d = d / 2;
            }
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < may.Length; i++)
            {
                res += may[i] + " ";
            }
            return "Массив после обработки:\n" + res;
        }
    }
}
