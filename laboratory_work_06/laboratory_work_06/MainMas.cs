using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_work_06
{
    class MainMas
    {
        int m;
        int n;
        int[,] may;
        int[] mays;
      
        public MainMas(int m, int n)
        {
            M = m;
            N = n;
            may = new int[M,N];
            mays = new int[N];
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public void InputRandomMas()
        {
            Random random = new Random();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    may[i, j] = random.Next(-100, 100);
                }
            }
        }

        public void Parametr()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,5:0}", may[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void SortStolb()
        {
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    mays[j] = mays[j] + may[i, j];
                }
                Console.Write(mays[j] + " "); 
            }
        }
        public void SortMay1()
        {
            for (int i = 0; i < mays.Length - 1; i++)
            {
                for (int j = 0; j < mays.Length - i - 1; j++)
                {
                    if (mays[j + 1] < mays[j])
                    {
                        for (int k = 0; k < M; k++)
                        {
                            int v = may[k, j + 1];
                            may[k, j + 1] = may[k, j];
                            may[k, j] = v;
                        }
                        int p = mays[j + 1];
                        mays[j + 1] = mays[j];
                        mays[j] = p;
                    }
                }
            }
        }
        public void SortMay2()
        {
            for (int i = 0; i < mays.Length - 1; i++)
            {
                for (int j = 0; j < mays.Length - i - 1; j++)
                {
                    if (mays[j + 1] > mays[j])
                    {
                        for (int k = 0; k < M; k++)
                        {
                            int v = may[k, j + 1];
                            may[k, j + 1] = may[k, j];
                            may[k, j] = v;
                        }
                        int p = mays[j + 1];
                        mays[j + 1] = mays[j];
                        mays[j] = p;
                    }
                }
            }
        }
    }
}
