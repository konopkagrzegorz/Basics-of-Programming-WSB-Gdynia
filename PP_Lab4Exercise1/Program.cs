using System;

namespace PP_Lab4Exercise1
{
    class Program
    {
        struct Samochod
        {
            public String marka;
            public String model;
            public int rokProdukcji;
            public int przebieg;

            public String Wypisz()
            {
                return marka + " " + model + ", rok produkcji: " + rokProdukcji + ", przebieg: " + przebieg;
            }

        }
        static void Main(string[] args)
        {
            Samochod a;

            a.marka = "Opel";
            a.model = "Astra";
            a.rokProdukcji = 2005;
            a.przebieg = 245000;

            Samochod b;

            b.marka = "Ford";
            b.model = "Focus";
            b.rokProdukcji = 2017;
            b.przebieg = 2000;

            if (a.rokProdukcji >= b.rokProdukcji)
            {
                Console.WriteLine(a.Wypisz());
            } else
            {
                Console.WriteLine(b.Wypisz());
            }

            Console.ReadKey();
        }
    }
}
