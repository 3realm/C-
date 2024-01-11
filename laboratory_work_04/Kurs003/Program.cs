using System;

namespace Kurs003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3. Матрицы по курсу «Основы программирования». \n" +
                              "Выполнил студент группы 6102 Боряков Никита ");
            Console.WriteLine();
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("  1 - \"Ввод и обработка матриц\"\n  " +
                              "2 - \"Перевод из двоичной системы счисления в десятичную\"\n  " +
                              "3 - \"Выход из программы\" ");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                        Console.WriteLine();
                        Console.WriteLine("  1 - \"Сложение матриц\"\n " + " 2 - \"Вычитание матриц\"\n " +
                                          " 3 - \"Умножение матрицы на число\"\n " + " 4 - \"Умножение матриц\"\n " +
                                          " 5 - \"Сравнить матрицы на равенство\"\n " + " 6 - \"Транспонирование матрицы\" ");

                        int n1 = Convert.ToInt32(Console.ReadLine());
                        switch (n1) 
                        {
                            case 1:
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите размерность квадратных матриц");
                                    Console.WriteLine("r: ");
                                    int r = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ввидите значения элементов первой матрицы");
                                    int[,] mas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas.GetLength(1); x++)
                                        {
                                            Console.Write(mas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Ввидите значения элементов второй матрицы");
                                    int[,] mas2 = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas2.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas2.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas2[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas2.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas2.GetLength(1); x++)
                                        {
                                            Console.Write(mas2[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Сумма двух матриц найдена");
                                    int[,] summas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < summas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < summas.GetLength(1); j++)
                                        {
                                            summas[i, j] = mas2[i, j] + mas[i, j];
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < summas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < summas.GetLength(1); x++)
                                        {
                                            Console.Write(summas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                }
                                break;

                                                                               
                            case 2:
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите размерность квадратных матриц");
                                    Console.WriteLine("r: ");
                                    int r = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ввидите значения элементов первой матрицы");
                                    int[,] mas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas.GetLength(1); x++)
                                        {
                                            Console.Write(mas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Ввидите значения элементов второй матрицы");
                                    int[,] mas2 = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas2.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas2.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas2[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas2.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas2.GetLength(1); x++)
                                        {
                                            Console.Write(mas2[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Разность двух матриц найдена");
                                    int[,] difference = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < difference.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < difference.GetLength(1); j++)
                                        {
                                            difference[i, j] = mas[i, j] - mas2[i, j];
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < difference.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < difference.GetLength(1); x++)
                                        {
                                            Console.Write(difference[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите размерность матрицы");
                                    Console.WriteLine("r: ");
                                    int r = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine();
                                    Console.WriteLine("Введите число, на которое хотите умножить матрицу");
                                    Console.WriteLine("X: ");
                                    int q = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ввидите значения элементов матрицы");
                                    int[,] mas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    Console.WriteLine("Произведение матрицы на число найдено");
                                    for (int y = 0; y < mas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas.GetLength(1); x++)
                                        {
                                            Console.Write(mas[y, x] * q + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите размерность квадратных матриц");
                                    Console.WriteLine("r: ");
                                    int r = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ввидите значения элементов первой матрицы");
                                    int[,] mas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas.GetLength(1); x++)
                                        {
                                            Console.Write(mas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Ввидите значения элементов второй матрицы");
                                    int[,] mas2 = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas2.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas2.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas2[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas2.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas2.GetLength(1); x++)
                                        {
                                            Console.Write(mas2[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Прозведение двух матриц найдено");
                                    int[,] comp = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < comp.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < comp.GetLength(1); j++)
                                        {
                                            for (int l = 0; l < comp.GetLength(1); l++)
                                            {
                                                comp[i, j] += mas[i, k] * mas2[k, j];
                                            }     
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < comp.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < comp.GetLength(1); x++)
                                        {
                                            Console.Write(comp[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите размерность квадратных матриц");
                                    Console.WriteLine("r: ");
                                    int r = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ввидите значения элементов первой матрицы");
                                    int[,] mas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas.GetLength(1); x++)
                                        {
                                            Console.Write(mas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("Ввидите значения элементов второй матрицы");
                                    int[,] mas2 = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas2.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas2.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas2[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas2.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas2.GetLength(1); x++)
                                        {
                                            Console.Write(mas2[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine();
                                    Console.WriteLine("________________");
                                    int[,] difference = new int[r, r];
                                    Console.WriteLine();
                                    int sum = 0; 
                                    for (int i = 0; i < difference.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < difference.GetLength(1); j++)
                                        {
                                            difference[i, j] = mas[i, j] - mas2[i, j];
                                            if (difference[i, j] == 0 && i==j)
                                            {
                                                sum++;
                                            }
                                        }
                                    }

                                    if (sum == difference.GetLength(0))
                                    {
                                        Console.WriteLine("Матрицы равны");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Матрицы не равны");
                                    }
                                    Console.WriteLine();
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Введите размерность матрицы");
                                    Console.WriteLine("r: ");
                                    int r = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ввидите значения элементов матрицы");
                                    int[,] mas = new int[r, r];
                                    Console.WriteLine();
                                    for (int i = 0; i < mas.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < mas.GetLength(1); j++)
                                        {
                                            Console.WriteLine("y" + i + " x" + j);
                                            mas[i, j] = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine();

                                    for (int y = 0; y < mas.GetLength(0); y++)
                                    {
                                        for (int x = 0; x < mas.GetLength(1); x++)
                                        {
                                            Console.Write(mas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();

                                    Console.WriteLine("Транспонированная матрица найдена");
                                    Console.WriteLine();
                                    for (int x = 0; x < mas.GetLength(0); x++)
                                    {
                                        for (int y = 0; y < mas.GetLength(1); y++)
                                        {
                                            Console.Write(mas[y, x] + "\t");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                }
                                break;

                            default:
                                {
                                    Console.WriteLine("Несуществующий пункт. Повторите ввод");
                                    Console.ReadKey();
                                }
                                break;
                        }

                    }
                    break;
                case 2:
                    {
                        int s, len, c;
                        double result;
                        c = 0;
                        result = 0;
                        Console.WriteLine("Введите натуральное число в десятичной системе счисления ");
                        s = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n_________________");
                        len = s;
                        while (len > 0)
                        {
                            len /= 2;
                            c += 1;
                        }
                        if (c % 9 == 1)
                            c += 8;
                        else if (c % 9 == 2)
                            c += 7;
                        else if (c % 9 == 3)
                            c += 6;
                        else if (c % 9 == 4)
                            c += 5;
                        else if (c % 9 == 5)
                            c += 4;
                        else if (c % 9 == 6)
                            c += 3;
                        else if (c % 9 == 7)
                            c += 2;
                        else if (c % 9 == 8)
                            c += 1;
                        int[] mass = new int[c];
                        Console.WriteLine();
                        Console.WriteLine("Перевод числа в двоичную системеу счисления ");
                        for (int i = 0; i < c; i++)
                        {
                            mass[i] = s % 2;
                            s /= 2;
                        }
                        for (int i = c - 1; i > -1; i--)
                        {
                            Console.Write(mass[i]);
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            int v = mass[i];
                            mass[i] = mass[6 + i];
                            mass[6 + i] = v;
                        }
                        Console.WriteLine("\nРезультат после смены триад: ");
                        for (int i = c - 1; i > -1; i--)
                        {
                            Console.Write(mass[i]);
                        }
                        for (int i = 0; i < c; i++)
                        {
                            if (mass[i] == 1)
                            {
                                result += Math.Pow(2, i);
                            }
                        }
                        Console.WriteLine("\n_________________");
                        Console.WriteLine("\nЧисло в десятичной системе счисления: " + result);
                        Console.ReadLine();
                    }
                    break;

                case 3:
                    break;

                default:
                    {
                        Console.WriteLine("Несуществующий пункт. Повторите ввод");
                        Console.ReadKey();
                    }
                    break;


            }

        }
    }
}
