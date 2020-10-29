using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " +  n + " = " + i*n);
            }
            Console.ReadKey();
        }
    }
}
