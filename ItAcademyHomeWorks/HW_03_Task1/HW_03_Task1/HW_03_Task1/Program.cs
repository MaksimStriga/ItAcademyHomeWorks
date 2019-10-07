using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Результат" + Calculate());
            Console.ReadKey();
        }
        static int Calculate()
        {
            Console.WriteLine("Введите число 1");
            string s1 = Console.ReadLine();
            int i1 = Convert.ToInt32(s1);
            Console.WriteLine("Введите число 2");
            string s2 = Console.ReadLine();
            int i2 = Convert.ToInt32(s2);
            return i1 + i2;
        }
    }
}
