using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 8-2. Сумма случайных чисел в созданном файле
            string path = "D:/repos/Lab8/Task_8-2.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Random rnd = new Random();
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < 10; i++)
            {
               sw.WriteLine(rnd.Next(10));
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            int sum = 0;
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                sum += Convert.ToInt32(str);
            }
            Console.WriteLine("Сумма чисел в файле равна {0}", sum);
            Console.ReadKey();
        }
    }
}
