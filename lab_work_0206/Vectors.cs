using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_work_0206
{
    internal class Vectors
    {
        /*
          записи вектора в байтовый поток:
        void OutputVector(Vector v, Stream out);
         чтения вектора из байтового потока:
        Vector InputVector(Stream in).

         записи вектора в символьный поток:
        void WriteVector(Vector v, TextWriter out);
         чтения вектора из символьного потока:
        Vector ReadVector(TextReader in).
         */

        public void OutputVector(IVectorable[] v, Stream stream)
        {
            for (int i = 0; i < v.Length; i++)
            {
                byte[] v1 = BitConverter.GetBytes(v[i].Length); // Возращение целого числа в виде массива байтов
                
                // запись массива байтов в фвйл |массив байтов|перемещение|число байтов|
                stream.Write(v1, 0, v1.Length);

                for (int j = 0; j < v.Length; j++)
                {
                    byte[] v2 = BitConverter.GetBytes(v[i][j]);
                    stream.Write(v2, 0, v2.Length);
                }
            }
        }

        public IVectorable[] InputVector(Stream stream)
        {
            
            if (stream.Length == 0)
            {
                throw new Exception("Массив векторов не содержит вектора");
            }
            else
            {
                // метод установки курсора в потоке |число байтов|точка отсчёта|
                stream.Seek(0, SeekOrigin.Begin);
                List<IVectorable> vector = new List<IVectorable>();
                while (stream.Position != stream.Length)
                {
                    byte[] arrbyte = new byte[4];
                    stream.Read(arrbyte, 0, 4); 
                    IVectorable v = new ArrayVector(BitConverter.ToInt32(arrbyte, 0));
                    for (int i = 0; i < v.Length; i++)
                    {     
                        byte [] _arrbyte = new byte[4];
                        stream.Read(_arrbyte, 0, 4);
                        v[i] = BitConverter.ToInt32(_arrbyte, 0); // Возращение целого числа из четырех байтов в указанной позиции
                    }
                    vector.Add(v);
                }
                IVectorable[] vec = vector.ToArray();
                return vec;
            }
        }

        public void WriteVector(IVectorable[] vec, TextWriter text)
        {
            for (int i = 0; i < vec.Length; i++)
            { 
                for (int j = 0; j < vec[i].Length; j++)
                {
                    text.Write(vec[i][j] + " ");
                }                                    
                text.WriteLine();
            }
        }

        public IVectorable[] ReadVector(TextReader text)
        {
            List<IVectorable> vector = new List<IVectorable>();
            string _str;
            while ((_str = text.ReadLine()) != null)
            {
                // удаление пустых подстрок
                string[] result = _str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                IVectorable v = new ArrayVector(result.Length);
                for (int i = 0; i < result.Length; i++)
                {
                    v[i] = Convert.ToInt32(result[i]);
                }
                vector.Add(v);
            }
            var vec = vector.ToArray();
            return vec;
        }

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
