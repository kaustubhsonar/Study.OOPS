using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject = null;
        public Proxy()
        {
        }
        public bool LongRunningOperation()
        {
            //Lazy object creation
            _realSubject = new RealSubject();
            return _realSubject.LongRunningOperation();
        }
    }    
}
