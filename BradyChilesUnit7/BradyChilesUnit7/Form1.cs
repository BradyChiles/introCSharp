using System;
using System.Windows.Forms;

/** =========================================================

 Student Brady Chiles

 Operating System Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Name Of homework Assignment Unit 7 Tic Tac Toe

 Program Description: Generates X's and O's in the labels and displays the winner

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace BradyChilesUnit7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Loads the array with the variables (0 or 1) to resemble X's or O's
        public void PopulateArray(int[,] game)
        {
            try
            {
                //Variables
                const int ROWS = 3;
                const int COLS = 3;
                const int RAND_LIMIT = 2;
                //Creates random number object
                Random rand = new Random();

                //Cycles through the rows
                for (int row = 0; row < ROWS; row++)
                {
                    //Cycles through the columns
                    for (int col = 0; col < COLS; col++)
                    {
                        //Asigns either 0 or 1 to the index
                        game[row, col] = rand.Next(RAND_LIMIT);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public String PopulateLabel(int element)
        {
            if(element == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        //Determines the winner between X or O
        public void DetermineWinner(int[,] game)
        {
            try
            {
                //Variables
                int total = 0;
                int xWins = 0;
                int oWins = 0;
                int ROWS = 3;
                int COLS = 3;

                //Determines if anyone wins any of the rows
                for (int row = 0; row < ROWS; row++)
                {
                    total = 0;
                    for (int col = 0; col < COLS; col++)
                    {
                        total += game[row, col];
                    }
                    //If there are 3 X's then X gets a win
                    if (total == 3)
                    {
                        xWins++;
                    }
                    //If there are 3 O's then O gets the win
                    else if (total == 0)
                    {
                        oWins++;
                    }
                }

                //Determines if anyone wins the columns
                for (int col = 0; col < COLS; col++)
                {
                    total = 0;
                    for (int row = 0; row < ROWS; row++)
                    {
                        total += game[row, col];
                    }
                    //If there are 3 X's then X gets the win
                    if (total == 3)
                    {
                        xWins++;
                    }
                    //If there are 3 O's then O gets the win
                    else if (total == 0)
                    {
                        oWins++;
                    }
                }

                //Checks righ/left diagonal
                total = 0;
                total = game[0, 2] + game[1, 1] + game[2, 0];
                //If there are 3 X's then X gets the win
                if (total == 3)
                {
                    xWins++;
                }
                //If there are 3 O's then O gets the win
                else if (total == 0)
                {
                    oWins++;
                }

                //Checks the left/right diagonal
                total = 0;
                total = game[0, 0] + game[1, 1] + game[2, 2];
                //If there are 3 X's then X gets the win
                if (total == 3)
                {
                    xWins++;
                }
                //If there are 3 O's then O gets the win
                else if (total == 0)
                {
                    oWins++;
                }

                //If there are more X wins then X is the overall winner
                if (xWins > oWins)
                {
                    lblResult.Text = "X is the winner!";
                }
                //If there are more O wins then O is the overall winner
                else if (oWins > xWins)
                {
                    lblResult.Text = "O is the winner";
                }
                //If there are an even amount and/or an even amount then it is a tie
                else
                {
                    lblResult.Text = "It is a tie...";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes application
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables for dimensions
                const int ROWS = 3;
                const int COLS = 3;

                //Creates 2D array
                int[,] game = new int[ROWS, COLS];

                PopulateArray(game);
                lblTopLeft.Text = PopulateLabel(game[0, 0]);
                lblTopMiddle.Text = PopulateLabel(game[0, 1]);
                lblTopRight.Text = PopulateLabel(game[0, 2]);
                lblMiddleLeft.Text = PopulateLabel(game[1, 0]);
                lblMiddleMiddle.Text = PopulateLabel(game[1, 1]);
                lblMiddleRight.Text = PopulateLabel(game[1, 2]);
                lblBottomLeft.Text = PopulateLabel(game[2, 0]);
                lblBottomMiddle.Text = PopulateLabel(game[2, 1]);
                lblBottomRight.Text = PopulateLabel(game[2, 2]);

                DetermineWinner(game);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
