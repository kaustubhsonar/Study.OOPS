using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Adapter
{
    class DPAdapterMain
    {
        public void Main()
        {
            //Target call without Adapter
            ITarget target = new Target();
            target.Request();
            //Call to Adaptee (the different implementation)
            target = new Adapter(new Adaptee());
            target.Request();            
        }
    }
}
