using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/// <summary>
/// The TicTacToe NameSpace has methods and classes to play a tic tac toe game
/// </summary>
namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// GamBoard object will use to get wins and what type of wins
        /// </summary>
        GameBoard gb;
        /// <summary>
        /// There are only Two Player Objects will play in this game 
        /// They will both have isTurn that will decide whos turn it
        /// is and what there score is. 
        /// </summary>
        Player player1;
        Player player2;
        /// <summary>
        /// Tie is the count of the number of ties. tie is a class variable 
        /// </summary>
        private int tie = 0; 
        ///bisGameStarted is used to control if any player can select any squares 
        bool bisGameStarted;

        /// <summary>
        /// IsDiagonalWin is to keep track if there is a diagnol win 
        /// </summary>
        static bool IsDiagonalWin = false;
        /// <summary>
        /// IsVertWin is to keep track if there is a vertical win 
        /// </summary>
        static bool IsVertWin = false;
        /// <summary>
        /// IsHorzWin is to keep track if there is a vertical win 
        /// </summary>
        static bool IsHorzWin = false;
        /// <summary>
        /// totTie is to keep track of total amount of ties
        /// </summary>
        


        /// <summary>
        /// MainWindow Contructor to initialize form, and players 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            ///Create player1
            player1 = new Player();
            //Create player2
            player2 = new Player(); 
            ///Sets game to false so that user has to press start
            bisGameStarted = false;
            ///used to gain value from the user input from dialog
            int answer = 0;


            /// Window1 object renders my input dialog window that uses a radio but to give me values 1 or two 
            Window1 inputDialog = new Window1("Enter the Number of Players (1 or 2)", "2");
            if (inputDialog.ShowDialog() == true)
            {
                //MessageBox.Show(inputDialog.Answer.ToString());
                ///sets my value from the input dialog into answer
                answer = inputDialog.Answer;
            }


        }
        

        /// <summary>
        /// btn_start_Click event starts the game 
        /// starts by reseting the values and starting a new GameBoard Object 
        /// btn_start_Click also set bisGameStarted to true so users can select cells 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            ///gb is to create the new gameboard
            gb = new GameBoard();
            ///Reset the values in the game board
            ResetValues();
            ///bisGameStarted so user can play
            bisGameStarted = true;
           
        }
        /// <summary>
        /// Set Turn decides who's turn it is 
        /// </summary>
        private void setTurn()
        {
            ///Checks to see what player's turn it is 
            if(!player1.isTurn)
            {
                ///Sets player1.isTurn to true; 
                player1.isTurn = true;
                ///puts in the the text box the string Player 1 turn
                tb_player_wins.Text = "Player 1 Turn";
            }
            else
            {
                ///Sets player2.isTurn to true; 
                player2.isTurn = true;
                ///puts in the the text box the string Player 1 turn
                tb_player_wins.Text = "Player 2 Turn";
                ///Sets player1 turn to false
                player1.isTurn = false;
                
            }
        }

      
        /// <summary>
        /// Label_Select_Click event is used by all labels when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Select_Click(object sender, MouseButtonEventArgs e)
        {
            //1.has bIsGameStartedSet to true; 
            //2.Is the space taken 
            //3.LoadBoard()
            //4.clsTicTac.IsWinningMove()
            //5.HighlightWinningMove() and DisplayScores()
            //6.clsTicTac.IsTie()
            // DisplayScores()

            /// This if checks if the start button has been selected
            if(bisGameStarted)
            {
                
                /// Label object to determine which label was selected
                Label MyLabel = (Label)sender;
                if (MyLabel.Content.ToString() == " ")
                {
                
                        /// switch statement to determine witch label has been selected 
                        switch (MyLabel.Name)
                        {
                            ///Checks to see if it is label lbl_1_1
                            case "lbl_1_1":
                               
                                    /// sets the content for label 0, 0 
                                    setContent(MyLabel, 0, 0);
                                break;
                            case "lbl_1_2":

                                    /// sets the content for label 1, 0 
                                    setContent(MyLabel, 1, 0);
                                break;
                            case "lbl_1_3":
                                    /// sets the content for label 2, 0
                                    setContent(MyLabel, 2, 0);
                                break;
                            case "lbl_2_1":
                                    /// sets the content for label 0, 1
                                    setContent(MyLabel, 0, 1);
                                break;
                            case "lbl_2_2":
                                    /// sets the content for label 1, 1
                                    setContent(MyLabel, 1, 1);
                                break;
                            case "lbl_2_3":
                                    /// sets the content for label 2, 1
                                    setContent(MyLabel, 2, 1);
                                break;
                            case "lbl_3_1":
                                    /// sets the content for label 0, 1
                                    setContent(MyLabel, 0, 2);
                                break;
                            case "lbl_3_2":
                                    /// sets the content for label 1, 2
                                    setContent(MyLabel, 1, 2);
                                break;
                            case "lbl_3_3":
                                    /// sets the content for label 2, 2  
                                    setContent(MyLabel, 2, 2);
                                 break;
                            default:
                            ///invalid input to set content
                                MessageBox.Show("INVALID"); 
                                break;
                        
                            }
                    }
                    else{
                    //message to show the space selected was already taken
                        MessageBox.Show("Space is Already Taken");
                }
            }
        }

        /// <summary>
        /// setContent sets the labels contents and board with value 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void setContent(Label label, int row, int col)
        {
            ///Sets the label that has been clicked to myLabel
            Label MyLabel = label;
            ///Checks for player 1 turn 
            if (player1.isTurn)
            {
                ///sets the labels content to X
                MyLabel.Content = "X";
                ///loads the board with X
                LoadBoard(row, col, "X");
                ///Sets the background color when it has been selected
                SetbackGroundColor(MyLabel);
                //changes player turn
                setTurn();
                //checks to see if it was a winning move
                CheckWin();

            }
            else
            {
                ///sets the labels content to 0
                MyLabel.Content = "0";
                ///loads the board with 0
                LoadBoard(row, col, "0");
                ///Sets the background color when it has been selected
                SetbackGroundColor(MyLabel);
                //changes player turn
                setTurn();
                //checks to see if it was a winning move
                CheckWin();

            }
        }
        


        /// <summary>
        /// SetBackGroundColor Method sets the background color to purple after it has been selected
        /// </summary>
        /// <param name="lblLabel"></param>
        private void SetbackGroundColor(Label lblLabel)
        {
            ///Changes background color to purple
            BrushConverter bc = new BrushConverter();
            ///converts the specific label to purple 
            lblLabel.Background = (Brush)bc.ConvertFrom("#532B72");

            
        }

        /// <summary>
        /// Load Board loads the game board array and labels are selected
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="val"></param>
        private void LoadBoard(int row, int col, string val)
        {
       //     MessageBox.Show(row.ToString() + " " + col.ToString() + " " + val); 
       ///loads the value of each index with a value 
            gb.saBoard[row, col] = val; 
        }
        
        /// <summary>
        /// CheckWin() calls methods in the gameboard class to check if there is horizontal, vertical or diagnol win
        /// </summary>
        private void CheckWin()
        {
            /// These methods will return true or false depending if there was a win or not
            /// IsDiagonalWin variable is set to true if there is a diagnol win 
            IsDiagonalWin = gb.IsDiagonalWin();
            /// isVertWin variable is set to true if there is a vertical win
            IsVertWin = gb.IsVertWin();
            /// isHorzWin variable is set to true if there is a horizontal win
            IsHorzWin = gb.IsHorzWin();


            //HighlightWinningMove();
            ///Checks to see if the if the methods from the Gameboard class return true
            ///If it does return true it will display the Player that won in the tb_player_wins 
            if (IsDiagonalWin)
            {
                ///Check if it is player 1 for win
                if (player1.isTurn)
                {
                    ///Highlight winning row, column, diag
                    HighlightWinningMove();
                    ///if so increment player 2 score and set the tb to player 2 wins
                    player2.newPlayerScore();
                    ///sets the score for lbl_Player_2_value.Content score
                    lbl_Player_2_value.Content = player2.score;
                    ///sets the text of the status to player 2 wins
                    tb_player_wins.Text = "Player 2 Wins!!!";
                    ///sets the bisgamestarted to false to end selection
                    bisGameStarted = false;
                }
                ///Check if it is player 2 for win
                else if (player2.isTurn)
                {
                    ///Highlight winning row, column, diag
                    HighlightWinningMove();
                    ///Because they offset if it changes on a winning move it is player 1 points
                    player1.newPlayerScore();
                    ///sets the score for lbl_Player_1_value.Content score
                    lbl_Player_1_value.Content = player1.score;
                    ///sets the text of the status to player 1 wins
                    tb_player_wins.Text = "Player 1 Wins!!!";
                    ///sets the bisgamestarted to false to end selection
                    bisGameStarted = false;
                }
            }
            ///Checks to see if it a VertWin
           else if (IsVertWin)
            {
                ///Check if it is player 1 turn
                if (player1.isTurn)
                {
                    ///Highlight winning row, column, diag
                    HighlightWinningMove();
                    ///if so increment player 2 score and set the tb to player 2 wins
                    player2.newPlayerScore();
                    ///sets the score for lbl_Player_2_value.Content score
                    lbl_Player_2_value.Content = player2.score;
                    ///sets the text of the status to player 2 wins
                    tb_player_wins.Text = "Player 2 Wins!!!";
                    ///sets the bisgamestarted to false to end selection
                    bisGameStarted = false;
                }
                else if (player2.isTurn)
                {
                    ///Highlight winning row, column, diag
                    HighlightWinningMove();
                    ///Because they offset if it changes on a winning move it is player 1 points
                    player1.newPlayerScore();
                    ///sets the score for lbl_Player_1_value.Content score
                    lbl_Player_1_value.Content = player1.score;
                    ///sets the text of the status to player 1 wins
                    tb_player_wins.Text = "Player 1 Wins!!!";
                    ///sets the bisgamestarted to false to end selection
                    bisGameStarted = false;
                }
            }
            ///Checks to see if it a VertWin
            else if (IsHorzWin)
            {
                ///Check if it is player 1 turn
                if (player1.isTurn)
                {
                    ///Highlight winning row, column, diag
                    HighlightWinningMove();
                    ///if so increment player 2 score and set the tb to player 2 wins
                    player2.newPlayerScore();
                    ///sets the score for lbl_Player_2_value.Content score
                    lbl_Player_2_value.Content = player2.score;
                    ///sets the text of the status to player 2 wins
                    tb_player_wins.Text = "Player 2 Wins!!!";
                    ///sets the bisgamestarted to false to end selection
                    bisGameStarted = false;
                }
                else if (player2.isTurn)
                {
                    ///Highlight winning row, column, diag
                    HighlightWinningMove();
                    ///Because they offset if it changes on a winning move it is player 1 points
                    player1.newPlayerScore();
                    ///sets the score for lbl_Player_1_value.Content score
                    lbl_Player_1_value.Content = player1.score;
                    ///sets the text of the status to player 1 wins
                    tb_player_wins.Text = "Player 1 Wins!!!";
                    ///sets the bisgamestarted to false to end selection
                    bisGameStarted = false;
                }
            }
            else if(gb.IsTie())
            {
                ///increment tie score and set it to the ties value, then display Tie!!! try again
                tie++; 
                ///set content to lbl_ties_value to tie total
                lbl_ties_value.Content = tie.ToString();
                ///sets the text of the status to Tie!!! Try Again.
                tb_player_wins.Text = "Tie!!! Try Again.";
                ///sets the bisgamestarted to false to end selection
                bisGameStarted = false;
            }

        }




        ///Check winning move to highlight
        private void HighlightWinningMove()
        {
            ///checks the ewinning move to see if it Row1
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Row1))
            {
                ///Sets the first row to yellow
                lbl_1_1.Foreground = Brushes.Yellow;
                lbl_2_1.Foreground = Brushes.Yellow;
                lbl_3_1.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Row2
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Row2))
            {
                ///Sets the second row to yellow
                lbl_1_2.Foreground = Brushes.Yellow;
                lbl_2_2.Foreground = Brushes.Yellow;
                lbl_3_2.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Row3
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Row3))
            {
                ///Sets the third row to yellow
                lbl_1_3.Foreground = Brushes.Yellow;
                lbl_2_3.Foreground = Brushes.Yellow;
                lbl_3_3.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Col1
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Col1))
            {
                ///Sets the first Column to yellow
                lbl_1_1.Foreground = Brushes.Yellow;
                lbl_1_2.Foreground = Brushes.Yellow;
                lbl_1_3.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Col2
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Col2))
            {
                ///Sets the Second Column to yellow
                lbl_2_1.Foreground = Brushes.Yellow;
                lbl_2_2.Foreground = Brushes.Yellow;
                lbl_2_3.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Col3
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Col3))
            {
                ///Sets the third Column to yellow
                lbl_3_1.Foreground = Brushes.Yellow;
                lbl_3_2.Foreground = Brushes.Yellow;
                lbl_3_3.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Diagonal 1
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Diag1))
            {
                ///Sets the first diagnonal to yellow
                lbl_1_1.Foreground = Brushes.Yellow;
                lbl_2_2.Foreground = Brushes.Yellow;
                lbl_3_3.Foreground = Brushes.Yellow;
            }
            ///checks the ewinning move to see if it Diagonal 2
            if (gb.EWinningMove.Equals(GameBoard.WinningMove.Diag2))
            {
                ///Sets the second diagonal to yellow
                lbl_3_1.Foreground = Brushes.Yellow;
                lbl_2_2.Foreground = Brushes.Yellow;
                lbl_1_3.Foreground = Brushes.Yellow;
            }
        }
        /// <summary>
        /// Clears all the labels on the tic toe board
        /// </summary>
        private void ClearLabels()
        {
           ///Clear each lable to have " ", Not NUll
            lbl_1_1.Content = " ";
            lbl_1_2.Content = " ";
            lbl_1_3.Content = " ";
            lbl_2_1.Content = " ";
            lbl_2_2.Content = " ";
            lbl_2_3.Content = " ";
            lbl_3_1.Content = " ";
            lbl_3_2.Content = " ";
            lbl_3_3.Content = " ";

            ///Set every index in the saBoard array to " " NOT NULL; 
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    gb.saBoard[i, j] = " ";

        }
        /// <summary>
        /// Resets the backgrounds of each of the labels 
        /// </summary>
        private void ResetColors()
        {
            ///Set each individual label background to transparent after a game has been played
            lbl_1_1.Background = Brushes.Transparent;
            lbl_1_2.Background = Brushes.Transparent;
            lbl_1_3.Background = Brushes.Transparent;
            lbl_2_1.Background = Brushes.Transparent;
            lbl_2_2.Background = Brushes.Transparent;
            lbl_2_3.Background = Brushes.Transparent;
            lbl_3_1.Background = Brushes.Transparent;
            lbl_3_2.Background = Brushes.Transparent;
            lbl_3_3.Background = Brushes.Transparent;

            ///Create new BrushConverter to conver foreground of each label to #FF1ECC0D green
            BrushConverter bc = new BrushConverter();
            ///Set each label background back to green after a game has been played
            lbl_1_1.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_2_1.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_3_1.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_1_2.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_2_2.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_3_2.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_1_3.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_2_3.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");
            lbl_3_3.Foreground = (Brush)bc.ConvertFrom("#FF1ECC0D");

        }
        /// <summary>
        /// Resets players turn each time the game has been played
        /// Player one always goes first 
        /// </summary>
        private void ResetPlayerTurn()
        {
            ///Resets Player1 turn
            player1.isTurn = true;
            ///Resets Player2 turn
            player2.isTurn = false; 
        }
       
        /// <summary>
        /// Resets all values to start a new game
        /// </summary>
        private void ResetValues()
        {
            ///stops input from coming in 
            bisGameStarted = false;
            ///Clears all labels back " " NOT NULL
            ClearLabels();
            ///Resets players turn 
            ResetPlayerTurn();
            ///Resets the colors of the label
            ResetColors();
            ///sets status to player 1
            tb_player_wins.Text = "Player 1 Turn";
        }
   
    }
}
