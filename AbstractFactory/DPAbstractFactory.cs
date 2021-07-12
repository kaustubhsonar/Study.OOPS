using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.AbstractFactory
{
    public class DPAbstractFactory
    {
        public void Main()
        {
            ProductFactory productFactory = new ProductFactoryType1();
            Client client = new Client(productFactory);
            client.GetProductA();
            client.GetProductB();
            Console.WriteLine("------------------------------------------------------------------");
            productFactory = new ProductFactoryType2();
            client = new Client(productFactory);
            client.GetProductA();
            client.GetProductB();
        }
    }
}
