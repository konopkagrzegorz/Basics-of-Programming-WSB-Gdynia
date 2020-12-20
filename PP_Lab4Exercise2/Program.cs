using System;
using System.Collections;

namespace PP_Lab4Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack kod = new Stack();
            kod.Push("A");
            kod.Push("Z");
            kod.Push("N");
            kod.Push("S");
            kod.Push("X");
            kod.Push("O");
            kod.Push("Y");
            kod.Push("S");

            while (kod.Count > 0)
            {
                String litera = (string) kod.Pop();

                if (litera != "X" && litera != "Y" && litera != "Z")
                {
                    Console.WriteLine(litera);
                }
            }
            Console.WriteLine();
        }
    }
}
