using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
/* Ice Task 2( activity 2.1.1)
 * Group 2
 * ST10158643
 * Hannah Michaelson */
namespace FactoryDemo
{//Concrete Factory
    public class VehicleFactory : IPolicyFactory
    {
        //Concrete Factory Method
        public IInsuPolicy CreatePolicy()
        {//Concrete Product
            return new VehiPolicy();
        }
    }//end class
}

