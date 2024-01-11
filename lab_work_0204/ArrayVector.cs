using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0204
{
    internal class ArrayVector : IVectorable
    {
        // Поле
        public int[] coordinates;

        public int Length { get; set; }
        // Конструктор
        public ArrayVector(int length)
        {
            Length = length;
            coordinates = new int[Length];
        }

        public ArrayVector()
        {
            Length = 5;
            coordinates = new int[Length];
        }

        // Индексатор
        public int this[int i]
        {
            get
            {
                try { return coordinates[i]; }
                catch (IndexOutOfRangeException) { Console.WriteLine("Выход за границы массива"); return 0; }
            }
            set
            {
                try { coordinates[i] = value; }
                catch (IndexOutOfRangeException) { Console.WriteLine("Выход за границы массива"); }
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

            string s = Length + " ";
            for (int i = 0; i < coordinates.Length; i++)
            {
                s += coordinates[i] + " ";
            }
            return s;
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
    }
}
