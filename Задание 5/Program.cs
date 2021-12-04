using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/

            const int arraySize = 7;
            int[] array = new int[arraySize];
            float meanCalc = 0;
            Console.WriteLine("Введите числа массива:");
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arraySize; i++)
            {
                meanCalc += array[i];
            }
            Console.WriteLine("Среднее арифметическое равно {0:f2}", meanCalc/3);
            Console.ReadKey();
        }
    }
}
