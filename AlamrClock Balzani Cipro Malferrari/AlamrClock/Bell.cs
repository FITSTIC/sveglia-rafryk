using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveglia.core
{
    internal class Bell : IBell
    {
        public void End()
        {
            Console.WriteLine("la sveglia non suona più");
        }

        public void Start()
        {
            Console.WriteLine("la sveglia suona");
        }
    }
}