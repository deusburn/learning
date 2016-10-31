using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.BaseStations;

namespace LearningOOP.PhoneS
{
    class Phone : IPhone, ICallableDevice
    {
        private readonly IBaseStation _station;
        protected PhoneState CurrentState = PhoneState.Idle;
        protected string LastCalledNumber = string.Empty;

        public Phone(IBaseStation station)
        {
            _station = station;
            _station.Connect(this);
        }
        
        public void CallByNumber(string number)
        {
            CurrentState = PhoneState.Speaking;
            LastCalledNumber = number;

            _station.ExecuteCall(this, number);
        }

        public void EndCall()
        {
            CurrentState = PhoneState.Idle;
        }

        public void AsseptCall()
        {
            CurrentState = PhoneState.Speaking;
        }

        public string GetLastNumber()
        {
            return LastCalledNumber; 
        }

        public string GetNumber()
        {
            throw new NotImplementedException();
        }

        public void StartDialing(string number)
        {
            throw new NotImplementedException();
        }
    }
}
