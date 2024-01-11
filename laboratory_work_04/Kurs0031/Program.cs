using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kurs0031

{
    class Count
    {
        public int max;
        public int min;
        public int now;
        public Count()
        {
            max = 10;
            min = 0;
            now = 8;
        }
        public Count(int max, int min, int now)
        {
            this.max = max;
            this.min = min;
            this.now = now;
        }
        public void Increase()
        {
            if (now == max)
            {
                now = min;
            }
            else
            {
                now++;
            }
        }
        public void Decrease()
        {
            if (now == min)
            {
                now = max;
            }
            else
            {
                now--;
            } 
        }
        public void ToConsole()
        {
            Console.WriteLine("Текущее положение счётчика: {0}, Границы счётчика [{1},{2}]", now, min, max);
        }
    }

    class Polynom
    {
        public int a;
        public int b;
        public int c;

        public Polynom()
        {
            a = 4;
            b = 3;
            c = 1;
        }
        public Polynom(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Resultat()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (a != 0)
            {
                if (d > 0)
                {
                    Console.WriteLine("x1 = " + Convert.ToString((-b + Math.Sqrt(d)) / (2 * a)) + " x2 = " + Convert.ToString((-b - Math.Sqrt(d)) / (2 * a)));
                }
                else if (d < 0)
                {
                    Console.WriteLine("Решений нет");
                }
                else
                {
                    Console.WriteLine ("x = " + Convert.ToString(-b / (2 * a)));
                }
            }
            if (a == 0)
            {
                Console.WriteLine("x = " + Convert.ToString((double)-c / b));
            }

        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №4. Матрицы по курсу « Простейшие классы ». \n" +
                              "Выполнил студент группы 6102 Боряков Никита ");
            Console.WriteLine();
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("  1 - \"Десятичный счетчик\"\n  " +
                              "2 - \"Многочлен\"\n  " +
                              "3 - \"Выход из программы\" ");
            Console.WriteLine("");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                        Console.Write("Введите левую границу: ");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите правую границу: ");
                        int max = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите положение точки: ");
                        int now = Convert.ToInt32(Console.ReadLine());
                        if (now > max && now < min)
                        {
                            Console.WriteLine(" Ошибка при вводе значения ");
                        }
                        else
                        {
                            Count r = new Count(max, min, now);
                            Console.WriteLine("");
                            r.ToConsole();
                            Console.WriteLine("Выберите пункт меню:");
                            Console.WriteLine("  1 - \"Увеличение\"\n  " +
                                              "2 - \"Уменьшение\"\n  " +
                                              "3 - \"Выход из программы\" ");
                            Console.WriteLine("");
                            int n = int.Parse(Console.ReadLine());
                            while (n != 3)
                            {
                                switch (n)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Увеличения значения счетчика");
                                            r.Increase();
                                            r.ToConsole();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Уменьшения значения счетчика");
                                            r.Decrease();
                                            r.ToConsole();
                                            break;
                                        }
                                }
                                Console.WriteLine("  1 - \"Увеличение\"\n  " +
                                             "2 - \"Уменьшение\"\n  " +
                                             "3 - \"Выход из программы\" ");
                                n = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите коэффициенты многочлена");
                        Console.Write("a: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("c: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Polynom s = new Polynom(a, b, c);
                        Console.WriteLine("");
                        s.Resultat();
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }
    }
}

