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
{//Concrete Product
    public class HousePolicy : IInsuPolicy
    {//Concrete Product Attributes
        public double estContentValue { get; set; }
        
        //Concrete Product Method to Display Details
        public void DisplayDetails()
        {
            string message = $"Household Contents Policy:\nEstimated Contents Value: R{estContentValue}";
            MessageBox.Show(message, "Policy Details");
        }
        /// <summary>
        /// override the ToString method to display the details of the household contents insurance policy
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Household Contents Policy:\nEstimated Contents Value: R{estContentValue}";
        }
    }//end class
}
