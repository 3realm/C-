using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
{
    internal class RemadeStack
    {
        private int[] array;
        private int[] low_array;
        private int count;
        private int minimum;

        public RemadeStack(int length)
        {
            array = new int[length];
            low_array = new int[length];
        }



        // пуст ли стек
        public bool IsEmpty        {            get { return count == 0; }        }

        // размер стека
        public int Count        {            get { return count; }        }



        public void Push(int item)
        {
            if (count == array.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }

            if (IsEmpty)
            {
                low_array[count] = item;
                minimum++;
            }

            else if (low_array[count] > item)
            {
                low_array[minimum] = item;
                minimum++;
            }

            array[count++] = item;
        }

        public int Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            if (array[count-1] == low_array[minimum])
            {
                low_array[minimum] = default(int);
                minimum--;
            }

            int item = array[--count];
            array[count] = default(int); // сбрасываем ссылку
            return item;
        }


        public int Min() 
        {
            return array[minimum];
        }
    }
}
