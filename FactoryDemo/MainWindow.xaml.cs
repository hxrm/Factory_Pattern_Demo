using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/* Ice Task 2( activity 2.1.1)
 * Group 2
 * ST10158643
 * Hannah Michaelson */
namespace FactoryDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List to keep track of all created insurance policies.
        private List<IInsuPolicy> policies = new List<IInsuPolicy>();

        public MainWindow()
        {
            InitializeComponent();
            // Disable the Show All Policies button until at least one policy is created.
            selVeh.Checked += PolicyTypeChanged;
            selHouse.Checked += PolicyTypeChanged;

        }
        // The method to create a policy
        private void CreatePolicy_Click(object sender, RoutedEventArgs e)
        {
            // Create a policy based on the selected policy type
            IPolicyFactory policyFactory = selVeh.IsChecked == true ? (IPolicyFactory)new VehicleFactory() : new HouseholdFactory();
            var policy = policyFactory.CreatePolicy();

          // Check if the created policy is a vehicle policy
            if (policy is VehiPolicy vehPolicy)
            {
               // Assign the text from txtModel.Text to vehiclePolicy.Model
                vehPolicy.Model = txtModel.Text;

                // Assign the text from txtColor.Text to vehiclePolicy.Colour
                vehPolicy.Colour = txtColor.Text;

                // Try parsing the text from txtYrReg.Text into an integer
                if (int.TryParse(txtYrReg.Text, out var year))
                {
                    // If parsing succeeds, assign the parsed year to vehiclePolicy.yrReg
                    vehPolicy.yrReg = year;
                }
                else
                {
                    // If parsing fails, assign 0 to vehiclePolicy.yrReg
                    vehPolicy.yrReg = 0;
                }

                // Display details of the vehiclePolicy
                vehPolicy.DisplayDetails();

            }// Check if the created policy is a household policy
            else if (policy is HousePolicy householdPolicy)
            {// Try parsing the text from tbEstimatedCostValue.Text into a double
                if (double.TryParse(tbEstimatedCostValue.Text, out var value))
                {
                    // If parsing succeeds, assign the parsed value to householdPolicy.estContentValue
                    householdPolicy.estContentValue = value;
                }
                else
                {
                    // If parsing fails, assign 0 to householdPolicy.estContentValue
                    householdPolicy.estContentValue = 0;
                }

                // Display details of the householdPolicy
                householdPolicy.DisplayDetails();
            }
            // Add the created policy to the list of policies
            policies.Add(policy);
            // Enable the Show All Policies button
            if(policies.Count > 0)
            {// Enable the Show All Policies button
                btnShowAllPolicies.IsEnabled = true;
            }
            // Clear the input fields
            Reset();
            // Show a confirmation message
            ShowConfirmationMessage("Policy created successfully.");

        }
        /// <summary>
        /// Method to handle the event when the policy type is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PolicyTypeChanged(object sender, RoutedEventArgs e)
        {
            if (PanelVehicleDetails != null && PanelHouseholdDetails != null)
            {
                PanelVehicleDetails.Visibility = selVeh.IsChecked == true ? Visibility.Visible : Visibility.Collapsed;
                PanelHouseholdDetails.Visibility = selHouse.IsChecked == true ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        //Method to reset the input fields
        private void Reset()
        {
            // Clearing text boxes for vehicle policy inputs
            txtModel.Text = "";
            txtColor.Text = "";
            txtYrReg.Text = "";
            // Clearing text box for household policy input
            tbEstimatedCostValue.Text = "";
        }
        /// <summary>
        /// Method to show a confirmation message
        /// </summary>
        /// <param name="message"></param>
        private void ShowConfirmationMessage(string message)
        {
            MessageBox.Show(message, "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        //Method to display all policies
        private void DisplayPolicies()
        {
            StringBuilder allPoliciesDetails = new StringBuilder();
            allPoliciesDetails.AppendLine("All Saved Policies:");

            foreach (var policy in policies)
            {
                allPoliciesDetails.AppendLine(policy.ToString());
                allPoliciesDetails.AppendLine("---------------------"); // Separator between policies
            }

            MessageBox.Show(allPoliciesDetails.ToString(), "Policies Summary");
        }
        /// <summary>
        /// Method to handle the event when the Show All Policies button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayPolicies_Click(object sender, RoutedEventArgs e)
        {
            DisplayPolicies();
        }

    }//end class
}//end namespace
