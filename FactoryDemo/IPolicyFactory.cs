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
{
    //Abstract Factory Interface to The abstract product 
    public interface IPolicyFactory
    {//Abstract Factory Method
        IInsuPolicy CreatePolicy();
    }//end interface
}
