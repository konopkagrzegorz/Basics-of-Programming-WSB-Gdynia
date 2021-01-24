using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab4Exercise5
{
    class Program
    {

        public static int silnia(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return n * silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Silnia z 25: " + silnia(5));
            Console.ReadKey();

        }
    }
}
