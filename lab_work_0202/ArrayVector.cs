using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0202
{
    internal class ArrayVektor
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
            get
            {
               try { return coordinates[i]; } 
               catch { Console.WriteLine("Выход за границы массива"); return 0; }
            }
            set
            {
                try { coordinates[i] = value; }
                catch { Console.WriteLine("Выход за границы массива"); }
            }
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
    }
}
