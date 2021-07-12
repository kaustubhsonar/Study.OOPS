using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Proxy
{
    public class DPProxyMain
    {
        public void Main()
        {
            ISubject subjectProxy = new Proxy();
            subjectProxy.LongRunningOperation();
        }
    }
}
