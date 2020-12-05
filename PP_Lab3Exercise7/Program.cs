using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab3Exercise7
{
    class Program
    {

        public static void Brutto(ref double cena)
        {
            cena = cena * 1.23;
        }
        static void Main(string[] args)
        {
            double procesor = 500;
            double kartaGraficzna = 700;
            double pamiecRam = 300;

            Brutto(ref procesor);
            Brutto(ref kartaGraficzna);
            Brutto(ref pamiecRam);

            Console.WriteLine(procesor + kartaGraficzna + pamiecRam);
            Console.ReadKey();
        }
    }
}
