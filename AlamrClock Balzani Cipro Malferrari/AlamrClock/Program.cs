using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AlamrClock
{
    class Program
    {
        static void Main(string[] args)
        {

            IAlarmClock sveglia = new AlarmClock();

            sveglia.PowerOn();

            sveglia.Time =  DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            sveglia.AlarmTime = new DateTime(2017,10,9,12,47,55).ToString("yyyy/MM/dd HH:mm:ss");

            Console.WriteLine("premi enter per terminare");
            Console.ReadLine();

            sveglia.PowerOff();
        }
    }
}
