using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.*/

            const int arraySize = 10;
            int[] array = new int[arraySize];
            Random random = new Random();
            Console.WriteLine("Пусть задан следующий массив:");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arraySize / 2; i++) // Первые пять элементов
            {
                for (int j = i + 1; j < (arraySize / 2 + 1); j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = (arraySize / 2); (i < arraySize - 1); i++) //Вторые пять элементов
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Результат выполнения задания выглядит так:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
