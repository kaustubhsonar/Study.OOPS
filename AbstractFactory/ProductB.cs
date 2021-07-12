using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.AbstractFactory
{
    public abstract class AbstractProductB
    {
        public abstract AbstractProductB GetProductB();
    }
    public class ProductB1 : AbstractProductB
    {
        public override AbstractProductB GetProductB()
        {
            Console.WriteLine("ProductB1");
            return new ProductB1();
        }
    }
    public class ProductB2 : AbstractProductB
    {
        public override AbstractProductB GetProductB()
        {
            Console.WriteLine("ProductB2");
            return new ProductB2();
        }
    }   
}
