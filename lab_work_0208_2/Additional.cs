using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_work_0208_2
{
    // Метод Compare предназначен для сравнения двух объектов
    class Additional : IComparer
    {
        int IComparer.Compare(object k1, object k2)
        {
            IVectorable obj1 = (IVectorable)k1;
            IVectorable obj2 = (IVectorable)k2;
            if (obj1.GetNorm() > obj2.GetNorm())
            {
                return 1;
            }
            else if (obj1.GetNorm() < obj2.GetNorm())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
