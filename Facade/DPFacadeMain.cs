using System;
using System.Collections.Generic;
using System.Text;

namespace Study.OOPS.Facade
{
    public class DPFacadeMain
    {
        public void Main()
        {
            // Facade
            MortgageFacade mortgage = new MortgageFacade();
            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Tom Johnsson");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
