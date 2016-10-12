using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.Tools;

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

            //create new object of class Parrot via constructor
            var parrotAra = new Parrot(0.15, 0, ParrotType.Ara);
            //set objects property value
            parrotAra.WingSpan = 0.12;
            //call method with params
            parrotAra.Feed(100, 0.01);
            //call nethod without params
            parrotAra.Teach();

            var lessonsCounter = 0;
            //rerun code in body while condition is true
            while (!parrotAra.CanSpeak)
            {
                parrotAra.Teach();
                lessonsCounter++;
            }

            var res = lessonsCounter;
        }
    }
}
