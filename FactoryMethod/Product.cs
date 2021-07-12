using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.FactoryMethod
{
    abstract class Product
    {
        public abstract void CreateProduct();
    }
    class ConcreteProductA : Product
    {
        //Logic for product A
        public override void CreateProduct()
        {
            Console.WriteLine("Type A product");
        }
    }
    class ConcreteProductB : Product
    {
        //Logic for product B
        public override void CreateProduct()
        {
            Console.WriteLine("Type B product");
        }
    }
}
