using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.PhoneS;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var GalaxyS7 = new Phone();
            Console.WriteLine("Last number before phone using: {0}", GalaxyS7.GetLastNumber());

            GalaxyS7.CallByNumber("0978144504");
            GalaxyS7.EndCall();

            Console.WriteLine("Last number after phone using: {0}", GalaxyS7.GetLastNumber());

            var savedNumber = GalaxyS7.GetLastNumber();

            GalaxyS7.CallByNumber("911");

            Console.WriteLine("Last number: {0}", GalaxyS7.GetLastNumber());

            GalaxyS7.CallByNumber(savedNumber);
            Console.WriteLine("Last number: {0}", GalaxyS7.GetLastNumber());
        }
    }
}
