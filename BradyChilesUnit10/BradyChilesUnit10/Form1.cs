using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** =========================================================

 Student Brady Chiles

 Operating System Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Name Of homework Assignment Unit 9 Employee/ProductionEmployee Classes

 Program Description: Takes input from the user to create a ProductionEmployee
    class. Will then display that information back out to the user.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/
namespace BradyChilesUnit10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method to gather the data from the text boxes and enter
        //it into the variables for the class
        private void GetData(ProductionWorker worker)
        {
            //Variables
            int empNum;
            int shift;
            decimal rate;

            //Name variable
            worker.Name = txtName.Text;
            
            //Employee number variable
            if(int.TryParse(txtEmployeeNum.Text, out empNum))
            {
                worker.EmpNum = empNum;
            }else
            {
                MessageBox.Show("Invalid Emplyee Number");
            }
            //Shift variable
            if(int.TryParse(txtShift.Text, out shift))
            {
                //If 1 or 2 will take
                if(shift == 1 || shift == 2)
                {
                    worker.Shift = shift;
                    //Otherwise display error
                }else
                {
                    MessageBox.Show("Invalid Shift");
                }
                
            }else
            {
                MessageBox.Show("Invalid Shift");
            }
            //Rate Variable
            if(decimal.TryParse(txtRate.Text, out rate))
            {
                worker.Rate = rate;
            }else
            {
                MessageBox.Show("Invalid Rate");
            }
        }

        //Close Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Create Production worker object
                ProductionWorker worker = new ProductionWorker();
                //Call get data
                GetData(worker);
                //Enters data into labels
                //Name
                lblNameDisplay.Text = worker.Name;
                //Employee Number
                lblEmployeeNumDisplay.Text = worker.EmpNum.ToString();
                //Shift
                //If 1 = Day
                if (worker.Shift == 1)
                {
                    lblShiftDisplay.Text = "Day";
                }
                //If 2 = Night
                else if (worker.Shift == 2)
                {
                    lblShiftDisplay.Text = "Night";
                }
                //If invalid = null
                else
                {
                    lblShiftDisplay.Text = "";
                }
                //Rate
                lblRateDisplay.Text = worker.Rate.ToString("c");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
