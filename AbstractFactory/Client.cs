using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.AbstractFactory
{
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;
        // Constructor
        public Client(ProductFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public AbstractProductA GetProductA() {
            return _abstractProductA.GetProductA();
        }
        public AbstractProductB GetProductB()
        {
            return _abstractProductB.GetProductB();
        }
        
        public void Run()
        {
            //_abstractProductB.Interact(_abstractProductA);            
        }
    }
}
