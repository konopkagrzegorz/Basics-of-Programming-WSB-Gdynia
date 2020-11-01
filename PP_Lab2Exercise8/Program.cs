using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements in table do you want to have?: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[elements];

            for (int i = 0; i < elements; i++)
            {
                Console.Write("Give " + (i + 1) + " element: ");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(tab);
            Array.Reverse(tab);
            Console.Write("DESC order table: ");
            foreach (int value in tab)
            {
                if (value.Equals(tab[tab.Length - 1]))
                {
                    Console.Write(value);
                }
                else
                {
                    Console.Write(value + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
