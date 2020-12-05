using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise0
{
    class Program
    {
        static void Main(string[] args)
        {
            Linia();
            Linia();
            Linia();

            Console.ReadKey();
        }


        public static void Linia()
        {

            for (int i = 1; i <= 70; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
