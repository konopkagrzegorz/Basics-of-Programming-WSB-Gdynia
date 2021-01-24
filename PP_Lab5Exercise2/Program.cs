using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PP_Lab5Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "E:\\kwadraty.txt";
            StreamWriter sw = new StreamWriter(line);

            for (int i = 1; i <= 100; i++)
            {
                sw.WriteLine("kwadrat " + i + " to: " + (i * i));
            }
            sw.Close();
        }
    }
}
