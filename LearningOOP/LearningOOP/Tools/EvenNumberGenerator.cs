using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP.Tools
{
    class EvenNumberGenerator
    {
        private static int _currentNumber = 0;
        public int Field { get; set; }

        public static int GetNext()
        {
            var result = _currentNumber;
            _currentNumber += 2;

            return result;
        }

        public int Next
        {
            get { return GetNext(); }
        }
    }
}
