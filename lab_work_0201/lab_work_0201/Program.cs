using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1.\n" +
                              "Выполнил студент группы 6102 Боряков Никита\n ");            
            Console.WriteLine("Выберете режим работы\n" +
                "1 - Array Vector\n" +
                "2 - Vectors\n" +
                "3 - Выход из программы\n");


            int m = int.Parse(Console.ReadLine());
            while (m != 3)
            {
                switch (m)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во пространств:");
                            int count = int.Parse(Console.ReadLine());  
                            // Экземпляр класса
                            ArrayVektor v = new ArrayVektor(count);
                            
                            v.EnterVector();
                            Console.Clear();
                            Console.WriteLine(v.ToString());
                            Console.WriteLine("  1 - \"Установка элемнта по индексу\"\n  " +
                                                "2 - \"Чтение элемента массива\"\n  " +
                                                "3 - \"Получение модуля вектора\"\n  " +
                                                "4 - \"Подсчет суммы всех положительных элементов с четными номерами\"\n  " +
                                                "5 - \"Подсчёт суммы тех элементов массива, которые имеют нечетные номера и\"\n  " +
                                                     "\"одновременно меньше среднего значения всех модулей элементов массива\"\n  " +
                                                "6 - \"Подсчёт произведения всех четных положительных элементов\"\n  " +
                                                "7 - \"Подсчёт всех нечетных элементов (по значению), не делящихся на три\"\n  " +
                                                "8 - \"Сортировка иассива\"\n  " +
                                                "9 - \"Выход из программы\"\n ");

                            int k = int.Parse(Console.ReadLine());
                            while (k != 9)
                            {
                                switch (k)
                                {
                                    case 1:
                                        {
                                            Console.Write("Введите индекс элемента массива: ");
                                            int i = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Введите значение элемента массива: ");
                                            int value = Convert.ToInt32(Console.ReadLine());
                                            v.SetElement(i, value);
                                            Console.WriteLine(v.ToString());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введите индекс элемента массива: ");
                                            int ind = Convert.ToInt32(Console.ReadLine());
                                            v.GetElement(ind);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine(v.ToString());
                                            Console.WriteLine("Длина вектора = " + v.GetNorm());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {

                                            v.SumPositivesFromChetIndex();
                                            Console.WriteLine(v.ToString());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 5:
                                        {
                                            v.SumLessFromNechetIndex();
                                            Console.WriteLine(v.ToString());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 6:
                                        {
                                            v.MultiChet();
                                            Console.WriteLine(v.ToString());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 7:
                                        {
                                            v.MultiNechet();
                                            Console.WriteLine(v.ToString());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 8:
                                        {
                                            v.Sort();
                                            Console.WriteLine(v.ToString());
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                                Console.Clear();
                                Console.WriteLine("  1 - \"Установка элемнта по индексу\"\n  " +
                                                "2 - \"Чтение жлемента массива\"\n  " +
                                                "3 - \"Получение модуля вектора\"\n  " +
                                                "4 - \"Подсчет суммы всех положительных элементов с четными номерами\"\n  " +
                                                "5 - \"Подсчёт суммы тех элементов массива, которые имеют нечетные номера и\"\n  " +
                                                     "\"одновременно меньше среднего значения всех модулей элементов массива\"\n  " +
                                                "6 - \"Подсчёт произведения всех четных положительных элементов\"\n  " +
                                                "7 - \"Подсчёт всех нечетных элементов (по значению), не делящихся на три\"\n  " +
                                                "8 - \"Сортировка иассива\"\n  " +
                                                "9 - \"Выход из программы\"\n ");
                                k = int.Parse(Console.ReadLine());
                            }                            
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во пространств первого вектора:");
                            int count1 = int.Parse(Console.ReadLine());
                            // Экземпляр класса
                            ArrayVektor v1 = new ArrayVektor(count1);
                            v1.EnterVector();

                            Console.Write("Введите кол-во пространств второго вектора:");
                            int count2 = int.Parse(Console.ReadLine());
                            // Экземпляр класса
                            ArrayVektor v2 = new ArrayVektor(count1);
                            v2.EnterVector();

                            Console.Clear();
                            Console.WriteLine(v1.ToString());
                            Console.WriteLine(v2.ToString());
                            Console.WriteLine("  1 - \"Сложение векторов\"\n  " +
                                                "2 - \"Скалярное произведение векторов\"\n  " +
                                                "3 - \"Умножение вектора 1 на число\"\n  " +
                                                "4 - \"Умножение вектора 2 на число\"\n  " +
                                                "5 - \"Получение модуля вектора 1\"\n  " +
                                                "6 - \"Получение модуля вектора 2\"\n  " +
                                                "7 - \"Выход в главное меню\"\n  ");

                            int k = int.Parse(Console.ReadLine());
                            while (k != 7)
                            {
                                switch (k)
                                {
                                    case 1:
                                        {
                                            if (Vectors.Сontrol(v1, v2))
                                            {
                                                Console.WriteLine("Сумма = " + Vectors.Sum(v1, v2));
                                            }
                                            else
                                            {
                                                Console.WriteLine("Данные векторы нельзя сложить!");
                                            }
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (Vectors.Сontrol(v1, v2))
                                            {
                                                Console.WriteLine("Произведение = " + Vectors.Scalar(v1, v2));
                                            }
                                            else
                                            {
                                                Console.WriteLine("Данные векторы нельзя перемножить!");
                                            }
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Введите число, на которое хотите умножить массив: ");
                                            int value = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(v1 = Vectors.NumberMult(v1, value)); 
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Write("Введите число, на которое хотите умножить массив: ");
                                            int value = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(v2 = Vectors.NumberMult(v2, value));
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("Модуль вектора 1 = " + Vectors.GetNorm(v1));
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Модуль вектора 2 = " + Vectors.GetNorm(v2));
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                                Console.Clear();
                                Console.WriteLine("  1 - \"Сложение векторов\"\n  " +
                                                "2 - \"Скалярное произведение векторов\"\n  " +
                                                "3 - \"Умножение вектора 1 на число\"\n  " +
                                                "4 - \"Умножение вектора 2 на число\"\n  " +
                                                "5 - \"Получение модуля вектора 1\"\n  " +
                                                "6 - \"Получение модуля вектора 2\"\n  " +
                                                "7 - \"Выход в главное меню\"\n  ");
                                k = int.Parse(Console.ReadLine());
                            }
                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine("Выберете режим работы\n" +
                "1 - Array Vector\n" +
                "2 - Vectors\n" +
                "3 - Выход из программы\n");
                m = int.Parse(Console.ReadLine());
            }
        }  
    }
}
