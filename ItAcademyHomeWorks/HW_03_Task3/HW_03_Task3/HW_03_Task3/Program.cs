using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_Task3
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
            Console.WriteLine("Введите оператор");
            string op = Console.ReadLine();
            Console.WriteLine("Введите результат");
            string s3 = Console.ReadLine();
            int i3 = Convert.ToInt32(s3);
            int result = 0;
            if (op == "+")
            {
                result = i1 + i2;
            }
            else if (op == "-")
            {
                result = i1 - i2;
            }
            if (result == i3)
            {
                Console.WriteLine("Правда");
            }
            else
            {
                Console.WriteLine("Не правда");
            }
            if (i3 > result)
            {
                Console.WriteLine("Должно быть меньше");
            }
            else if (i3 < result)
            {
                Console.WriteLine("Должно быть больше");
            }
        }
    }
}
