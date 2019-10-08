using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1 = 11;
            SByte a2 = 11;
            Console.WriteLine(a1.GetType());
            Console.WriteLine(a2.GetType());
            short b1 = 11;
            Int16 b2 = 11;
            Console.WriteLine(b1.GetType());
            Console.WriteLine(b2.GetType());
            int c1 = 11;
            Int32 c2 = 11;
            Console.WriteLine(c1.GetType());
            Console.WriteLine(c2.GetType());
            long d1 = 11;
            Int64 d2 = 11;
            Console.WriteLine(d1.GetType());
            Console.WriteLine(d2.GetType());
            byte e1 = 11;
            Byte e2 = 11;
            Console.WriteLine(e1.GetType());
            Console.WriteLine(e2.GetType());
            ushort f1 = 11;
            UInt32 f2 = 11;
            Console.WriteLine(f1.GetType());
            Console.WriteLine(f2.GetType());
            char g1 = 'a';
            Char g2 = 'a';
            Console.WriteLine(g1.GetType());
            Console.WriteLine(g2.GetType());
            uint h1 = 11;
            UInt32 h2 = 11;
            Console.WriteLine(h1.GetType());
            Console.WriteLine(h2.GetType());
            ulong i1 = 11;
            UInt64 i2 = 11;
            Console.WriteLine(i1.GetType());
            Console.WriteLine(i2.GetType());
            float j1 = 11;
            Single j2 = 11;
            Console.WriteLine(j1.GetType());
            Console.WriteLine(j2.GetType());
            double k1 = 11;
            Double k2 = 11;
            Console.WriteLine(k1.GetType());
            Console.WriteLine(k2.GetType());
            decimal l1 = 11;
            Decimal l2 = 11;
            Console.WriteLine(l1.GetType());
            Console.WriteLine(l2.GetType());
            string m1 = "11";
            String m2 = "11";
            Console.WriteLine(m1.GetType());
            Console.WriteLine(m2.GetType());
            object n1 = 123456789;
            Object n2 = 1234.56789;
            Console.WriteLine(n1.GetType());
            Console.WriteLine(n2.GetType());
            Console.ReadKey();
        }
    }
}
