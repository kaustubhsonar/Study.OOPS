using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Observer
{
    public class DPObserverMain
    {
        public void Main()
        {
            ConcreteSubject sub = new ConcreteSubject();            
            sub.Attach(new ConcreteObserver(sub, "Observer 1"));
            sub.Attach(new ConcreteObserver(sub, "Observer 2"));            
            // Change subject and notify observers
            sub.SubjectState = "Article A released.";
            sub.Notify();
           
        }
    }
}
