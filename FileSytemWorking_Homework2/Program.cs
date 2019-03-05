using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSytemWorking_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Сложить два целых числа А и В.
             * Входные данные
             * В единственной строке входного файла INPUT.TXT записано два натуральных числа через пробел.
             * Выходные данные
             * В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.*/

            string inputPath = @"D:\input.txt";
            string outputPath = @"D:\output.txt";

            Console.Write("Введите два числа который необходимо сохранить в файл input.txt\n" +
                "Введите число: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("\nЕще одно: ");
            int secondNum = int.Parse(Console.ReadLine());

            using(StreamWriter sw=new StreamWriter(inputPath, false, System.Text.Encoding.Default))
            {
                sw.Write(firstNum);
                sw.Write("\n"+ secondNum);
            }

            using(StreamReader sr=new StreamReader(inputPath, System.Text.Encoding.Default))
            {
                string line;
                int count = 0;
                while ((line=sr.ReadLine())!=null)
                {
                    if (count == 0)
                    {
                        firstNum = int.Parse(line);
                    }
                    else
                    {
                        secondNum = int.Parse(line);
                    }
                    ++count;
                }
            }

            int resultingValue = firstNum + secondNum;
            Console.WriteLine(resultingValue);
            using (StreamWriter sw = new StreamWriter(outputPath, false, System.Text.Encoding.Default))
            {
                sw.Write(resultingValue);
            }
        }
    }
}
