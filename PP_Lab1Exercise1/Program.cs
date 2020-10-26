using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab1Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = 4;
            double pricePerPiece = 3.51;

            Console.WriteLine("Price is: " + (howMany * pricePerPiece));
            Console.ReadKey();
        }
    }
}
