using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.ObserverV1
{
    public class DPObserverMainV1
    {
        public void Main()
        {

            Subject subject = new Subject();
            subject.Observers.Add(new Observer(1));
            subject.Observers.Add(new Observer(2));
            subject.Observers.Add(new Observer(3));
            subject.SendMessage("Article A released.");
            Unsubscriber unsubscriber = new Unsubscriber(subject.Observers, subject.Observers[0]);
            unsubscriber.Dispose();
            subject.SendMessage("Article B released.");
            subject.Observers.Add(new Observer(1));
            subject.SendMessage("Article C released.");

        }
    }
}
