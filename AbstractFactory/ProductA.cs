using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.AbstractFactory
{
    public abstract class AbstractProductA
    {
        public abstract AbstractProductA GetProductA();
    }
    public class ProductA1 : AbstractProductA
    {
        public override AbstractProductA GetProductA()
        {
            Console.WriteLine("ProductA1");
            return new ProductA1();
        }
    }
    public class ProductA2 : AbstractProductA
    {
        public override AbstractProductA GetProductA()
        {
            Console.WriteLine("ProductA2");
            return new ProductA2();
        }
    }
}
