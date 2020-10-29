using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    number = i * j;
                    if (number < 10 && j != 10)
                    {
                        Console.Write(number + "  ");
                        if (j == 10)
                        {
                            Console.WriteLine(number);
                        }
                    }
                    else
                    {
                        if (j != 10)
                        {
                            Console.Write(number + " ");
                        }
                        else
                        {
                            Console.WriteLine(number);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
