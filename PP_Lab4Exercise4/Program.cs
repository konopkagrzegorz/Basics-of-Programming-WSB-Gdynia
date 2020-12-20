using System;
using System.Collections.Generic;

namespace PP_Lab4Exercise4
{
    class Program
    {
        public static List<string> zakupy = new List<string>();

        static void Dodaj()
        {
            Console.WriteLine("Co chcesz dodac? ");
            string odp = Console.ReadLine().Trim().ToLower();
            if (!zakupy.Contains(odp))
            {
                zakupy.Add(odp);
            } else
            {
                Console.WriteLine("Wybrany element jest juz na liscie!");
            }
            
        }
        static void Skresl()
        {
            Console.WriteLine("Co chcesz usunac? ");
            string odp = Console.ReadLine().Trim().ToLower();
            if (zakupy.Contains(odp))
            {
                zakupy.Remove(odp);
            } else
            {
                Console.WriteLine("Element nie istnieje");
            }
        }
        static void WypiszZakupy()
        {
            Console.WriteLine("Lista zakupów: ");
            foreach (string element in zakupy)
                Console.WriteLine("- " + element);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            zakupy.Add("szampon");
            zakupy.Add("baterie");
            zakupy.Add("winogrona");

            string odp = "";

            while (odp != "k")
            {
                WypiszZakupy();
                Console.WriteLine("d - dodanie nowego elementu do listy");
                Console.WriteLine("s - skreślenie elementu z listy");
                Console.WriteLine("k - koniec działania programu");
                Console.Write("Co chcesz zrobić? ");
                odp = Console.ReadLine().ToLower();
                switch (odp)
                {
                    case "d":
                        Dodaj();
                        break;
                    case "s":
                        Skresl();
                        break;
                    case "k":
                        Console.WriteLine("Do widzenia!");
                        break;
                    default:
                        Console.WriteLine("Nie rozumiem, spróbuj jeszcze raz");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
