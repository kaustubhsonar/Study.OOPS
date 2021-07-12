using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Observer
{
    public abstract class Observer
    {
        public abstract void Update();
    }
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            //Console.WriteLine("Observer {0}'s old state is {1}",
            //   name, observerState);
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
               name, observerState);
        }
    }
    
}
