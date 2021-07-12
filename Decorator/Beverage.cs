using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Decorator
{
    public abstract class Beverage 
    {
        String description = "Coffee Beverage";

        public String getDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
    public class HouseBlend : Beverage
    {
        public override double Cost()
        {
            return 3;
        }
    }
    public class DarkRoast : Beverage
    {
        public override double Cost()
        {
            return 4;
        }
    }
}
