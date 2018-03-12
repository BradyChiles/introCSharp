using System;

using System.Windows.Forms;

namespace BradyChilesUnit6
{
    /** =========================================================

 Student Brady Chiles

 Operating System Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Name Of homework Assignment Unit 6 Hospital charges

 Program Description: This program will take input for the number of days spent in hospital as well as 
        medicine charges, lab fees, surgery charges, and physical rehab charges. With this input it will calculate
        the charge for the stay (days * base charge), miscellaneous charges (lab, medicine, surgery, rehab), and
        the total.

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

        //Method to determine the total staty charge
        public decimal CalcStayCharges()
        {
            try
            {
                //Constant for the base stay amount per day
                const decimal DAILY_CHARGE = 350M;
                //Pulls the amount of days from the days text box
                int days = int.Parse(txtDays.Text);
                //Multiplies daily stay charge times the days
                decimal stay = DAILY_CHARGE * days;
                //Returns total stay charge
                return stay;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //Method to calculate the tol of medicine, lab fees, surgery, and physical rehabilitation
        public decimal CalcMiscCharges()
        {
            try
            {
                //Pulls the values from the text boxes into decimal values
                decimal med = decimal.Parse(txtMed.Text);
                decimal lab = decimal.Parse(txtLab.Text);
                decimal surgery = decimal.Parse(txtSurgery.Text);
                decimal rehab = decimal.Parse(txtRehab.Text);

                //Calculates total of misc fees
                decimal totalMisc = med + surgery + lab + rehab;
                //Returns misc fees total
                return totalMisc;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //Method to claculate grand total of stay.
        public decimal CalcTotalCharges()
        {
            try
            {
                //Calls stay charge method to get stay total charge
                decimal stay = CalcStayCharges();
                //Calls misc charge method to get misc total charge
                decimal misc = CalcMiscCharges();
                //Adds stay charge and misc total for grand total
                decimal total = stay + misc;
                //returns grand total
                return total;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Gathers the respective totals by calling their methods
                decimal stay = CalcStayCharges();
                decimal misc = CalcMiscCharges();
                decimal total = CalcTotalCharges();

                //Displays the respective totals and clears the text boxes
                lblStay.Text = "Stay:        $" + stay;
                lblMisc.Text = "Misc:        $" + misc;
                lblTotal.Text = "Total:        $" + total;
                txtDays.Text = "";
                txtLab.Text = "";
                txtMed.Text = "";
                txtRehab.Text = "";
                txtSurgery.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all text boxes and resets total labels
            txtDays.Text = "";
            txtLab.Text = "";
            txtMed.Text = "";
            txtRehab.Text = "";
            txtSurgery.Text = "";
            lblStay.Text = "Stay:";
            lblMisc.Text = "Misc:";
            lblTotal.Text = "Total:";
        }
    }
}
