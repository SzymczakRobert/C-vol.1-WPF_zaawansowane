using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventyIDelegaty
{
    class MyObject
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg + "  _ My objekt");
        }

        public MyObject(Simulation simulation)
        {
            simulation.listOfSubscribers += Print;

        }
    }
}
