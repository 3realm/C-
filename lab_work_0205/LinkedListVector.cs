using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0205
{
    internal class LinkedListVector : IVectorable
    {
        public class Node
        {
            // Поля
            // Значение элемента
            int value = 0;
            // Указатель
            Node host = null;
            // Свойство для указателя и элемента
            // хранение 
            public int Value
            // public int MyProperty { get; set; }
            {
                get { return value; }
                set { this.value = value; }
            }
            // ссылка на следующий узел
            public Node Host
            {
                get { return host; }
                set { host = value; }
            }
            // Конструктор
            public Node()
            {
                Host = null;
            }
        }

        //Поле
        //Начало списка - голова
        Node head;

        // Разжев
        //Длина списка
        public int Length
        {
            get
            {
                Node count = head;
                int v = 0;
                while (count.Host != null)
                {
                    count = count.Host;
                    v++;
                }
                return v;
            }
        }

        // Разжев
        //Конструктор без параметра
        public LinkedListVector()
        {
            // Создание экземпляра (создание в памяти узла)
            head = new Node();
            Node count = head;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}:", i);
                count.Value = int.Parse(Console.ReadLine());
                count.Host = new Node();
                count = count.Host;
            }
        }

        //Конструктор с параметром
        public LinkedListVector(int line)
        {
            // Создание экземпляра (создание в памяти узла)
            head = new Node();
            Node count = head;
            for (int i = 0; i < line; i++)
            {

                count.Host = new Node();
                count = count.Host;
            }
        }

        public Node AddElement(int line)
        {
            Node count = head;
            for (int i = 0; i < line; i++)
                count = count.Host;
            return count;
        }

        public override string ToString()
        {

            string s = Length + ": ";
            for (int i = 0; i < Length; i++)
            {
                s += AddElement(i).Value + " ";
            }
            return s;
        }

        public int CompareTo(Object obj)
        {
            IVectorable other = (IVectorable)obj;
            if (other.Length < Length)
            {
                return -1;
            }
            else if (other.Length > Length)
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
            LinkedListVector _linkedListVector = new LinkedListVector(Length);
            int i = 0;
            for (Node node = head; node != null; node = node.Host)
            {
                _linkedListVector[i] = node.Value;
                i++;
            }
            return this;
        }

        //Индексатор 
        public int this[int i]
        {
            get
            {
                try { return AddElement(i).Value; }
                catch (IndexOutOfRangeException) { Console.WriteLine("Выход за границы"); return 0; }
            }
            set
            {
                try { AddElement(i).Value = value; }
                catch (IndexOutOfRangeException) { Console.WriteLine("Выход за границы"); }
            }
        }

        //Метод получения модуля вектора 
        public double GetNorm()
        {
            double v = 0;
            Node count = head;
            for (int i = 0; i < Length; i++)
            {
                v += Math.Pow(count.Value, 2);
                count = count.Host;
            }
            v = Math.Sqrt(v);
            return v;
        }

        //Метод удаления элемента списка в конце
        public void DeletElementEnd()
        {
            Node count = head;
            if (Length == 0)
            {
                Console.WriteLine("Координат для удаления нет"); ;
            }
            else
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    count = count.Host;
                }
                count.Host = null;
            }
        }

        //Метод удаления с начала списка
        public void DeleteElementStart()
        {
            if (Length == 0)
            {
                Console.WriteLine("Координат для удаления нет");
            }
            else
            {
                Node count = head.Host;
                head = count;
            }
        }

        //Метод добавления в конец списка
        public void AddElementEnd()
        {
            Node count = head;
            Console.Write("Введите значение элемента массива: ");
            for (int i = 0; i < Length; i++)
            {
                count = count.Host;
            }
            count.Value = int.Parse(Console.ReadLine());
            count.Host = new Node();
        }

        //Метод добавления в начало списка 
        public void AddElementStart()
        {
            Node count1 = new Node();
            Node count2 = head;
            Console.Write("Введите значение элемента массива: ");
            count1.Value = int.Parse(Console.ReadLine());
            head = count1;
            head.Host = count2;
        }

        //Метод удаления элемента в список по индексу
        public void DeleteInd()
        {
            Node count = new Node();
            count = head;
            Console.Write("Введите индекс элемента массива: ");
            int ind = int.Parse(Console.ReadLine());
            if (ind > Length)
            {
                Console.WriteLine("Элемента с заданным индексом не существует");
            }
            else
            {
                for (int i = 0; i < ind - 1; i++)
                {
                    count = count.Host;
                }
                if (ind == 0)
                {
                    DeleteElementStart();
                }
                count.Host = count.Host;
            }
        }

        //Метод добавления элемента в список по индексу
        public void AddInd()
        {
            Node a = new Node();
            Node b = new Node();
            Node c = new Node();
            c = head;
            Console.Write("Введите индекс элемента массива: ");
            int ind = int.Parse(Console.ReadLine());
            if (ind > Length)
            {
                Console.WriteLine("Элемента с заданным индексом не существует");
            }
            else
            {
                for (int i = 0; i < ind - 1; i++)
                {
                    c = c.Host;
                }
                b = c;
                a = c.Host;
                Node count = new Node();
                Console.Write("Введите значение элемента массива: ");
                count.Value = int.Parse(Console.ReadLine());
                b.Host = count;
                count.Host = a;
            }
        }
    }
}
