using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_work_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №7.\n" +
                              "Выполнил студент группы 6102 Боряков Никита ");
            Console.WriteLine();
            string s;
            Console.WriteLine("  1 - \"Вручную\"\n  " +
                                "2 - \"По умолчанию\"\n  ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.Write("Введите строку:");
                        s = Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        s = "Привет - самое распространённое приветствие, привет также можно передать.";
                        break;
                    }
                default:
                    Console.WriteLine("Некорректное значение");
                    s = Console.ReadLine();
                    break;
            }
            Console.WriteLine("  1 - \"Подсчитать количество букв в строке\"\n  " +
                                "2 - \"Подсчитать среднюю длину слова\"\n  " +
                                "3 - \"Замена заданного слова\"\n  " +
                                "4 - \"Подсчет количества вхождений подстроки\"\n  " +
                                "5 - \"Проверка на полиндром\"\n  " +
                                "6 - \"Проверка на дату\"\n  " +
                                "7 - \"Выход из программы\"\n ");

            int k = int.Parse(Console.ReadLine());
            while (k != 7)
            {
                switch (k)
                {
                    case 1:
                        {
                            Console.WriteLine("Подсчет количества букв в строке");
                            Console.WriteLine("#######################################");
                            Console.WriteLine("Введенная строка: {0}", s);
                            Console.WriteLine("\nКоличество букв в строке: {0} ", Stringmanipulation.NumberLetters(s.ToCharArray()));
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Подсчет средней длины слова");
                            Console.WriteLine("#######################################");
                            Console.WriteLine("Введенная строка: {0}", s);
                            Console.WriteLine("\nСредняя длина слова в строке: {0} ",Stringmanipulation.AverageLength(s));
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Замена заданного слова'");
                            Console.WriteLine("#######################################");
                            Console.WriteLine("Введенная строка: " + s);
                            Console.WriteLine("Введите слово, которое хотите заменить:");
                            string given = Console.ReadLine();
                            Console.WriteLine("Введите новое слово для замены:");
                            string ret = Console.ReadLine();
                            s = Stringmanipulation.ChangeWord(s, given, ret);
                            Console.WriteLine("Результат: {0}", s);
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Подсчет количества вхождений подстроки");
                            Console.WriteLine("#######################################");
                            Console.Write("Введите подстроку, вхождения которой необходимо подсчитать:");
                            string find = Console.ReadLine();
                            Console.WriteLine("Количество вхождений подстроки в строку \"{0}\": {1}", s, Stringmanipulation.CountWords(s, find));
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Проверка на палиндром");
                            Console.WriteLine("#######################################");
                            Console.WriteLine("Cтрока \"{0}\" {1}", s, Stringmanipulation.Polyndrom(s));
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Проверка на дату");
                            Console.WriteLine("#######################################");
                            Console.WriteLine("Cтрока \"{0}\" {1}", s, Stringmanipulation.Date(s));
                            Console.WriteLine("#######################################");
                            Console.ReadLine();
                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine("  1 - \"Подсчитать количество букв в строке\"\n  " +
                                               "2 - \"Подсчитать среднюю длину слова\"\n  " +
                                               "3 - \"Замена заданного слова\"\n  " +
                                               "4 - \"Подсчет количества вхождений подстроки\"\n  " +
                                               "5 - \"Проверка на полиндром\"\n  " +
                                               "6 - \"Проверка на дату\"\n  " +
                                               "7 - \"Выход из программы\"\n ");
                k = int.Parse(Console.ReadLine());
            }
        }
    }
}
