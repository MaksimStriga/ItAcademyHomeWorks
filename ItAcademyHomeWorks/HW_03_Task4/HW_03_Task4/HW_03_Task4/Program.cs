using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }
        static void Calculate()
        {
            Console.WriteLine("Введите число 1");
            string s1 = Console.ReadLine();
            int i1 = Convert.ToInt32(s1);
            Console.WriteLine("Введите число 2");
            string s2 = Console.ReadLine();
            int i2 = Convert.ToInt32(s2);
            Console.WriteLine("Введите результат");
            string s3 = Console.ReadLine();
            int i3 = Convert.ToInt32(s3);
            if ((i1 + i2) == i3)
            {
                Console.WriteLine("Правда");
            }
            else
            {
                Console.WriteLine("Не правда");
            }
            if (i3 > (i1 + i2))
            {
                Console.WriteLine("Должно быть меньше");
            }
            else if (i3 < (i1 + i2))
            {
                Console.WriteLine("Должно быть больше");
            }
        }
    }
}
