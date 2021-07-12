using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Adapter
{
    public interface ITarget
    {
        void Request();
    }
    public class Target : ITarget
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Request()");
        }
    }
}