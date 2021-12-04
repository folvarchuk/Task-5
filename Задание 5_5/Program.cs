using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида: 
             * 1 0 1 0 1
               0 1 0 1 0
               1 0 1 0 1
               0 1 0 1 0
               1 0 1 0 1*/

            Console.WriteLine("Введите целое число:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            //Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //array[i, j] = random.Next(0, 2);
                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }   
    }
}
