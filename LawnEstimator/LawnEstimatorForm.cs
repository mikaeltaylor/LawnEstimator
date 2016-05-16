using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Program: Lawncare Estimator
// Developer: Mikael Taylor
// Date: 4/1/2016
// Description: This program calculates a bid for a lawn project. 
//
namespace LawnEstimator
{
    public partial class LawnEstimatorForm : Form
    {
        public LawnEstimatorForm()
        {
            InitializeComponent();
            //Initialize everything
        }

        private void submitButton_Click(object sender, EventArgs e)
        {//When we click submit..
            if (lawnLengthInput.Text != "" && lawnWidthInput.Text != "")
            {
                Cost lawn = new Cost();
                lawn.lawnBase = Convert.ToInt32(lawnLengthInput.Text);
                lawn.lawnLength = Convert.ToInt32(lawnWidthInput.Text);
                lawn.lawnArea = lawn.lawnBase * lawn.lawnLength;//Calculate the lawn's area
                lawn.employeeWage = 10;//A reasonable lawn care wage
                double hours = lawn.lawnArea / 3000;
                if(hours < 1){
                    hours = 1;//Make sure they get paid for at least an hour, no matter what.
                }
                lawn.fuelCost = lawn.lawnArea * .0002;
                lawn.timeCost = lawn.employeeWage * hours;
                double totalCost = lawn.timeCost + lawn.fuelCost + lawn.profit;
                //Put correct numbers to every field.
                output.Items.Add("Wages: $" + lawn.timeCost + "Fuel: $" + lawn.fuelCost + "Total Cost: $" + totalCost);
                //Display the estimate.
            }
            else
            {
                MessageBox.Show("Enter valid data in each box, please.  All fields are required.");
            }
        }
        //Keypress validation.  Only allow numbers.
        private void lawnLengthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lawnWidthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //Keypress validation ends.  
    }
}
