using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventyIDelegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();

            MyObject myObject= new MyObject(simulation);
            MySecondObject mySecondObject = new MySecondObject(simulation);

            simulation.simulate();

            Console.ReadLine();
        }
    }
}
