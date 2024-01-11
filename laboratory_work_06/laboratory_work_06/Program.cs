using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_work_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №6.\n" +
                              "Выполнил студент группы 6102 Боряков Никита ");
            Console.WriteLine();
            Console.WriteLine("  1 - \"Сортировка\"\n  " +
                                "2 - \"Массивы\"\n  " +
                                "3 - \"Ступенчатые массивы\"\n  " +
                                "4 - \"Выход из программы\"\n ");

            int k = int.Parse(Console.ReadLine());
            while (k != 4)
            {
                switch (k)
                {
                    case 1:
                        {
                            Console.WriteLine("  1 - \"Метод пузырька\"\n  " +
                                "2 - \"Сортировка перемешиванием\"\n  " +
                                "3 - \"Сортировка Шелла\"\n  " +
                                "4 - \"Выход из программы\"\n ");
                            int l = int.Parse(Console.ReadLine());
                            while (l != 4)
                            {
                                switch (l)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введите размерность одномерного массива");
                                            int s = Convert.ToInt32(Console.ReadLine());
                                            SortMas sort = new SortMas(s);
                                            sort.MasEnter();
                                            Console.WriteLine();
                                            Console.WriteLine("#######################################");
                                            sort.BubbleSort();
                                            Console.WriteLine(sort);
                                            Console.WriteLine();
                                            Console.WriteLine("#######################################");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введите размерность одномерного массива");
                                            int s = Convert.ToInt32(Console.ReadLine());
                                            SortMas sort = new SortMas(s);
                                            sort.MasEnter();
                                            Console.WriteLine();
                                            Console.WriteLine("#######################################");
                                            sort.ShakerSort();
                                            Console.WriteLine(sort);
                                            Console.WriteLine();
                                            Console.WriteLine("#######################################");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Введите размерность одномерного массива");
                                            int s = Convert.ToInt32(Console.ReadLine());
                                            SortMas sort = new SortMas(s);
                                            sort.MasEnter();
                                            Console.WriteLine();
                                            Console.WriteLine("#######################################");
                                            sort.ShellSort();
                                            Console.WriteLine(sort);
                                            Console.WriteLine();
                                            Console.WriteLine("#######################################");
                                            break;
                                        }
                                }
                                Console.WriteLine("  1 - \"Метод пузырька\"\n  " +
                                "2 - \"Сортировка перемешиванием\"\n  " +
                                "3 - \"Сортировка Шелла\"\n  " +
                                "4 - \"Выход из программы\"\n ");
                                l = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Введите размерность матрицы:");
                            Console.WriteLine("Количество строк:");
                            int m = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Количество столбцов:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Размерность матрицы задана.");
                            Console.WriteLine("Матрица имеет размрность {0}*{1}.", m, n);
                            Console.WriteLine();
                            Console.WriteLine("#######################################");
                            MainMas result = new MainMas(m, n);
                            result.InputRandomMas();
                            result.Parametr();
                            Console.WriteLine("#######################################");
                            result.SortStolb();
                            Console.WriteLine();
                            Console.WriteLine("#######################################");
                            Console.WriteLine("Сортировка сумм столбцов по возрастанию");
                            result.SortMay1();
                            result.Parametr();
                             Console.WriteLine("#######################################");
                            Console.WriteLine("Сортировка сумм столбцов по убыванию");
                            result.SortMay2();
                            result.Parametr();
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Введите количество строк в ступенчатом массиве: ");
                            int t = int.Parse(Console.ReadLine());
                            StepMas step = new StepMas(t);
                            step.InputStMas();
                            Console.WriteLine("#######################################");
                            Console.WriteLine("\nВведенный ступенчатый массив\n");
                            step.StepParametr();
                            step.Onedimensional();
                            Console.WriteLine("#######################################");
                            Console.WriteLine("\nСортировка ступенчатого массива по возрастанию\n");
                            step.StepParametr();
                            break;
                        }
                }
                Console.WriteLine("  1 - \"Сортировка\"\n  " +
                                "2 - \"Массивы\"\n  " +
                                "3 - \"Ступенчатые массивы\"\n  " +
                                "4 - \"Выход из программы\"\n ");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
