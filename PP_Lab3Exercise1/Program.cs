using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise1
{
    class Program
    {
        static void RysujTrojkat()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        static void RysujKwadrat()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ile figur?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kwadrat - K, Trójkąt - T");
            string odp = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                switch (odp)
                {
                    case "K":
                        RysujKwadrat();
                        break;
                    case "T":
                        RysujTrojkat();
                        break;
                    default:
                        Console.WriteLine("Błędne polecenie!");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}