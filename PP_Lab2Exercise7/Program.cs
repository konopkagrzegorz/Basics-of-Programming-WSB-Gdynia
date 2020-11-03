using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[100];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i * i;
            }
            Console.WriteLine(tab[16]);
            Console.ReadKey();
        }
    }
}
