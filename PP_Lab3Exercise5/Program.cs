using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise5
{

    class Program {

            public static void Wypisuj(String content, int number)
            {
                for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(content);
            }
            }
        static void Main(string[] args)
        {
            Wypisuj("No czesc", 10);
            Console.ReadKey();
        }
    }
}
