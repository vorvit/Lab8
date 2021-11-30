using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 8-1. Вывод на консоль содержимое папки и содержимое всех подкаталогов
            string path = @"D:\repos\Lab8\";
            if (Directory.Exists(path))
            {
                string[] dir = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                Console.WriteLine("Список подкаталогов в калоге {0}:\n", dir);
                foreach (string i in dir)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("\nСписки файлов в подкаталогах:"); 
                foreach (string i in dir)
                {
                    string[] files = Directory.GetFiles(i);
                    Console.WriteLine("\nСписок файлов в подкаталоге {0}", i);
                    foreach (string j in files)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
