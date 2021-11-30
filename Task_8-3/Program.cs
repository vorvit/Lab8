using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 8-3. Сумма случайных чисел в созданном файле
            string path = "D:/repos/Lab8/Task_8-3.txt";
            StreamReader sr = new StreamReader(path);
            int countStr = 0;
            int countWord = 0;
            int countChar = 0;
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                countStr++;
                countWord += str.Split().Length;
                countChar += str.Length;
            }
            Console.WriteLine("В тексте, содержащимся в файле {0}, содержится:", path);
            Console.WriteLine("Строк - {0};", countStr);
            Console.WriteLine("Слов - {0};", countWord);
            Console.WriteLine("Символов - {0}", countChar);
            Console.ReadKey();
        }
    }
}
