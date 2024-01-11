using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0207
{
    internal class Vectors
    {
        // Проверка на размерность массива
        public static bool Сontrol(IVectorable v1, IVectorable v2)
        {
            if (v1.Length == v2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IVectorable Sum(IVectorable v1, IVectorable v2)
        {
            ArrayVector result = new ArrayVector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                result[i] = v1[i] + v2[i];
            }
            return result;
        }

        public static double Scalar(IVectorable v1, IVectorable v2)
        {
            double multi = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                multi += v1[i] * v2[i];
            }
            return multi;
        }

        public static ArrayVector NumberMult(IVectorable v1, double a)
        {
            ArrayVector result = new ArrayVector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                result[i] = (int)(v1[i] * a);
            }
            return result;
        }

        public static double GetNorm(IVectorable v1)
        {
            double lenV = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                lenV += v1[i] * v1[i];
            }
            lenV = Math.Sqrt(lenV);
            return lenV;
        }
    }
}
