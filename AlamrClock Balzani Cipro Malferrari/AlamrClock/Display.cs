using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia.core
{
    internal class Display : IDisplay
    {
        public void ShowTime(int h, int m, int s)
        {
            Console.WriteLine(h + ":" + m + ":" + s);
        }
    }
}