using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
{
    internal class Window
    {
        public List<int> KeepMaxInWindow(int[] array, int windowSize)
        {
            List<int> maxCount = new List<int>();

            int[] maxStart = new int[array.Length];
            int[] maxEnd = new int[array.Length];

            maxStart[0] = array[0];
            maxEnd[maxEnd.Length - 1] = array[maxEnd.Length - 1];

            int i = 1;
            int j = array.Length - 2;

            windowSize--;

            while (i < array.Length)
            {
                if (i % windowSize != 0)
                {
                    maxStart[i] = Math.Max(array[i], maxStart[i - 1]);
                }
                else
                {
                    maxStart[i] = array[i];
                }

                if ((j + 1) % windowSize != 0)
                {
                    maxEnd[j] = Math.Max(array[j], maxEnd[j + 1]);
                }
                else
                {
                    maxEnd[j] = array[j];
                }

                i++;
                j--;
            }

            for (int k = 0; k < array.Length - windowSize; k++)
            {
                maxCount.Add(Math.Max(maxEnd[k], maxStart[k + windowSize]));
            }


            return maxCount;
        }
    }
}
