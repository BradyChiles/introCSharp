using System;
using System.Windows.Forms;

namespace BradyChilesUnit5
{
    /** =========================================================

 Brady Chilws

 Operating System : Windows 10

 Microsoft Visual Studio 2015

 CIS 169

 Name Of homework Assignment : Chapter 5 Random Number Guessing Game

 Program Description: Generates a random number for the user to guess. Will display high or low until
        guessed correctly. Will also display the number of guesses it took. Will generate a number when guessed
        correctly.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/
    public partial class Form1 : Form
    {
        //Declares instance variables for the program
        //as well as the random number object
        private int myNumber;
        Random rand = new Random();
        private int numGuesses;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Generates the inital random number
            myNumber = rand.Next(100);
            myNumber++;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                //Builds a guess variables and takes input from text box into variable
                var guess = 0;
                int.TryParse(txtGuess.Text, out guess);
                
                //If the guess isnt between 1 and 100 it will not configure where the guess lies
                if (guess >= 1 && guess <= 100)
                {
                    //Increments guess counter
                    numGuesses++;
                    if (guess < myNumber)
                    {
                        //If guess is too low, will present message saying so and clear text box
                        lblResponse.Text = "Too low, try again...";
                        txtGuess.Text = "";
                       
                    }
                    else if (guess > myNumber)
                    {
                        //If too high, displays a message saying so and clears text box
                        lblResponse.Text = "Too high, try again...";
                        txtGuess.Text = "";
                    }
                    else
                    {
                        //Displays message
                        lblResponse.Text = "Congratulations! " + guess.ToString() + " is correct! It took you " +
                        numGuesses.ToString() + " guesses. Play Again?";
                        //Generates a new random number
                        myNumber = rand.Next(100);
                        myNumber++;
                        //Clears the textbox and the guess counter
                        txtGuess.Text = "";
                        numGuesses = 0;
                    }
                }else
                {
                    //Displays a message if they don't enter within the constraints
                    lblResponse.Text = "Please enter a number between 1 and 100";
                    txtGuess.Text = "";
                }
              //Catches an exception
              }catch(Exception ex)
              {
                MessageBox.Show(ex.Message);
              }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }
    }
}
