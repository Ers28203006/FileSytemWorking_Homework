using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSytemWorking_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи. 
             * Приписать еще столько же чисел этой последовательности.*/

            string path = @"D:\input.txt";

            Console.Write("Введите количество последовательности чисел: ");
            int numderFibonachi = int.Parse(Console.ReadLine());
            int nFibonachi = 0;

            for (int i = 0; i < numderFibonachi; i++)
            {
                nFibonachi = Fibonachi(i);
                Console.Write(nFibonachi+"\t");

                using(StreamWriter sw=new StreamWriter(path, true, System.Text.Encoding.Default))
                {

                    sw.Write(nFibonachi+"\t");
                }
            }

            Console.WriteLine("\n Приписать еще столько же чисел этой последовательности");

            int oldNFibonachi = nFibonachi+2; 

            using (StreamWriter sw=new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("\n");
            }
            for (int i = oldNFibonachi; i < numderFibonachi+ oldNFibonachi; i++)
            {
                nFibonachi = Fibonachi(i);
                Console.Write(nFibonachi + "\t");

                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.Write(nFibonachi + "\t");
                }
            }
        }

        static int Fibonachi(int nFibonachi)
        {
            if (nFibonachi==0)
            {
                return 0;
            }
            else if (nFibonachi == 1)
            {
                return 1;
            }
            return Fibonachi(nFibonachi - 1) + Fibonachi(nFibonachi - 2);
        }
    }
}
