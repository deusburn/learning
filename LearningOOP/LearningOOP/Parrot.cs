using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    class Parrot : Bird
    {
        //has access for reading only
        public ParrotType Type { get; }

        //first initialization of field;
        private int _knowledge = 0;

        //has access for reading only
        public bool CanSpeak
        {
            //redefine get operation
            get { return (_knowledge > 1000); }
        }

        //constructor with params
        public Parrot(double weight, int age, ParrotType type)
        {
            //initialize properties
            Weight = weight;
            Age = age;
            Type = type;
        }

        public void Teach()
        {
            //run different code in different cases
            switch (Type)
            {
                //if Type == Ara
                case ParrotType.Ara:
                    _knowledge += 2;
                    //exit from this case
                    break;
                case ParrotType.Jako:
                    _knowledge += 5;
                    break;
            }
        }
    }
}
