using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0205
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

            string s = Length + ": ";
            for (int i = 0; i < coordinates.Length; i++)
            {
                s += coordinates[i] + " ";
            }
            return s;
        }

        // Получения в параметр сравниваемый объект
        // возращение true при равных объектах
        public override bool Equals(object obj)
        {
            IVectorable vectorable = (IVectorable)obj;
            if (this.Length == vectorable.Length)
            {

                for (int i = 0; i < coordinates.Length; i++)
                {
                    if (this.coordinates[i] == vectorable[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        public int CompareTo(Object obj)
        {

            // Ключевое слово as. С помощью него программа пытается преобразовать выражение к определенному типу, при этом не выбрасывает исключение.
            // В случае неудачного преобразования выражение будет содержать значение null:
            // IVectorable other = obj as IVectorable;

            IVectorable other = (IVectorable)obj;
            if (other.Length < coordinates.Length)
            {
                return -1;
            }
            else if (other.Length > coordinates.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public object Clone()
        {
            ArrayVector arrayVector = new ArrayVector(coordinates.Length);
            for (int i = 0; i < coordinates.Length; i++)
            {
                arrayVector[i] = coordinates[i];
            }
            return arrayVector;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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
