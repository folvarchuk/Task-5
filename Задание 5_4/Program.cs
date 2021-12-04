using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.*/

            const int arraySize = 20;
            int[] array = new int[arraySize];
            Random random = new Random();
            int count = 0;
            Console.WriteLine("Пусть задан следующий набор чисел:");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 1; i < arraySize; i+=2)
            {
                if (array[i] % 2 != 0 && array[i] >= 0)
                    count += 1;
                else
                    continue;
            }
            Console.WriteLine("Количество нечётных положительных элементов, стоящих на чётных местах, равно {0}", count);
            Console.ReadKey();
        }
    }
}
