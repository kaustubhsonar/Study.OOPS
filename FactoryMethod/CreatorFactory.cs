using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.FactoryMethod
{
    //Factory implementation
    abstract class ProductFactory
    {
        public abstract Product CreateProduct();
    }
    class ProductAFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
    class ProductBFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
