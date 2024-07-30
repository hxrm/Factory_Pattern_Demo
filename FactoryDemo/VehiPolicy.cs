using System.Windows;
/* Ice Task 2( activity 2.1.1)
 * Group 2
 * ST10158643
 * Hannah Michaelson */
namespace FactoryDemo
{
    public class VehiPolicy : IInsuPolicy
    {//Getters and Setters
        public string Model { get; set; }
        public string Colour { get; set; }
        public int yrReg { get; set; }
        /// <summary>
        /// method to display the details of the vehicle insurance policy
        /// </summary>
        public void DisplayDetails()
        {
            string message = $"Vehicle Insurance Policy:\nModel: {Model}\nColour: {Colour}\nYear of Registration: {yrReg}";
            MessageBox.Show(message, "Policy Details");
        }
        /// <summary>
        /// override the ToString method to display the details of the vehicle insurance policy
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return $"Vehicle Insurance Policy:\nModel: {Model}\nColour: {Colour}\nYear of Registration: {yrReg}";
        }
    }//end class
}