using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.AbstractFactory
{
    public abstract class ProductFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();        
    }

    public class ProductFactoryType1 : ProductFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }        
    }

    public class ProductFactoryType2 : ProductFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }   
}
