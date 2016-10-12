using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    public class A
    {
        //Properties
        private int PrivateProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        internal int InternalProperty { get; set; }

        //field
        private int _publicField = 42;

        public int PublicProperty
        {
            get { return GetRandomNumber(); }
            set { _publicField = value; }
        }

        //methods
        private int GetRandomNumber()
        {
            return new Random().Next(100);
        }

        private void PrivateMethod()
        {
            _publicField = 2;
        }

        protected void ProtectedMethod()
        {

        }

        internal void InternalMethod()
        {

        }

        public void PublicMethod()
        {
            PrivateMethod();
            ProtectedMethod();
        }
    }
}
