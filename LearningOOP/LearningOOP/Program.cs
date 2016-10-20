using System;
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
        public static void WritePairsOfElements(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                var x2 = array.Length / 2;
                var x1 = x2 - 1;

                for (int i = 0; i < array.Length / 2; i++)
                {
                    var pos = x1 - i;
                    var pos1 = i + x2;

                    Console.Write("{0}, {1};   ", array[pos], array[pos1]);
                }
            }
            else
            {
                var length = array.Length;
                var middle = (length - 1) / 2;
                Console.Write(array[middle] + ";  ");

                var x2 = ((array.Length - 1) / 2) + 1;
                var x1 = ((array.Length - 1) / 2) - 1;

                for (int i = 0; i < array.Length / 2; i++)
                {
                    var pos = x1 - i;
                    var pos1 = i + x2;

                    Console.Write("{0}, {1};   ", array[pos], array[pos1]);
                }
            }
        }

        public static void InitializeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        static void Main(string[] args)
        {
            var array = new int[180];

            InitializeArray(array);

            WritePairsOfElements(array);

            Console.ReadKey();
        }
    }
}
