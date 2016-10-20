using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    // Таблиця множення
    class Program
    {
        public static void PrintMultiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                int res = i * number;
                Console.WriteLine("{0} * {1} = {2} ", number, i, res);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number = int.Parse(Console.ReadLine());

            PrintMultiplicationTable(number);

            Console.ReadKey();
        }

        
    }
}
