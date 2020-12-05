using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise8
{
    class Program
    {

        public static int Obwod(int a)
        {
            return 4*a;
        }

        public static int Obwod(int a, int b)
        {
            return 2 * a + 2 * b;
        }

        public static int Obwod(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Obwod kwadratu o boku 7: " + Obwod(7));
            Console.WriteLine("Obwod prostokata o bokach 9, 21: " + Obwod(9,21));
            Console.WriteLine("Obwod trojkata (3,4,5): " + Obwod(3,4,5));

            Console.ReadKey();
        }
    }
}
