using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PP_Lab5Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\wiersz.txt";
            StreamReader sr = new StreamReader(path);
            string line = "";
            while (line != null)
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            }
            Console.ReadKey();
            sr.Close();      
        }
    }
}
