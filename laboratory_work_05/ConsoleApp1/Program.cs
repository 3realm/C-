using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5.\n" +
                              "Выполнил студент группы 6102 Боряков Никита ");
            Console.WriteLine();
            Console.WriteLine("Введите значение первой дроби");
            Decimal d = new Decimal();
            d.InputXY();
            d.ConsoleXY();
            Console.WriteLine("");
            Console.WriteLine("Введите значение второй дроби");
            Decimal d1 = new Decimal();
            d1.InputXY();
            d1.ConsoleXY();
            Console.WriteLine("");
            Console.WriteLine("  1 - \"Нестатические методы\"\n  " +
                                "2 - \"Статические методы\"\n  " +
                                "3 - \"Выход из программы\" ");
            int n = int.Parse(Console.ReadLine());
            while (n != 3)
            {
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("  1 - \"Сложение\"\n  " +
                                                    "2 - \"Вычитание\"\n  " +
                                                    "3 - \"Умножение\"\n  " +
                                                    "4 - \"Деление\"\n  " +
                                                    "5 - \"Выход из программы\" ");
                            int k1 = int.Parse(Console.ReadLine());
                            while (k1 != 5)
                            {
                                switch(k1)
                                {
                                    case 1:
                                        {
                                            Decimal result = new Decimal();
                                            result = d.DecimalSumm(d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Decimal result = new Decimal();
                                            result = d.DecimalDifference(d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Decimal result = new Decimal();
                                            result = d.DecimalProduct(d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Decimal result = new Decimal();
                                            result = d.DecimalQuotient(d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                                Console.WriteLine("  1 - \"Сложение\"\n  " +
                                                    "2 - \"Вычитание\"\n  " +
                                                    "3 - \"Умножение\"\n  " +
                                                    "4 - \"Деление\"\n  " +
                                                    "5 - \"Выход из программы\" ");
                                k1 = Convert.ToInt32(Console.ReadLine());
                            }
                                break; 
                        }
                    case 2:
                        {
                            Console.WriteLine("  1 - \"Сложение\"\n  " +
                                                    "2 - \"Вычитание\"\n  " +
                                                    "3 - \"Умножение\"\n  " +
                                                    "4 - \"Деление\"\n  " +
                                                    "5 - \"Выход из программы\" ");
                            int k2 = int.Parse(Console.ReadLine());
                            while (k2 != 5)
                            {
                                switch (k2)
                                {
                                    case 1:
                                        {
                                            Decimal result = new Decimal();
                                            result = Decimal2.StDecimalSumm(d, d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Decimal result = new Decimal();
                                            result = Decimal2.StDecimalDifference(d, d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Decimal result = new Decimal();
                                            result = Decimal2.StDecimalProduct(d, d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Decimal result = new Decimal();
                                            result = Decimal2.StDecimalQuotient(d, d1);
                                            result.ConsoleXY();
                                            Console.WriteLine("");
                                            result.NOD();
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                                Console.WriteLine("  1 - \"Сложение\"\n  " +
                                                    "2 - \"Вычитание\"\n  " +
                                                    "3 - \"Умножение\"\n  " +
                                                    "4 - \"Деление\"\n  " +
                                                    "5 - \"Выход из программы\" ");
                                k2 = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        }
                }
                Console.WriteLine("  1 - \"Нестатические методы\"\n  " +
                                "2 - \"Статические методы\"\n  " +
                                "3 - \"Выход из программы\" ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
