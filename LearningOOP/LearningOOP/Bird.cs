using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    //internal class Bird
    class Bird
    {
        //has external access to this property
        public double WingSpan { get; set; }
        //has external access to get value but set can only in this class or children
        public double Weight { get; protected set; }
        //has external access to this property
        public int Age { get; set; }
        
        public void Feed(double caloricity, double weight)
        {
            //calculate variable energy
            var energy = weight*caloricity;

            //call method with not changed weigth parameter
            IncreaseWeight(weight);
            //call method with calculated energy
            IncreaseWingSpan(energy);
        }

        private void IncreaseWingSpan(double energy)
        {
            //in our case if age == 0 or age == 1
            if (Age <= 1)
            {
                WingSpan += energy/Weight/10000000;
            }
        }

        private void IncreaseWeight(double weight)
        {
            Weight += weight;
        }
    }
}
