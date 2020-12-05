using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise6
{
    class Program
    {

        public static double Potega(int a, int b)
        {
            double power = 1;
            bool isPositive = true;

            if (b < 0)
            {
                isPositive = false;
                b = -1 * b;
            }
            for (int i = 1; i <= b; i++)
            {
                power *= a;
            }

            if (isPositive == false)
            {
               power =  Math.Round(1 / power, 2);
            }
            return power;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Potega liczby 2 do potegi -2: = " + Potega(2, -2));
            Console.WriteLine("Potega liczby 3 do potegi -3: = " + Potega(3, -3));
            Console.WriteLine("Potega liczby 3 do potegi 3: = " + Potega(3, 3));
            Console.ReadKey();
        }
    }
}
