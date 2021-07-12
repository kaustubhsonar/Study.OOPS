using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.ObserverV1
{
    public class Payload
    {
        public string Message { get; set; }
    }
    public class Subject : IObservable<Payload>
    {
        public IList<IObserver<Payload>> Observers { get; set; }

        public Subject()
        {
            Observers = new List<IObserver<Payload>>();
        }

        public IDisposable Subscribe(IObserver<Payload> observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
            return new Unsubscriber(Observers, observer);
        }

        public void SendMessage(string message)
        {
            foreach (var observer in Observers)
            {
                observer.OnNext(new Payload { Message = message });
            }
        }
    }
    public class Unsubscriber : IDisposable
    {
        private IObserver<Payload> observer;
        private IList<IObserver<Payload>> observers;
        public Unsubscriber(IList<IObserver<Payload>> observers, IObserver<Payload> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observer != null && observers.Contains(observer))
            {                
                observers.Remove(observer);
                 
                Console.WriteLine($"Removed {((Observer)observer)._id}");
            }
        }
    }
    public class Observer : IObserver<Payload>
    {
        public int _id;
        public Observer(int Id)
        {
            this._id = Id;
        }
        public string Message { get; set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Payload value)
        {
            Message = value.Message;
            Console.WriteLine($"Observer: {this._id} message: {Message}");
        }

        public IDisposable Register(Subject subject)
        {
            return subject.Subscribe(this);
        }
    }

}
