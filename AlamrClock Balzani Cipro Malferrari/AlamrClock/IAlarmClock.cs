using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlamrClock
{
   public  interface IAlarmClock
    {
         string Time { get; set; }
         string AlarmTime { get; set; }

         void PowerOn();

         void PowerOff();

    }
}
