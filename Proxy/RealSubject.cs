using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Study.OOPS.Proxy
{
    public interface ISubject
    {
        bool LongRunningOperation();
    }
    public class RealSubject : ISubject
    {
        public RealSubject()
        {
            //costly initialization 
            Thread.Sleep(5000);
        }
        public bool LongRunningOperation()
        {
            Console.WriteLine("Operation completed.");
            return true;
        }
    }

}
