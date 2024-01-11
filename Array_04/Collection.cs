using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
{
    internal class Collection
    {
        public int Multiplication(int[] array) 
        {
            int maxValue = Math.Max(array[0], array[1]);
            int minValue = Math.Min(array[0], array[1]);

            int maxCount = array[0] * array[1];
            int minCount = array[0] * array[1];

            int multiplication = array[0] * array[1] * array[2];

            for (int i = 2; i < array.Length; i++)
            {
                multiplication = MaxValue(multiplication, array[i] * maxCount, array[i] * minCount);
                maxCount = MaxValue(maxCount, array[i] * maxValue, array[i] * minValue);
                minCount = MinValue(minCount, array[i] * maxValue, array[i] * minValue);

                maxValue = Math.Max(maxValue, array[i]);
                minValue = Math.Min(minValue, array[i]);
            }

            return multiplication;




            /*int multiplication = 1;

            int min = array[0];
            int max = array[array.Length - 1];

            int n = array[1];
            int k = array[array.Length - 2];

            if (lenght == 3)
            {
                multiplication = max * k * array[array.Length - 3];
                return multiplication;
            }
            else
            {
                if (max > 0 && min > 0)
                {  
                    multiplication = max * k * array[array.Length - 3];
                    return multiplication;
                } 
                else if (max < 0 && min < 0) 
                {
                    multiplication = max * k * array[array.Length - 3];
                    return multiplication;
                }
                else *//*if (max < 0 && min > 0)*//*
                {
                    if (n > 0 && k > 0)
                    {
                        multiplication = max * k * array[array.Length - 3];
                        return multiplication;
                    }
                    else if (n < 0 && k < 0)
                    {
                        multiplication = min * n * max;
                        return multiplication;
                    }
                    else *//*if (n < 0 && k > 0)*//*
                    {
                        if ((min * n) > (k * array[array.Length - 3]))
                        {
                            multiplication = min * n * max;
                            return multiplication;
                        }
                        else *//*if ((min * n) < (k * array[array.Length - 3]))*//*
                        {
                            multiplication = max * k * array[array.Length - 3];
                            return multiplication;
                        }
                    }
                }*/
            /*            }*/
        }

        private static int MaxValue(int a, int b, int c)
        {
            int max = int.MinValue;

            if (a > max)
                max = a;
            else
                max = b;

            if (c > max)
                max = c;

            return max;
        }

        private static int MinValue(int a, int b, int c)
        {
            int min = int.MaxValue;

            if (a < min)
                min = a;
            else
                min = b;

            if (c < min)
                min = c;

            return min;
        }

        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
