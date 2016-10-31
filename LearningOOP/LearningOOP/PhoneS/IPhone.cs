using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP.PhoneS
{
    public interface IPhone
    {
        void CallByNumber(string number);
        void EndCall();
        void AsseptCall();
        string GetLastNumber();
    }
}
