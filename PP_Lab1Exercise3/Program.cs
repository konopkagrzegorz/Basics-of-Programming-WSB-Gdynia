using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab1Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a coefficient in parabolic function: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give b coefficient in parabolic function: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give c coefficient in parabolic function: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int delta = b * b - 4 * (a * c);
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            if (delta > 0)
            {
                Console.WriteLine("Parabolic function have 2 roots\nx1 = " + x1 + ", x2 = " + x2);

            } else if (delta == 0)
            {
                Console.WriteLine("Parabolic function have 1 root\nx1 = " + x1);

            } else
            {
                Console.WriteLine("Parabolic function do not have roots in real numbers");
            }
            Console.ReadKey();
        }
    }
}
