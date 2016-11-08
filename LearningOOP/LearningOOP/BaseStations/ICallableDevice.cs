using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP.BaseStations
{
    public interface ICallableDevice
    {
        string GetNumber();
        void StartDialing(string number);
    }
}
