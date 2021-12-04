using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.*/

            const int arraySize = 15;
            int[] array = new int[arraySize];
            Random random = new Random();
            Console.WriteLine("Пусть задан следующий массив:");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine("Максимальное число массива равно {0}", max);
            Console.WriteLine("Минимальное число массива равно {0}", min);
            Console.ReadKey();
                


        }
    }
}
