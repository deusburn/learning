using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP.Detergents
{
    class Fairy : IProduct, IDetergent
    {
        private string _date = "08.11.16";
        private double _price = 12.75;
        private string _barCode = "5 413149 313842";
        private double _fluid = 1;

        public string GetDate()
        {
            return _date;
        }

        public double Price()
        {
            return _price;
        }

        public string BarCode()
        {
            return _barCode;
        }

        public double GetFluidPortion()
        {
            Console.WriteLine(_fluid);
            if (_fluid == 0)
            {
                return 0;
            }
            else
            {
                _fluid --;
                return 1;
            }
        }
    }
}
