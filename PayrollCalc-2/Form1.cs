using System;
using System.Windows.Forms;
/* Author: Zachary Betters
 * Date: 24 August, 2016
 * Class: CIS 209
 * Teacher: Eric Mailman
 * Title: Payroll Calculator 2
 * Description: This program will output the gross pay of the given data on a text box.  
 */

namespace PayrollCalc_2 {
    public partial class Gross_Pay : Form {
        public Gross_Pay() { InitializeComponent(); }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnCalc_Click(object sender, EventArgs e) {
            decimal hourlyRate, grossPay, hoursWorked;  //declares these variables to be decimals

            if (decimal.TryParse(tbHoursWorked.Text, out hoursWorked) &&   //if the entered data are decimals 
                    decimal.TryParse(tbHourlyRate.Text, out hourlyRate)) {       
                grossPay = hourlyRate * hoursWorked; //calculattes answer and displays it in a text box
                tbGrossPay.Text = grossPay.ToString();
            }
            else //if entered data is blank or something other than a number 
                MessageBox.Show("You must enter data in order for me to calculate it!", "Error");
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbGrossPay.Text = String.Empty;
            tbHourlyRate.Text = String.Empty;
            tbHoursWorked.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }
    }
}