using System;

using System.Windows.Forms;

/** =========================================================

 Brady Chiles
    
 Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Unit 2 Heads or Tails

 Display each side of a coin

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace BradyChilesUnit2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Displays the heads side of coin and hides tails
        private void btnHeads_Click(object sender, EventArgs e)
        {
            picHeads.Visible = true;
            picTails.Visible = false;
        }
        //Shows tails side of coin and hides tails
        private void btnTails_Click(object sender, EventArgs e)
        {
            picTails.Visible = true;
            picHeads.Visible = false;
        }
        //Exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
