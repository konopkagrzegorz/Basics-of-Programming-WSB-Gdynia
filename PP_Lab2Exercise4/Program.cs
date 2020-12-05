using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise4
{

    /*
    Zadanie jest zrobione z pętlą while, która pozwala na realizacje dowolnej liczby operacji - chciałem przecwiczyć pętle w C#.
    Jeżeli nie życzy Pan sobie wykonywania zadań, których zakres jest ponad wymagania określone w treści zadania to proszę o informację zwrotną.
    */

    class Program
    {
        static void Main(string[] args)
        {
            String sentence = "What you want to do?\n" + "D - Add\n" +
                                               "O - Substract\n" +
                                               "M - Multiply\n" +
                                               "Z - Divide\n" +
                                               "Q - Quit";
            Boolean value = true;

            while (value)
            {
                Console.Write("Give 1st integer: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give 2nd integer: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sentence);

                String choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "D":
                        Console.WriteLine("Sum: " + (a + b));
                        break;
                    case "O":
                        Console.WriteLine("Difference: " + (a - b));
                        break;
                    case "M":
                        Console.WriteLine("Multiply: " + (a * b));
                        break;
                    case "Z":
                        if (b == 0)
                        {
                            Console.WriteLine("Dividing by zero is not possible!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Division: " + ((double)a / (double)b));
                            break;
                        }
                    case "Q":
                        value = false;
                        break;
                    default:
                        Console.WriteLine("Wrong action");
                        break;
                }
            }
        }
    }
}
