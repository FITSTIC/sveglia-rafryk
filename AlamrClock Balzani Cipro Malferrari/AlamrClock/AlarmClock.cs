using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sveglia.core;
using System.Threading;

namespace AlamrClock
{
    public class AlarmClock : IAlarmClock
    {
       
        private string time;
        private string alarmTime;
        private Timer timer;
        private IClock clock;
       


        public AlarmClock()
        {
           
            clock = new Clock();
           

        }
        //scatta ogni secondo 
        private void timerClick(object state)
        {
            
                DateTime t = DateTime.Parse(this.time);
                int h = t.Hour;
                int m = t.Minute;
                int s = t.Second;
                clock.SetTime(h, m, s);

                t=t.AddSeconds(1);

                this.time = t.ToString("yyyy/MM/dd HH:mm:ss");
            

        }

        public void PowerOn()
        {
            clock.TurnOn(); 
        }

        public void PowerOff()
        {
            clock.TurnOff();
        }

        public string Time { get => time; set 
                {
                    time = value;
                    timer = new Timer(timerClick, null, 0, 1000);
                }
        }
        public string AlarmTime { get => alarmTime; set
            {
                alarmTime = value;
                DateTime t = DateTime.Parse(this.alarmTime);
                int h = t.Hour;
                int m = t.Minute;
                int s = t.Second;
                clock.SetAlarm(h, m, s);

            }
        }
       
    }
}
