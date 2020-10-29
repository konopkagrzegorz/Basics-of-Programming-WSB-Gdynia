using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab2Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence = "Co chcesz zrobic?\n" + "D - dodac\n" +
                                               "O - odjac\n" +
                                               "M - pomnozyc\n" +
                                               "Z - podzielic\n" +
                                               "Q - wyjscie";
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
