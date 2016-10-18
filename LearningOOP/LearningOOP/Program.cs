using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    //Створити масив від 1 до 100. Вивести на екран в зворотньому порядку парні числа більші за 50. (100 98 96 94 92...)
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if ((array[i] % 2 == 0) && (array[i] >= 50))
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //}
            for (int i = 99; i >= 0 ; i--)
            {
                if ((array[i] % 2 == 0) && (array[i] >= 50) )
                {
                Console.Write(array[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
