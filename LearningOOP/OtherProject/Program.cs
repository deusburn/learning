using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP;

namespace OtherProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // change (a) is introduced here because it is a (public), open from two different assembly
            var a = new A();
            // change (с) and (b) not working here, because a internal, internal used only in the current
            // assembly OtherProject.
            //var b = new B();
            //var c = new C();
        }
    }
}
