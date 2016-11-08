using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningOOP.BaseStations;
using LearningOOP.PhoneS;

namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseStation station = new BaseStation();

            var GalaxyS7 = new Phone(station, "0978144504");
            var Aser = new Phone(station,"0982484009");

            GalaxyS7.CallByNumber("0982484009");
        }
    }
}
