using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDateString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Output variable
            string output;

            //Concatenate the text box input into output variable
            output = txtWeekDay.Text + " " + txtMonthName.Text + " " + txtMonthDay.Text + " " + txtYear.Text;

            //Assign output label to output variable
            lblOutput.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears text boxes
            txtWeekDay.Text = " ";
            txtMonthName.Text = " ";
            txtMonthDay.Text = " ";
            txtYear.Text = " ";

            //Clears output
            lblOutput.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
            txtWeekDay.Focus();
        }

    }
}
