using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Adapter
{
    public class Adapter : ITarget
    {
        private IAdaptee Adaptee;
        public Adapter(IAdaptee adaptee)
        {
            Adaptee = adaptee;
        }
        public void Request()
        {
            bool executionStatus = this.Adaptee.SpecificRequest(DateTime.Now);
        }
    }

    public interface IAdaptee {
        bool SpecificRequest(DateTime dateTime);
    }
    //Different implementation with different signature 
    public class Adaptee : IAdaptee
    {
        public bool SpecificRequest(DateTime dateTime)
        {
            Console.WriteLine("\n\nCalled SpecificRequest()");
            Console.WriteLine($"Execution time : {dateTime.ToString()}");            
            return true;
        }
    }
}
