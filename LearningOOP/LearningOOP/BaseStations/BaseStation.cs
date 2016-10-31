using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.PhoneS;

namespace LearningOOP.BaseStations
{
    class BaseStation : IBaseStation
    {
        List<ICallableDevice> _connectedDevices = new List<ICallableDevice>();

        public void ExecuteCall(ICallableDevice callerPhone, string number)
        {
            foreach (ICallableDevice receiverPhone in _connectedDevices)
            {
                if (receiverPhone.GetNumber() == number)
                {
                    receiverPhone.StartDialing(callerPhone.GetNumber());
                    break;
                }
            }
        }

        public void Connect(ICallableDevice phone)
        {
            _connectedDevices.Add(phone);
        }
    }
}
