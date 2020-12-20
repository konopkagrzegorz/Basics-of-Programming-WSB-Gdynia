using System;
using System.Collections;

namespace PP_Lab4Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1, 10, 7, 23, 16, 9 };
            Queue liczby = new Queue(lista);

            int element; 
            while (liczby.Count > 0)
            {
                element = (int)liczby.Dequeue();

                if (element < 10 )
                {
                    Console.WriteLine(element);
                } else
                {
                    element -= 10;
                    liczby.Enqueue(element);
                }
            }
        }
    }
}
