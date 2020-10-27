using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab1Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 7;
            int minutes = 50;

            if (hour > 8 || (hour == 8 && minutes > 20))
            {
                Console.WriteLine("O nie! Jesteś spózniony");
            } else
            {
                Console.WriteLine("OK! Nie jestes spozniony");
            }
            Console.ReadKey();
        }
    }
}
