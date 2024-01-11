using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Other other = new Other();

            Console.WriteLine("Для начала работы программы введите кол-во элеметов в связном списке: ");
            int vector = int.Parse(Console.ReadLine());
            Console.Clear();

            NodeList nodeList = new NodeList(vector);
            Console.Clear();

            Console.WriteLine("Список элементов: " + nodeList.ToString());
            other.Menu();

            int n = int.Parse(Console.ReadLine());
            while (n != 4)
            {
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        Random random = new Random();
                        int value = random.Next(0, nodeList.Length - 1);
                        nodeList.MakingLoop(value);

                        nodeList.FindingLoop(vector*2);

                        Console.WriteLine("\nНачало петли найдено. Это элемент под индексом: {0}", value);
                        nodeList.StartLoop();
                        break;

                    case 2:
                        Console.WriteLine("\nУдаление дубликат");
                        nodeList.RemoveDuplicates();
                        nodeList.Loop();
                        break;

                    case 3:
                        Console.WriteLine("\nВведите с конца списка k-ую позицию для нахождения элемента: ");
                        int position = int.Parse(Console.ReadLine());
                        Console.WriteLine(nodeList.SearchingEndElements(position)); 
                        break;

                    case 0:
                        Console.Clear();

                        Console.WriteLine("Список элементов: " + nodeList.ToString());
                        other.Settings();

                        int s = int.Parse(Console.ReadLine());  

                        while (s != 6)
                        {
                            switch (s)
                            {
                                case 1:
                                    other.Add();
                                    int count_1 = int.Parse(Console.ReadLine());
                                    nodeList.AddElemebt(count_1);
                                    break;

                                case 2:
                                    other.Add();
                                    int count_2 = int.Parse(Console.ReadLine());
                                    nodeList.AddFirstElement(count_2);
                                    break;

                                case 3:
                                    other.Add();
                                    int count_3 = int.Parse(Console.ReadLine());
                                    nodeList.RemoveElement(count_3);                                    
                                    break;

                                case 4:
                                    other.Add();
                                    nodeList.RemoveEndElement();
                                    break;

                                case 5:
                                    other.Add();
                                    nodeList.RemoveStartElement();
                                    break;

                                default:
                                    Console.WriteLine("Данного пункта в меню нет");
                                    break;
                            }
                            Console.Clear();

                            Console.WriteLine("Список элементов: " + nodeList.ToString());
                            other.Settings();
                            s = int.Parse(Console.ReadLine());
                        }
                        break;

                    default:
                        Console.WriteLine("Данного пункта в меню нет");
                        break;
                }
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Список элементов: " + nodeList.ToString());
                other.Menu();
                n = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
