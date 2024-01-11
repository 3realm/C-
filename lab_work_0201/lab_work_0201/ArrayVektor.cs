using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0201
{
    class ArrayVektor
    {
        // Поле
        int[] coordinates;
        // Конструктор
        public ArrayVektor()
        {
            coordinates = new int[5];
        }
        public ArrayVektor(int count)
        {
            coordinates = new int[count];
        }
        // Индексатор
        public int this[int i]
        {
            get { return coordinates[i]; }
            set { coordinates[i] = value; }
        }
        // Св-во
        public int Length
        {
            get { return coordinates.Length; }
        }

        public void EnterVector()
        {
            Console.Write("Введите координаты:\n\n");
            for (int i = 0; i < coordinates.Length; i++)
            {
                  Console.Write("Значение {0} элемента:", i);
                  coordinates[i] = Convert.ToInt32(Console.ReadLine());
            }                                                                           
        }

        public void SetElement(int i, int number)
        {
            if (i >= 0 && i < coordinates.Length)
            {
                coordinates[i] = number;
            }
            else
            {
                Console.WriteLine("Введеный индекс находится за границей");
            }
        }

        public override string ToString()
        {
            
            string s = "( ";
            for (int i = 0; i < coordinates.Length; i++)
            {
                s += coordinates[i] + " ";
            }
            s += ")";
            return s;
        }

        public void GetElement(int i)
        {
            int vv;
            if (i >= 0 && i < coordinates.Length)
            {
                vv = coordinates[i];
                Console.WriteLine(vv);
            }
            else
            {
                Console.WriteLine("Введеный индекс находится за границей");
            }
        }

        public double GetNorm()
        {
            int vv = 0;
            for (int i = 0; i < coordinates.Length; i++)
            {
                // явное преобразование
                vv += (int)Math.Pow(coordinates[i], 2);
            }
            return Math.Sqrt(vv);
        }

        public void SumPositivesFromChetIndex()
        {
            int vv;
            int summ = 0;
            for (int i = 1; i < coordinates.Length; i = i + 2)
            {                 
                if ((vv = coordinates[i]) > 0)
                {
                    summ += coordinates[i];
                }
            }
            if (summ == 0)
            {
                Console.WriteLine("Таких чисел нет");
            } 
            else
            {
                Console.WriteLine("Сумма = {0}", summ);
            }
        }

        public void SumLessFromNechetIndex()
        {
            int vv;
            int ss = 0;
            int summ = 0;

            for (int i = 0; i < coordinates.Length; i++)
            {

                ss += Math.Abs(coordinates[i]);
                int mean = ss / coordinates.Length;

                for (int k = 1; k < coordinates.Length; k = k + 2)
                {
                    if ((vv = coordinates[k]) < mean)
                    {
                        summ += coordinates[k];
                    }
                }                
            }
            if (summ == 0)
            {
                Console.WriteLine("Таких чисел нет");
            }
            else
            {
                Console.WriteLine("Сумма = {0}", summ);
            }
        }

        public void MultiChet()
        {
            int vv;
            int multi = 1;

            for (int i = 1; i < coordinates.Length; i = i + 2)
            {
                vv = coordinates[i];
                if (vv > 0)
                {
                    if (vv % 2 == 0)
                    {
                        multi *= coordinates[i];
                    }                    
                }
            }
            if (multi == 1)
            {
                Console.WriteLine("Таких чисел нет");
            }
            else
            {
                Console.WriteLine("Произведение = {0}", multi);
            }
        }

        public void MultiNechet()
        {
            int vv;
            int multi = 1;
            for (int i = 0; i < coordinates.Length; i++)
            {
                vv = coordinates[i];
                if (vv % 3 != 0 )
                {
                    if (vv % 2 != 0)
                    {
                        multi *= coordinates[i];
                    }                
                }
            }
            if (multi == 1)
            {
                Console.WriteLine("Таких чисел нет");
            }
            else
            {
                Console.WriteLine("Произведение = {0}", multi);
            }
        }
        
        public void Sort()
        {
            Console.WriteLine("1 - сортировка по убыванию" +
                "\n2 - сортировка по возрастанию");
            string s = Console.ReadLine();
            while (s != "1" && s != "2")
            {
                Console.WriteLine("Повторите ввод");
                s = Console.ReadLine();
            }
            for (int i = 0; i < (coordinates.Length - 1); i++)
            {
                for (int j = i + 1; j < coordinates.Length; j++)
                {
                    if ((s == "1" && coordinates[i] < coordinates[j]) || (s == "2" && coordinates[i] > coordinates[j]))
                    {
                        int c = coordinates[i];
                        coordinates[i] = coordinates[j];
                        coordinates[j] = c;
                    }
                }
            }
        }
    }
}


