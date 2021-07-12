using Study.OOPS.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS
{
    class DPFactoryMethod
    {
        public void Main()
        {
            // An array of creators            
            ProductFactory[] creators = new ProductFactory[2];
            creators[0] = new ProductAFactory();
            creators[1] = new ProductBFactory();
            // Iterate over creators and create products
            foreach (ProductFactory productFactory in creators)
            {
              Product product = productFactory.CreateProduct();
              product.CreateProduct();
            }
     
            Console.ReadKey();
        }
    }
   
}
