using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gleb_Ekzamen_Test
{
    internal class Program
    {
        static int max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е значение ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-е значение ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3-е значение ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 4-е значение ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 5-е значение ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Значение максимального элемента = {0}", max(max(max(a, b), max(c, d)), e));
            Console.ReadKey();
        }

    }
}
