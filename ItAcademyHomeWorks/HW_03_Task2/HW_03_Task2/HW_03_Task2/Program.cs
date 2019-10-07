using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Calculate() == true)
            {
                Console.WriteLine("Правда");
            }
            else
            {
                Console.WriteLine("Не правда");
            }
            Console.ReadKey();
        }
        static bool Calculate()
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
            return (i1 + i2)==i3;
        }
    }
}
