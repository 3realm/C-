using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Other other = new Other();
            other.Menu();

            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                switch (n)
                {
                    case 1:
                        {
                            DoWithRepeats();
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            DoRepeats();
                            Console.ReadKey();
                            break;
                        }

                    default:
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                other.Menu();
                n = int.Parse(Console.ReadLine());
            }



        }

        public static void DoWithRepeats()
        {
            Item[] items = { new Item(5, 8), new Item(2, 1) };

            Console.WriteLine("\n---Список предметов---: ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i}-ый: {items[i]}");
            }

            Console.Write("\nВвведите объем рюкзака: ");

            int size = int.Parse(Console.ReadLine());
            int[] opticalCost = new int[size + 1];

            opticalCost[0] = 0;

            for (int i = 1; i < opticalCost.Length; i++)
            {
                opticalCost[i] = opticalCost[i - 1];
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[j].Mass <= i)
                    {
                        opticalCost[i] = Math.Max(opticalCost[i], items[j].Cost + opticalCost[i - items[j].Mass]);
                    }
                }
            }

            Console.WriteLine($"\nЛучшая итоговая стоимость: {opticalCost[opticalCost.Length - 1]}");
        }

        public static void DoRepeats()
        {
            Item[] items = CreateList();
            ShowListItems(items);
            Console.Write("\nВвведите объем рюкзака: ");

            int size = int.Parse(Console.ReadLine());
            int[,] opticalCost = new int[size + 1, items.Length];

            for (int i = 1; i < items.Length; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (items[i].Mass <= j)
                    {
                        opticalCost[j, i] = Math.Max(opticalCost[j, i - 1], opticalCost[j - items[i].Mass, i - 1] + items[i].Cost);
                    }
                    else
                    {
                        opticalCost[j, i] = opticalCost[j, i - 1];
                    }
                }
            }

            Console.WriteLine($"\nЛучшая итоговая стоимость: {opticalCost[size, items.Length - 1]}");
        }

        public static Item[] CreateList()
        {
            Item[] items = { new Item(0, 0), new Item(3, 5), new Item(2, 7), new Item(10, 4), new Item(1, 2) };
            return items;
        }

        public static void ShowListItems(Item[] items)
        {
            Console.WriteLine("\n---Список предметов---: ");
            for (int i = 1; i < items.Length; i++)
            {
                Console.WriteLine($"{i}-ый: {items[i]}");
            }
        }

    }

}

        



