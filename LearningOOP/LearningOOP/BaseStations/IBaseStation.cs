using LearningOOP.PhoneS;

namespace LearningOOP.BaseStations
{
    public interface IBaseStation
    {
        void ExecuteCall(IPhone callerPhone, string number);
        void Connect(IPhone phone);
    }
}