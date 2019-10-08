using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Неявное преобразование типов
            short i1 = 1;
            int i2;
            i2 = i1;
            float f1;
            f1 = i2;
            double t34;
            t34 = f1;
            //Явное преобразование типов
            double a1 = 1.1;
            float g3;
            g3=(float)a1;
            double t5 = 7.7;
            int r3 = (int)t5;
            long y3 = 500;
            short u3;
            u3 = (short)y3;
            //упаковка
            object s1 = 123;
            //распаковка
            int k7 = 6;
            object p9 = k7;
            int k8 = (int)p9;
        }
    }
}
