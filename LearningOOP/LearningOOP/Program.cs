using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    //завдання: Створити масив від 1 до 100. Знайти суму всіх чисел, які кратні трьом. (суму вивести на екран)
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            var arrayMen = new int[] {9, 2, 3, 4, 5, 6};//new int[100];
//            for (int i = 0; i < arrayMen.Length; i++)
//            {
//                arrayMen[i] = i + 1;
//            }
            for (int i = 0; i < arrayMen.Length; i++)
            {
                if ((arrayMen[i] % 3) == 0)
                {
                    summa += arrayMen[i];
                }
            }
            Console.Write(summa + " ");
            Console.ReadKey();

        }
    }
}
