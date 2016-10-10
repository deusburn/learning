using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            // variables (b) and (c) - internal, other collections can not use them
            var b = new B();
            var c = new C();
        }
    }
}
