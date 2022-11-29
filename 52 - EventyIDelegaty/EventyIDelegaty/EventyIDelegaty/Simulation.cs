using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventyIDelegaty
{
    class Simulation
    {

                    //  Muszą być VOID  PUBLIC i nie moga mieć żadnych parametrów

        public delegate void OnEventThatCurrentTimeIsEvent(string msg); // tutaj tworzymy delegata który przyjmuje stringa jako wiadomosć
        
                     // w zmiennej typy delegowanego/delegat nie ma czegoś takiego jak add/remove

                    // w evencie jest możliwe add/remove !!!

        private OnEventThatCurrentTimeIsEvent _listOfSubscribers;   // publiczna lista typu delegatowego/delegowanego 
                                                                    // musi być prywatna jeżeli nie chcemy się do niej dostać z poziomu innej klasy

        public event OnEventThatCurrentTimeIsEvent listOfSubscribers
                                                 //     to jest ponoć żadko spotykane ;)
        {
            add        {
                _listOfSubscribers += value;
            }
            remove
            {
                _listOfSubscribers -= value;
            }
        } 
        

                    
        // jest to typ zmiennej więc trzeba ją nazwać
        // dodatkowo jeśli chcemy sie dostać z poza tej klasy to musimy usunąć event
        //***************************************************************************************************
        /*   event  -> po wpisaniu tego możemy wywołać element tylko wewnątrz tej klasy !!!    
        * event to jest akcesor który można stworzyć w tym miejscy ( "public int CurrentTime;" )
        * ***************************************************************************************************
        */

            
        public int CurrentTime; 

        public void simulate()
        {
            while (CurrentTime < 12)
            {
               
                if ((CurrentTime % 2) == 0)        //parzyste        
                {
                    Console.WriteLine(CurrentTime);
                    //   if (listOfSubscribers != null)                      
                    //       listOfSubscribers("Curent Time is Even - czyli jest parzysta");
                    // albo tak                   

                    raiseEventCurentTimeIsEven("CurentTime is Even"); // tu mamy przeniesienie do funkcji lub podniesienie
                }
                System.Threading.Thread.Sleep(200);
                CurrentTime++;
                
                

            }
        }
        public void raiseEventCurentTimeIsEven(string msg)
        {
            if (_listOfSubscribers != null) // jeżeli nie doadajemy i odejmujemy sybskrybentów  add/remove to możemy używać tego=> listOfSubscribers      
                _listOfSubscribers(msg);     // jeżeli jest add/remove to używamy tego => _listOfSubsribers
        }                                   // po zmianie na "_listOfSubsribers" nie przejdzie msg z Z second obiektu w ostatnich liniach
        public Simulation()
        {
            CurrentTime = 0 ;            
        }
    }
}
      /* 
            event = daje nam opcje zabezpieczenia
                można programować tylko wenątrz klasy

            -   współpracuja z IDE może wykryć że to jest evenet i polepszyć współpracę (pod postacią ikony, ułatwia 
                czytelność/ ułatwienie w postaci skrótów do implementacji(czyli jakieś frameworki mogą na tym lepiej działać) 

            -   dobrze działają z wątkami automatycznie dodają coś takiego jak =>  " lock() ", ułatwia dodawanie zsynchronizowanych list
     
            -   zamiast eventa możemy dać "private" - co samo przez się bedzie jasne że dział tylko wewnątrz tej klasy ale będzie można dodawać funkcje z zewnątrz
                poprzez stworzenie w danej klasie funkcji public które miałyby sygnaturę z zewnątrz, jak w lini 15 lecz event jest lepszy
     */