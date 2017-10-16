using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia.core
{
    public interface IClock
    {

        void TurnOn();

        void SetAlarm(int h,int m, int s);

        void SetTime(int h, int m, int s);

        void TurnOff();


    }
}
