using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.Detergents;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new int[12];

            var middleFairy = new Fairy();
            Console.WriteLine(middleFairy.GetFluidPortion());
            Console.WriteLine(middleFairy.GetFluidPortion());
            Console.ReadKey();
        
        }
    }
}
