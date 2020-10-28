using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int sum = 0;
            for (int i=1; i <=n; i++) {
                sum += i;
            }
            Console.WriteLine("Suma " + n + " pierwszych liczb = " + sum);
            Console.ReadKey();
        }
    }
}
