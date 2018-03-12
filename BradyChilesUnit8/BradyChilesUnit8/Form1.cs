using System;
using System.Windows.Forms;

/** =========================================================

 Brady Chiles

 Operating System Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Name Of homework Assignment Unit 8 Vending Machine

 Program Description: Will take input from user for selection of soda to be purchased. 
                       Will deduct the soda from the amount left and display the total of sales.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace BradyChilesUnit8
{
    //Structure for the soda
    //Contains name of soda, cost and the amount left
    struct Soda
    {
        public String name;
        public decimal cost;
        public int numDrinks;
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method to fill each struct with the given information about the soda
        private Soda FillStruct(String name, decimal cost, int num)
        {
            Soda soda = new Soda();
            soda.name = name;
            soda.cost = cost;
            soda.numDrinks = num;

            //retruns the filled struct
            return soda;
        }

        //The array to hold the sodas. 
        Soda[] sodas = new Soda[5];
        //Variable to hold total sales
        decimal totalSales = 0;

        //Creates the soda structures and fills the soda array
        private void FillArray() {
            try
            {
                Soda cola = FillStruct("Cola", 1.00m, 20);
                Soda rootBeer = FillStruct("Root Beer", 1.00m, 20);
                Soda lemonLime = FillStruct("Lemon Lime", 1.00m, 20);
                Soda grape = FillStruct("Grape", 1.50m, 20);
                Soda creamSoda = FillStruct("Cream Soda", 1.50m, 20);

                sodas[0] = cola;
                sodas[1] = rootBeer;
                sodas[2] = lemonLime;
                sodas[3] = grape;
                sodas[4] = creamSoda;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Calls the array filler upon program launch
        private void Form1_Load(object sender, EventArgs e)
        {
            FillArray();
        }

        //Closes program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
            All of the following buttons will upon being clicked subtract the soda 
            purchased from the total remaining for the respective kind. It will then
            display the amount remaining in the label on the form. It will also add the
            cost of the soda to the total sales and display that in a label on the form aswell.
            If there are no sodas left, it will display a message to the user telling them the 
            soda is sold out.
        **/

        public void btnCola_Click(object sender, EventArgs e)
        {
            try
            {
                if (sodas[0].numDrinks <= 0)
                {
                    MessageBox.Show("Sold out of Cola");
                }
                else
                {
                    sodas[0].numDrinks--;
                    totalSales = totalSales + sodas[0].cost;
                    lblColaLeft.Text = sodas[0].numDrinks.ToString();
                    lblSales.Text = totalSales.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }

        private void btnRootBeer_Click(object sender, EventArgs e)
        {
            try
            {
                if (sodas[1].numDrinks <= 0)
                {
                    MessageBox.Show("Sold out of Root Beer");
                }
                else
                {
                    sodas[1].numDrinks--;
                    totalSales = totalSales + sodas[1].cost;
                    lblRootBeerLeft.Text = sodas[1].numDrinks.ToString();
                    lblSales.Text = totalSales.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLemonLime_Click(object sender, EventArgs e)
        {
            try
            {
                if (sodas[2].numDrinks <= 0)
                {
                    MessageBox.Show("Sold out of Lemon Lime");
                }
                else {
                    sodas[2].numDrinks--;
                    totalSales = totalSales + sodas[2].cost;
                    lblLemonLimeLeft.Text = sodas[2].numDrinks.ToString();
                    lblSales.Text = totalSales.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrape_Click(object sender, EventArgs e)
        {
            try
            {
                if (sodas[3].numDrinks <= 0)
                {
                    MessageBox.Show("Sold out of Grape");
                }
                else
                {
                    sodas[3].numDrinks--;
                    totalSales = totalSales + sodas[3].cost;
                    lblGrapeLeft.Text = sodas[3].numDrinks.ToString();
                    lblSales.Text = totalSales.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreamSoda_Click(object sender, EventArgs e)
        {
            try
            {
                if (sodas[4].numDrinks <= 0)
                {
                    MessageBox.Show("Sold out of Cream Soda");
                }
                else
                {
                    sodas[4].numDrinks--;
                    totalSales = totalSales + sodas[4].cost;
                    lblCreamSodaLeft.Text = sodas[4].numDrinks.ToString();
                    lblSales.Text = totalSales.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    
    
