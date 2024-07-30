using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Ice Task 2( activity 2.1.1)
 * Group 2
 * ST10158643
 * Hannah Michaelson */
namespace FactoryDemo
{//Concrete Factory
    public class HouseholdFactory : IPolicyFactory
    {//Concrete Factory Method
        public IInsuPolicy CreatePolicy()
        {//Concrete Product
            return new HousePolicy();
        }
    }//end class
}
