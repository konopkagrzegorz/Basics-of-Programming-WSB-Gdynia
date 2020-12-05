using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise3
{
    class Program
    {

        public static int Sum()
        {
            int sum = 0;
            for (int i=1;i<=100;i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(21 * Sum());
            Console.ReadKey();
        }
    }
}
