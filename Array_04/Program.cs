using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
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
                        Console.Clear();

                        int m = int.Parse(Console.ReadLine());
                        while (m != 0)
                        {
                            switch (m)
                            {
                                case 1:
                                    Stack stack1 = new Stack();
                                    Console.Write("Введите строку: ");
                                    if (stack1.RoundBrackets(Console.ReadLine()) == true)
                                    {
                                        Console.WriteLine("В строке верно расставлены скобки");
                                    }
                                    else
                                    {
                                        Console.WriteLine("НЕПРАВИЛЬНО расставлены скобки");
                                    }
                                    break;
                                case 2:
                                    Stack stack2 = new Stack();
                                    Console.Write("Введите строку: ");
                                    if (stack2.Brackets(Console.ReadLine()) == true)
                                    {
                                        Console.WriteLine("В строке верно расставлены скобки");
                                    }
                                    else
                                    {
                                        Console.WriteLine("НЕПРАВИЛЬНО расставлены скобки");
                                    }
                                    break;
                            }

                            Console.ReadLine();
                            Console.Clear();

                            m = int.Parse(Console.ReadLine());
                        }
            
                        break;

                    case 2:
                        Console.Clear();

                        RemadeStack remadeStack = new RemadeStack(10);

                        remadeStack.Push(8);
                        remadeStack.Push(3);
                        remadeStack.Push(5);
                        remadeStack.Push(4);
                        remadeStack.Push(5);
                        remadeStack.Push(6);

                        var count = remadeStack.Pop();
                        Console.WriteLine(count);

                        var minimum = remadeStack.Min();
                        Console.WriteLine(minimum);

                        Console.ReadLine();

                        break;

                    case 3:
                        Console.Clear();

                        Window window = new Window();

                        Console.Write("Длина: ");
                        int lenght3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Размер: ");
                        int size = Convert.ToInt32(Console.ReadLine());

                        int[] array3 = new int[lenght3];

                        for (var i = 0; i < array3.Length; ++i)
                        {
                            Console.Write("a[{0}] = ", i);
                            array3[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        List<int> result = window.KeepMaxInWindow(array3, size);

                        Console.WriteLine("Максимумы окон введенного размера");

                        foreach (int arr in result)
                        {
                            Console.WriteLine($"{arr} ");
                        }
                        break;

                    case 4:
                        Console.Clear();

                        DuplicateNumbers duplicateNumbers = new DuplicateNumbers();

                        break;

                    case 5:
                        Console.Clear();

                        Collection collection = new Collection();

                        Console.Write("Длина: ");
                        int lenght5 = Convert.ToInt32(Console.ReadLine());

                        int[] array5 = new int[lenght5];

                        for (var i = 0; i < array5.Length; ++i)
                        {
                            Console.Write("a[{0}] = ", i);
                            array5[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine(collection.Multiplication(array5));

                        break;

                    case 6:
                        Console.Clear();

                        Console.WriteLine("Введите размерность массива");

                        Console.Write("Количество строк:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Количество столбов:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();



                        TwoDimensional twoDimensional = new TwoDimensional(x, y);

                        break;


                    default:
                        Console.WriteLine("Данного пункта в меню нет");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                other.Menu();
                n = int.Parse(Console.ReadLine());
            }





        }
    }
}
