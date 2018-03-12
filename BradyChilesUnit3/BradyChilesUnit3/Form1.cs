using System;
using System.Windows.Forms;

namespace BradyChilesUnit3
{
    /** =========================================================

 Brady Chiles

 Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Unit 3: Tip, Tax, Total

 This program is deisgned to take an amount charged for food,
 and display the tip amount, tax amount, and total for the meal

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                double charge;
                double taxAmount;
                double tipAmount;
                double total;
                const double TIP_PERCENT = .15;
                const double TAX_PERCENT = .07;

                //changes the string of charge to a double
                charge = double.Parse(txtCharge.Text);
                //calculates tip amount and modifies the tip label
                tipAmount = charge * TIP_PERCENT;
                lblTip.Text = "Tip: " + tipAmount.ToString("c");
                //calculates the tax amount and modifies label
                taxAmount = charge * TAX_PERCENT;
                lblTax.Text = "Tax: " + taxAmount.ToString("c");
                //calculates the total and modifies the label
                total = charge + taxAmount + tipAmount;
                lblTotal.Text = "Total: " + total.ToString("c");
            }
            //throws exception if anything a number isnt entered
            catch { MessageBox.Show("Invalid data was entered."); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Resets all labels and text box
            txtCharge.Text = " ";
            lblTip.Text = "Tip: ";
            lblTax.Text = "Tax: ";
            lblTotal.Text = "Total: ";

        }
    }
}
