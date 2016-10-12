using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    //ChildA extends A
    class ChildA : A
    {
        //method
        public void ChildMethod()
        {
            //set properties
            InternalProperty = 0;
            PublicProperty = 1;
            ProtectedProperty = 2;

            //call methods
            PublicMethod();
            ProtectedMethod();
            InternalMethod();
        }
    }
}
