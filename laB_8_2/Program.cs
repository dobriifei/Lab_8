using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace laB_8_2
{
    class Program
    {//Создать файл, записать 10 чисел, открыть файл, рассчитать сумму чисел в нем, вывести ответ
        static void Main(string[] args)
        {
            string path = "Logs/Log.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 1000);
                    sw.WriteLine("{0}", array[i]);
                }
            }
            using (StreamReader sw = new StreamReader(path, true))
            /* {
                 sw.ReadLine();
                 { Console.WriteLine(sw.ReadToEnd()); }
                 Console.ReadKey();
             }*/
            {
                int[] intChislo = File.ReadAllLines(path).Select(int.Parse).ToArray();
                int sum = intChislo.Sum();
                Console.WriteLine("Сумма чисел равна {0}", sum);
                Console.ReadKey();
            }
        }

    }
}







