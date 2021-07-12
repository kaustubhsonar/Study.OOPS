using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Decorator
{
    class DPDecoratorMain
    {
        public void Main()
        {
            Beverage beverage = new AddOnMilk(new AddOnMocha(new DarkRoast()));
            Console.WriteLine($"Total cost : {beverage.Cost().ToString()}");
            //Following is just another way of calling 
            DarkRoast darkRoast = new DarkRoast();
            AddOnMilk addOnMilk = new AddOnMilk(darkRoast);
            AddOnMocha addOnMocha = new AddOnMocha(addOnMilk);
            Console.WriteLine($"Total cost : {addOnMocha.Cost().ToString()}");
        }
    }
}
