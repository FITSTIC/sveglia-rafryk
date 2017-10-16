using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia.core
{
    internal class Clock : IClock
    {
        public int hourAlarm, minuteAlarm,secondAlarm;

        private IDisplay display;
        private IBell bell;

        public Clock()
        {
            display = new Display();
            bell = new Bell();
        }
        public void SetAlarm(int h, int m, int s)
        {
            hourAlarm = h;
            minuteAlarm = m;
            secondAlarm = s;
        }

        public void SetTime(int h, int m, int s)
        {
            display.ShowTime(h, m, s);
            if(hourAlarm==h && minuteAlarm== m && secondAlarm==s)
            {
                bell.Start();

            }
            
        }

        public void TurnOff()
        {
            Console.WriteLine("la sveglia è spenta");
        }

        public void TurnOn()
        {
            Console.WriteLine("la sveglia è accesa");
            
        }
    }
}
