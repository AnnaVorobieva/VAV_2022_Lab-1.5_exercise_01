using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        /* Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры,
        определить среднее арифметическое элементов */

        static void Main(string[] args)
        {
            
            const int n = 7;
            int[] x = new int[n];
                        
            float sum = 0;
            float a;
                        
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0} элемент массива: ", i);
                x[i] = Convert.ToInt32(Console.ReadLine());
                sum += x[i];
            }
            a = sum / n;
            Console.WriteLine();
            Console.WriteLine("Вы ввели массив:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", x[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: {0,6:f5} ", a);

            Console.ReadKey();

        }

    }
}
