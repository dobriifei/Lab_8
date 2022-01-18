using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Вывести содержимое папки на консоль
            string path = @"C:\123";
                Vivod(path);
        Console.ReadKey();
        }
        static void Vivod(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            if (dirs.Count() > 0 || files.Count() > 0)
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                    Console.WriteLine();
                }
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
                Console.WriteLine();
                Vivod(s);
            }   
            
        }
    }
}
