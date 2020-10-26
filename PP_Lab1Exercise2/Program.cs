using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab1Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 8;
            double length = 12.5;
            double height = 2.5;

            Console.WriteLine("Do pomalowania scian potrzeba " + ((2 * length + 2 * width) * height) + " metrow kwadratowych farby.");
            Console.ReadKey();
        }
    }
}
