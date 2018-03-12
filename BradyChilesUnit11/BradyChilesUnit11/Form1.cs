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

 Brady Chiles

 Operating System windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Name Of homework Assignment Unit 11 Employee Search

 Program Description: This program will take input from the user for a name to be searched. It will then
    take that name and search through the sata set for it. If found it will display in the DataGridView.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace BradyChilesUnit11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method to connect data set to program
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        //When search button is clicked it will take the name in the search box and find it in the data set and return it 
        //in the DataGridView
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchName(
                    this.personnelDataSet.Employee, txtSearchName.Text);
        }

        //Closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
