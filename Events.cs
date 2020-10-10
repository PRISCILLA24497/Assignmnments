using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events
{
    public delegate void Even();//Declared Delegate    
    class Event1
    {
        //This is Subscriber Class

        static void Main(string[] args)
        {
            EvenNum  x = new EvenNum();
            //Event gets binded with delegates or registered with delegate
            x.ev_Evennum += EventMessage;
            x .Even();
            Console.ReadLine();
        }
        //Delegates calls this method when event raised.  
        static void EventMessage()
        {
            Console.WriteLine("Event Executed : This is Even Number");
        }
    }
    //This is Publisher Class
    class EvenNum
    {

        public event Even ev_Evennum; //Declared Events

        public void Even()
        {

            //Check if result is odd number then raise event

            if (ev_Evennum != null)
            {
                ev_Evennum(); //Raised Event
            }
        }
    }
}

