using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            try
            {
                Console.Write("Podaj 1 liczbe: ");
                a = Convert.ToString(Console.ReadLine());
                Console.Write("Podaj 2 liczbe: ");
                b = Convert.ToString(Console.ReadLine());

                int x = Int32.Parse(a);
                int y = Int32.Parse(b);
                if ((a < 0 || a > 1024) || (b < 0 || b > 1024)) {
                    throw new ArgumentException();
                }
                Console.WriteLine(a * b);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Podane liczby nie są liczbą");
            } catch (ArgumentException ex)
            {
                Console.WriteLine("Podane liczby nie są prawidłowe!");
            }
            Console.ReadKey();
        }
    }
}
