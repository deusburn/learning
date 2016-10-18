﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    //Створити масив від 1 до 20. Вивести числа в рядок, починаючи з середини і до країв.
    //(приклад для масиву з 6 елементів:
    //масив: 1 2 3 4 5 6
    //результат: 3 4 2 5 1 6)
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[68];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            var x2 = array.Length / 2;
            var x1 = x2 - 1;

            for (int i = 0; i < array.Length / 2 ; i++)
            {
                var pos = x1 - i;
                var pos1 = i + x2;

                Console.Write("{0}, {1};   ", array[pos], array[pos1]);
            }

            Console.ReadKey();
        }
    }
}
