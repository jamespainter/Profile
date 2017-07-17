using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment2_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Class Variables for Game Results. These variables will be used be used to 
        /// keep track of the times played, won, lost, and what number the dice is.
        /// </summary>
        private int numPlayed = 0;
        private int numWon = 0;
        private int numLost = 0;
        private int numDice = 0;

        /// <summary>
        /// Class Variables for the frequency column. 
        /// </summary>
        private List<int> frequency = new List<int>();
        private int one = 0;
        private int two = 0;
        private int three = 0;
        private int four = 0;
        private int five = 0;
        private int six = 0;

        /// <summary>
        /// Class variables for the number of guesses column 
        /// </summary>
        private List<string> guesses = new List<string>();
        private int guessOne = 0;
        private int guessTwo = 0;
        private int guessThree = 0;
        private int guessFour = 0;
        private int guessFive = 0;
        private int guessSix = 0;

        /// <summary>
        /// Form1() contructor to initialize form and set values for columns. 
        /// </summary>
        public Form1()
        {
            /// initialize form. 
            InitializeComponent();
            /// initialize max length in for tb_guess 
            tb_guess.MaxLength = 1;
            /// add values in the Add Face Column
            AddFaceCol();
            /// add values in the Frquency Column
            AddFreqCol();
            /// add values in the Percent Column
            AddPercentCol();
            /// add values in the Guess Column
            AddNumGuessCol();
        }

        /// <summary>
        /// This method puts the values of the dice in the Face colum in the rich text box. 
        /// </summary>
        private void AddFaceCol()
        {
            ///loop through the values 1-6
            for (int i = 1; i < 7; i++)
            {
                ///formats and puts a newline in the rich text box column Face 
                rtb_Face.AppendText(Environment.NewLine + String.Format("{0,10}", i.ToString()));
            }


        }

        /// <summary>
        /// Adds the values of how many times the dice has been rolled in the Frequency Column 
        /// </summary>
        private void AddFreqCol()
        {
            /// add values to frequency 
            this.frequency.Add(numDice);
            /// get a count for how many times 1-6 numbers have been rolled. 
            for (int i = 0; i < frequency.Count; i++)
            {
                switch (frequency[i])
                {
                    case 1:
                        one++;
                        continue;
                    case 2:
                        two++;
                        continue;
                    case 3:
                        three++;
                        continue;
                    case 4:
                        four++;
                        continue;
                    case 5:
                        five++;
                        continue;
                    case 6:
                        six++;
                        continue;
                    default:
                        frequency.RemoveAt(i);
                        continue;


                }

            }
            /// reset list in frequency column
            rtb_Frequency.ResetText();
            /// Format and create list for the Frequency column 
            rtb_Frequency.AppendText(String.Format("{0,13}", "FREQUENCY"));
            rtb_Frequency.AppendText(Environment.NewLine + String.Format("{0,13}", one.ToString()));
            rtb_Frequency.AppendText(Environment.NewLine + String.Format("{0,13}", two.ToString()));
            rtb_Frequency.AppendText(Environment.NewLine + String.Format("{0,13}", three.ToString()));
            rtb_Frequency.AppendText(Environment.NewLine + String.Format("{0,13}", four.ToString()));
            rtb_Frequency.AppendText(Environment.NewLine + String.Format("{0,13}", five.ToString()));
            rtb_Frequency.AppendText(Environment.NewLine + String.Format("{0,13}", six.ToString()));
            /// This adds the percentages to the percentage column 
            this.AddPercentCol();
            /// this resets my counters 
            ResetFeqCounters();
        }

        /// <summary>
        /// ResestFreqCounters() method resets the counters for Fequency Column 
        /// </summary>
        private void ResetFeqCounters()
        {
            one = 0;
            two = 0;
            three = 0;
            four = 0;
            five = 0;
            six = 0;

        }
        /// <summary>
        /// This Method resets the game results for the game 
        /// </summary>
        private void ResetGameResults()
        {
            numPlayed = 0;
            numWon = 0;
            numLost = 0;
            numDice = 0;
            lbl_NTL_Value.Text = "0";
            lbl_NTP_Value.Text = "0";
            lbl_NTW_Value.Text = "0";
        }
        /// <summary>
        /// This Method does the division for the percentage column 
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="played"></param>
        /// <returns>float</returns>
        private float div(int freq, int played)
        {
            if (freq == 0)
                return 0;
            return ((float)freq / played) * 100;
        }
        /// <summary>
        /// This method creates the percentage column. In the this method it calls div to do the division. 
        /// Also formats and adds to the percentage column 
        /// </summary>
        private void AddPercentCol()
        {
            /// method variables to do the division
            float onePercent = (float)Math.Round(div(one, numPlayed));
            float twoPercent = (float)Math.Round(div(two, numPlayed));
            float threePercent = (float)Math.Round(div(three, numPlayed));
            float fourPercent = (float)Math.Round(div(four, numPlayed));
            float fivePercent = (float)Math.Round(div(five, numPlayed));
            float sixPercent = (float)Math.Round(div(six, numPlayed));
            /// resets the percentage column 
            rtb_Percent.ResetText();
            /// formats and adds the percentages to the percentage column. 
            rtb_Percent.AppendText(String.Format("{0,10}", "PERCENT"));
            rtb_Percent.AppendText(Environment.NewLine + String.Format("{0,10}%", onePercent.ToString()));
            rtb_Percent.AppendText(Environment.NewLine + String.Format("{0,10}%", twoPercent.ToString()));
            rtb_Percent.AppendText(Environment.NewLine + String.Format("{0,10}%", threePercent.ToString()));
            rtb_Percent.AppendText(Environment.NewLine + String.Format("{0,10}%", fourPercent.ToString()));
            rtb_Percent.AppendText(Environment.NewLine + String.Format("{0,10}%", fivePercent.ToString()));
            rtb_Percent.AppendText(Environment.NewLine + String.Format("{0,10}%", sixPercent.ToString()));
        }
        /// <summary>
        /// The AddNumGuessCol() method takes the what was input in the text box tb_guess and adds it to the GuessCol. 
        /// </summary>
        private void AddNumGuessCol()
        {
            /// Adds what the input in the text box into the Guesses List. 
            guesses.Add(tb_guess.Text);
            // loop through to see how many times a guess has been made. 
            for (int i = 0; i < guesses.Count; i++)
            {

                if (guesses[i] == "1")
                {
                    guessOne++;
                    continue;
                }
                if (guesses[i] == "2")
                {
                    guessTwo++;
                    continue;
                }
                if (guesses[i] == "3")
                {
                    guessThree++;
                    continue;
                }
                if (guesses[i] == "4")
                {
                    guessFour++;
                    continue;
                }
                if (guesses[i] == "5")
                {
                    guessFive++;
                    continue;
                }
                if (guesses[i] == "6")
                {
                    guessSix++;
                    continue;
                }

            }
            ///Reset the Guess colunm to get new values
            rtb_NumTimesGuess.ResetText();
            ///Format and add guesses to the Number of times guessed column 
            rtb_NumTimesGuess.AppendText(String.Format("{0,13}", "NUMBER OF TIMES GUESSED"));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessOne.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessTwo.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessThree.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessFour.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessFive.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessSix.ToString()));
            /// reset guesses count to get new counts 
            ResetGuesses();

        }

        /// <summary>
        /// ResetGuesses() method resets the count to get new values when the user rolls again 
        /// </summary>
        private void ResetGuesses()
        {
            guessOne = 0;
            guessTwo = 0;
            guessThree = 0;
            guessFour = 0;
            guessFive = 0;
            guessSix = 0;

        }

        /// <summary>
        /// Reset_RTB_Str_Guess() method resets the Number of Guesses column and then adds new values to the Number of Guesses column. 
        /// </summary>
        private void Reset_RTB_Str_Guess()
        {
            ///Reset Rich Text box rtb_NumTimesGuess. Number of Guesses Colunm
            rtb_NumTimesGuess.ResetText();
            /// Add new values to the rtb_NumTimesGuess and format column 
            rtb_NumTimesGuess.AppendText(String.Format("{0,13}", "NUMBER OF TIMES GUESSED"));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessOne.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessTwo.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessThree.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessFour.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessFive.ToString()));
            rtb_NumTimesGuess.AppendText(Environment.NewLine + String.Format("{0,25}", guessSix.ToString()));
        }

        /// <summary>
        /// AddWin() method sums the total of the how many times won. 
        /// </summary>
        private void AddWin()
        {
            numWon++;
            lbl_NTW_Value.Text = numWon.ToString();
        }

        /// <summary>
        /// AddLoss() method sums the number of losses for each game 
        /// </summary>
        private void AddLoss()
        {
            numLost++;
            lbl_NTL_Value.Text = numLost.ToString();

        }

        /// <summary>
        /// AddGamePlayed() Keeps track of the number of times played. 
        /// </summary>
        private void AddGamePlayed()
        {
            numPlayed++;
            lbl_NTP_Value.Text = numPlayed.ToString();
        }


        /// <summary>
        /// btn_Roll_Click event is the Roll button that validates user input, rolls the dice. Also calls the methods
        /// AddNumGuessCol();AddGamePlayed();AddFreqCol();tb_guess.ResetText(); to get data into columns. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Roll_Click(object sender, EventArgs e)
        {
            ///Bring in picture into picture box 
            pb_Dice.SizeMode = PictureBoxSizeMode.StretchImage;
            ///intialize random generator
            Random random = new Random();
            ///Check to see if user input is empty
            if (!tb_guess.Text.Equals(""))
            {
                 ///Loop through dice images 
                for (int i = 0; i < 14; i++)
                {
                    ///set range for the random generator
                    numDice = random.Next(1, 7);
                    ///Set picture for number generated by random 
                    pb_Dice.Image = Image.FromFile("die" + numDice.ToString() + ".gif");
                    ///refresh the image to get new image
                    pb_Dice.Refresh();
                    ///sleep the thread to see the roll in the images 
                    Thread.Sleep(300);
                }
                ///check for win or loss 
                if (tb_guess.Text == numDice.ToString())
                {
                    this.AddWin();
                }
                else
                {
                    this.AddLoss();
                }
                ///Get values for columns and reset text in the text box guess. 
                AddNumGuessCol();
                AddGamePlayed();
                AddFreqCol();
                tb_guess.ResetText(); 
            }
            else
            {
                ///Error to put in a value 1-6. This will tell user to put in a valid input. 
                MessageBox.Show("Enter a one value 1 - 6!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// btn_Reset_Click event will clear all results and start new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            frequency.Clear();
            guesses.Clear();
            Reset_RTB_Str_Guess();
            ResetGuesses();
            ResetGameResults(); 
            ResetFeqCounters();
            AddFreqCol();
            AddPercentCol();

             
        }
        /// <summary>
        /// tb_guess_MouseEnter even gives a tool tip on a mouse enter that will give details of input 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_guess_MouseEnter(object sender, EventArgs e)
        {
            ///Initialize new tool tip 
            ToolTip ToolTip = new ToolTip();
            ///tool tip show message
            ToolTip.Show("Enter a 1 Digit Number Please", tb_guess);

        }
        /// <summary>
        /// tb_guess_TextChanged check input to make sure it can be converted into a int32 if not a message to user 
        /// will appear to tell user to put in valid input. if the value cannot be converted then text box guess will be reset. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_guess_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            if (Int32.TryParse(tb_guess.Text, out value))
            {
                if (value < 0 || value > 6)
                {
                    MessageBox.Show("Enter a one value 1 - 6!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_guess.ResetText(); 
                }
            }
        }
    }
}
