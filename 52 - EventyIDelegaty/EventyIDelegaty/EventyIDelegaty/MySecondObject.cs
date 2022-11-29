using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventyIDelegaty
{
    class MySecondObject
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg + "  _ Second object");
        }

        public MySecondObject(Simulation simulation)
        {
             simulation.listOfSubscribers += Print;   // zapisanie się do eventu
            //simulation.listOfSubscribers -= Print;      // wypisanie się z obiektu
            //simulation.listOfSubscribers("msg");      // jeżeli chcemy to wypisać to musimy usunąć event w "Simulation.cs"


            //simulation._listOfSubscribers("ss");         // przez tą listę możemy się z tąd dostać do symulacji  "Simulation.cs" 
                                                        // przy _listOfSubsribers musi być | private | !
        }

    }
}
