using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleProject.HR
{
    public interface IEmployee
    {
        double ReceiveWage(bool resetHours = true);
        void GiveBonus();
        void PerformWork();
        void PerformWork(int numberOfHours);
        void GiveCompliment();
    }
}