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

 Name Of homework Assignment Unit 9 Car Class

 Program Description: Takes input of year and make to create a car class for
    the user, includes a speed attribute aswell. The form has an accelerate
    and brake button that increase and decrease the car's speed and displays 
    the new speed.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace BradyChilesUnit9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car myCar = new Car();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                myCar.Year = int.Parse(txtYear.Text);
                myCar.Make = txtMake.Text;
                lblYear.Text = "Year: " + myCar.Year.ToString();
                lblMake.Text = "Make: " + myCar.Make;
                lblSpeed.Text = "Current Speed: " + myCar.Speed.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }



        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            try
            {
                myCar.Accelerate();
                lblSpeed.Text = "Current Speed: " + myCar.Speed;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            try
            {
                if (myCar.Speed == 0)
                {
                    return;
                }
                else
                {
                    myCar.Brake();
                }
                lblSpeed.Text = "Current Speed: " + myCar.Speed;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
