using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0204
{
    // Сложение векторов различных типов

    // Определение и контракт без реализации
    interface IVectorable
    {
        int this[int i]
        {
            get;
            set;
        }

        int Length { get; }

        double GetNorm();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2.\n" +
                              "Выполнил студент группы 6102 Боряков Никита\n ");
            Console.WriteLine("Выберете режим работы\n" +
                                "1 - Array Vector\n" +
                                "2 - Vectors\n" +
                                "3 - LinkedListVector\n" +
                                "4 - Выход из программы\n");


            int m = int.Parse(Console.ReadLine());
            while (m != 4)
            {
                switch (m)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во пространств:");
                            int count = int.Parse(Console.ReadLine());                            
                            ArrayVector v = new ArrayVector(count);
                            v.EnterVector();

                            Console.Clear();
                            Console.WriteLine(v.ToString());
                            Console.WriteLine("  1 - \"Чтение массива\"\n  " +
                                                "2 - \"Получение модуля вектора\"\n  " +
                                                "3 - \"Выход из программы\"\n ");

                            int k = int.Parse(Console.ReadLine());
                            while (k != 3)
                            {
                                switch (k)
                                {
                                    case 1:
                                        {
                                            v.ToString();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine(v.ToString());
                                            Console.WriteLine("Длина вектора = " + v.GetNorm());
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                                Console.Clear();
                                Console.WriteLine("  1 - \"Чтение элемента массива\"\n  " +
                                                "2 - \"Получение модуля вектора\"\n  " +
                                                "3 - \"Выход из программы\"\n ");
                                k = int.Parse(Console.ReadLine());
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.Write("Введите кол-во пространств первого вектора:");
                            int count1 = int.Parse(Console.ReadLine());                            
                            ArrayVector v1 = new ArrayVector(count1);
                            v1.EnterVector();

                            Console.Write("Введите кол-во пространств второго вектора:");
                            int count2 = int.Parse(Console.ReadLine());                            
                            LinkedListVector v2 = new LinkedListVector(count1);
                            v2.AddElement(count2);

                            Console.Clear();
                            Console.WriteLine(v1.ToString());
                            Console.WriteLine(v2.ToString());
                            Console.WriteLine("  1 - \"Сложение векторов\"\n  " +
                                                "2 - \"Скалярное произведение векторов\"\n  " +
                                                "3 - \"Получение модуля вектора 1\"\n  " +
                                                "4 - \"Получение модуля вектора 2\"\n  " +
                                                "5 - \"Выход в главное меню\"\n  ");

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
                                            Console.WriteLine("Модуль вектора 1 = " + Vectors.GetNorm(v1));
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Модуль вектора 2 = " + Vectors.GetNorm(v2));
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                                Console.Clear();
                                Console.WriteLine("  1 - \"Сложение векторов\"\n  " +
                                                    "2 - \"Скалярное произведение векторов\"\n  " +
                                                    "3 - \"Получение модуля вектора 1\"\n  " +
                                                    "4 - \"Получение модуля вектора 2\"\n  " +
                                                    "5 - \"Выход в главное меню\"\n  ");
                                k = int.Parse(Console.ReadLine());
                            }
                            break;
                        }

                        case 3:
                        {
                            
                            Console.Write("Введите кол-во элементов списка: ");
                            int x = int.Parse(Console.ReadLine());
                            LinkedListVector lis = new LinkedListVector(x);
                            Console.WriteLine("Ваш список: {0} ", lis);

                            Console.WriteLine("  1 - \"Метод получения элемента списка по индексу\"\n  " +
                                                "2 - \"Метод получения модуля\"\n  " +
                                                "3 - \"Метод удаления элемента в конце\"\n  " +
                                                "4 - \"Метод добавления элемента в конец\"\n  " +
                                                "5 - \"Метод удаления элемента в начале\"\n  " +
                                                "6 - \"Метод добавления элемента в начало\"\n  " +
                                                "7 - \"Метод удаления элемента по индексу\"\n  " +
                                                "8 - \"Метод добавления элемента по индексу\"\n  " +
                                                "9 - \"Выход в главное меню\"\n  ");
                            int k = int.Parse(Console.ReadLine());
                            while (k != 9)
                            {
                                switch (k)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введите индекс элемента массива: ");
                                            int ind = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Элемент: {0}", lis[ind]);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Длина вектора: {0} ", lis.GetNorm());
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            lis.DeletElementEnd();
                                            Console.WriteLine(lis);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            lis.AddElementEnd();
                                            Console.WriteLine(lis);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 5:
                                        {
                                            lis.DeleteElementStart();
                                            Console.WriteLine(lis);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 6:
                                        {
                                            lis.AddElementStart();
                                            Console.WriteLine(lis);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 7:
                                        {
                                            lis.DeleteInd();
                                            Console.WriteLine(lis);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 8:
                                        {
                                            lis.AddInd();
                                            Console.WriteLine(lis);
                                            Console.ReadLine();
                                            break;
                                        }

                                }
                                Console.Clear();
                                Console.WriteLine("  1 - \"Метод получения элемента списка по индексу\"\n  " +
                                                    "2 - \"Метод получения модуля\"\n  " +
                                                    "3 - \"Метод удаления элемента в конце\"\n  " +
                                                    "4 - \"Метод добавления элемента в конец\"\n  " +
                                                    "5 - \"Метод удаления элемента в начале\"\n  " +
                                                    "6 - \"Метод добавления элемента в начало\"\n  " +
                                                    "7 - \"Метод удаления элемента по индексу\"\n  " +
                                                    "8 - \"Метод добавления элемента по индексу\"\n  " +
                                                    "9 - \"Выход в главное меню\"\n  ");
                                k = int.Parse(Console.ReadLine());
                            }
                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine("Выберете режим работы\n" +
                    "1 - Array Vector\n" +
                    "2 - Vectors\n" +
                    "3 - LinkedListVector\n" +
                    "4 - Выход из программы\n");
                m = int.Parse(Console.ReadLine());

            }
        }
    }
}
