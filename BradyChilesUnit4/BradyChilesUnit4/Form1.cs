using System;
using System.Windows.Forms;

namespace BradyChilesUnit4
{
    /** =========================================================

 Brady Chiles

 Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Unit 4 Time Calculator

 Program Description: Takes an input of an amount of seconds. Will return how many days, hours,
 minutes and seconds that it is equal to.

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears the text box and all of the results
            txtInput.Text = "";
            lblDaysResults.Text = "";
            lblHoursReults.Text = "";
            lblMinutesResults.Text = "";
            lblSecondsResults.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables to hold values for the results
            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            //Inpute variable
            int input = 0;

            //Constants for the amount of sesconds in each level
            int NO_SECONDS = 0;
            int SECONDS_MINUTE = 60;
            int SECONDS_HOUR = 3600;
            int SECONDS_DAY = 86400;


            //Converts the input(String) into an int
            input = int.Parse(txtInput.Text);

            //Calculates seconds when inout is below 60
            if(input > NO_SECONDS && input < 60)
            {
                //Sets seconds equal to the input
                seconds = input;

                //Sets the labels to their proper values
                lblDaysResults.Text = days.ToString();
                lblHoursReults.Text = hours.ToString();
                lblMinutesResults.Text = minutes.ToString();
                lblSecondsResults.Text = seconds.ToString();



            }//Calculates minutes and seconds when input is between 60 and 3600
            else if(input >= SECONDS_MINUTE && input < SECONDS_HOUR)
            {
                //Calculates the amount of minutes and seconds
                minutes = input / SECONDS_MINUTE;

                //Seconds will be the remainder of the input divided by 60
                seconds = input % SECONDS_MINUTE;

                //Sets the labels to their proper values
                lblDaysResults.Text = days.ToString();
                lblHoursReults.Text = hours.ToString();
                lblMinutesResults.Text = minutes.ToString();
                lblSecondsResults.Text = seconds.ToString();

            //Calculates hours, minutes, and seconds when input is between 3600 and 84600
            }else if(input >= SECONDS_HOUR && input < SECONDS_DAY)
            {
                //Calculates hours by dividing the input by seconds in an hour
                hours = input / SECONDS_HOUR;

                //Minutes will take the remainder of input divided by seconds in an hour and divide it by 
                //seconds in a minute
                minutes = (input % SECONDS_HOUR) / SECONDS_MINUTE;

                // Secoconds will take the remainder of input divided by seconds in an hour and divide it by 60
                //the remainder will be seconds
                seconds = (input % SECONDS_HOUR) % SECONDS_MINUTE;

                //Sets the labels to their proper values
                lblDaysResults.Text = days.ToString();
                lblHoursReults.Text = hours.ToString();
                lblMinutesResults.Text = minutes.ToString();
                lblSecondsResults.Text = seconds.ToString();

            //Calculates days, hour, minutes and seconds if input is above 84600
            }else if(input >= SECONDS_DAY)
            {
                //Calculates the amount of days, hours, minutes, and seconds

                //Days will be input divided by seconds in a day
                days = input / SECONDS_DAY;

                //Hours will be equal to the remainder of the input divided by seconds in a day
                hours = (input % SECONDS_DAY) / SECONDS_HOUR;

                //Minutes will take the remainder of inout divided by seconds in a day and divide it by seconds in 
                //an hour. It will then take that remainder and divide it by seconds in a minute
                minutes = ((input % SECONDS_DAY) % SECONDS_HOUR) / SECONDS_MINUTE;

                //Seconds will take the remainder of input divided by seconds in a day and divide it by seconds
                //in an hour. It will then divide that that by seconds in a minute and take the remainder
                seconds = (((input % SECONDS_DAY) % SECONDS_HOUR) % SECONDS_MINUTE);


                //Sets the labels to their proper values
                lblDaysResults.Text = days.ToString();
                lblHoursReults.Text = hours.ToString();
                lblMinutesResults.Text = minutes.ToString();
                lblSecondsResults.Text = seconds.ToString();
            }

        }
    }
}
