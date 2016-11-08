using LearningOOP.PhoneS;

namespace LearningOOP.BaseStations
{
    public interface IBaseStation
    {
        void ExecuteCall(ICallableDevice callerPhone, string number);
        void Connect(ICallableDevice phone);
    }
}