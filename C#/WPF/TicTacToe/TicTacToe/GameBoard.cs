using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
/// <summary>
/// The TicTacToe NameSpace has methods and classes to play a tic tac toe game
/// </summary>
namespace TicTacToe
{
    /// <summary>
    /// GameBoard Class holds all of the logic of the game
    /// Determines what type of win. Diagnol, Vertical, Horizontal  
    /// </summary>
    class GameBoard
    {
        /// <summary>
        /// Class Variables to keep track of ties and what positions have been filled. 
        /// </summary>
        /// saBoard is the array that holds the 3X3 values. Either (X,0). 
        public string[,] saBoard;
      // keeps track of the number of ties
        private int ties;
        // AI for computer winning 
        private WinningMove eWinningMove;

        /// <summary>
        /// Enum to see what the winning move is
        /// </summary>
        public enum WinningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
        }
        /// <summary>
        /// public property of WinningMove to get and set what row, col, and diag win there is to highlight labels
        /// </summary>
        public WinningMove EWinningMove
        {
            get
            {
                return eWinningMove;
            }
            set
            {
                eWinningMove = value;
            }


        }
        /// <summary>
        /// GameBoard Construction initializes Class variables: New saBoard 
        /// </summary>
        public GameBoard()
        {     
            ///Creates my board  
            saBoard = new string[3, 3];    
            
        }

        /// <summary>
        /// IsWinningMove helps the AI determine what the next winning move is based on the Row and Column
        /// </summary>
        /// <returns></returns>
        public bool IsWinningMove()
        {
            ///Checks for the first row if the there has been a winning move
            if(!saBoard[0, 0].Equals(" ") && saBoard[0, 0].Equals(saBoard[0, 1]) && saBoard[0, 1].Equals(saBoard[0, 2]))
            { 
                ///sets the winning move to Row1
                eWinningMove = WinningMove.Row1;
                return true; 
            }
            ///Checks for the second row if the there has been a winning move
            if (!saBoard[1, 0].Equals(" ") && saBoard[1, 0].Equals(saBoard[1, 1]) && saBoard[1, 1].Equals(saBoard[1, 2]))
            {
                ///sets the winning move to Row2
                eWinningMove = WinningMove.Row2;
                return true;
            }
            ///Checks for the third row if the there has been a winning move
            if (!saBoard[2, 0].Equals(" ") && saBoard[2, 0].Equals(saBoard[2, 1]) && saBoard[2, 1].Equals(saBoard[2, 2]))
            {
                ///sets the winning move to Row2
                eWinningMove = WinningMove.Row3;
                return true;
            }
            ///Checks for the first col if the there has been a winning move
            if (!saBoard[0, 0].Equals(" ") && saBoard[0, 0].Equals(saBoard[1, 0]) && saBoard[1, 0].Equals(saBoard[2, 0]))
            {
                ///sets the winning move to Col1
                eWinningMove = WinningMove.Col1;
                return true;
            }
            ///Checks for the second col if the there has been a winning move
            if (!saBoard[0, 1].Equals(" ") && saBoard[0, 1].Equals(saBoard[1, 1]) && saBoard[1, 1].Equals(saBoard[2, 1]))
            {
                ///sets the winning move to Col2
                eWinningMove = WinningMove.Col2;
                return true;
            }
            ///Checks for the third col if the there has been a winning move
            if (!saBoard[0, 2].Equals(" ") && saBoard[0, 2].Equals(saBoard[1, 2]) && saBoard[1, 2].Equals(saBoard[2, 2]))
            {
                ///sets the winning move to Col3
                eWinningMove = WinningMove.Col3;
                return true;
            }
            ///Checks for the first diagonal if the there has been a winning move
            if (!saBoard[0, 0].Equals(" ") && saBoard[0, 0].Equals(saBoard[1, 1]) && saBoard[1, 1].Equals(saBoard[2, 2]))
            {
                ///sets the winning move to Diag1
                eWinningMove = WinningMove.Diag1;
                return true;
            }
            ///Checks for the second diagonal if the there has been a winning move
            if (!saBoard[2, 0].Equals(" ") && saBoard[2, 0].Equals(saBoard[1, 1]) && saBoard[1, 1].Equals(saBoard[0, 2]))
            {
                ///sets the winning move to Diag2
                eWinningMove = WinningMove.Diag2;
                return true;
            }
            return false;

        }
        /// <summary>
        /// Type of Wins 
        /// </summary>
        /// <returns></returns>
        /// IsDiagonalWin method Checks to see if cell (0,0), (1,1), (2,2) or (0,2), (1,1),(2,2) are filled with X or 0 to see if there are three in a row in the saBoard Array
        public bool IsDiagonalWin()
        {
            ///Check to see if the if there is a diagnol of X's 
            if ((saBoard[0, 0] == "X" && saBoard[1, 1] == "X" && saBoard[2, 2] == "X") ||
                (saBoard[2, 2] == "X" && saBoard[1, 1] == "X" && saBoard[0, 0] == "X") ||
                (saBoard[2, 0] == "X" && saBoard[1, 1] == "X" && saBoard[0, 2] == "X") ||
                (saBoard[0, 2] == "X" && saBoard[1, 1] == "X" && saBoard[2, 0] == "X"))
            {
                //  MessageBox.Show("IsDiagNalWin X");
                //sets the winning move for Diagonal 1
                IsWinningMove();
                return true;
            }
            ///Check to see if there is a diagnol win of O's if so return ture 
            if ((saBoard[0, 0] == "0" && saBoard[1, 1] == "0" && saBoard[2, 2] == "0") ||
                (saBoard[2, 2] == "0" && saBoard[1, 1] == "0" && saBoard[0, 0] == "0") ||
                (saBoard[2, 0] == "0" && saBoard[1, 1] == "0" && saBoard[0, 2] == "0") ||
                (saBoard[0, 2] == "0" && saBoard[1, 1] == "0" && saBoard[2, 0] == "0"))
            {
                //  MessageBox.Show("IsDiagNalWin 0");
                //sets the winning move for Diagonal 2
                IsWinningMove();
                return true;
            }
            else
            {
                ///if there is not a diagnol of X's and 0's then return false
                return false; 
            }
        }

        /// <summary>
        /// IsVertWin checks to see if any of the vertical columns in the saBoard and filled with X or 0 to see if there are three in a row; 
        /// </summary>
        /// <returns></returns>
        public bool IsVertWin()
        {
            ///Does a check for each to see if there is vertical win with either X's Column 1 
            if (saBoard[0, 0] == "X" && saBoard[1, 0] == "X" && saBoard[2, 0] == "X") { IsWinningMove(); return true;}
            ///Does a check for each to see if there is vertical win with either X's Column 2
            if (saBoard[0, 1] == "X" && saBoard[1, 1] == "X" && saBoard[2, 1] == "X") { IsWinningMove(); return true; }
            ///Does a check for each to see if there is vertical win with either X's Column 3 
            if (saBoard[0, 2] == "X" && saBoard[1, 2] == "X" && saBoard[2, 2] == "X") { IsWinningMove(); return true; }
            ///Does a check for each to see if there is vertical win with either 0's Column 1
            if (saBoard[0, 0] == "0" && saBoard[1, 0] == "0" && saBoard[2, 0] == "0") { IsWinningMove(); return true; }
            ///Does a check for each to see if there is vertical win with either 0's Column 2
            if (saBoard[0, 1] == "0" && saBoard[1, 1] == "0" && saBoard[2, 1] == "0") { IsWinningMove(); return true; }
            ///Does a check for each to see if there is vertical win with either 0's Column 3
            if (saBoard[0, 2] == "0" && saBoard[1, 2] == "0" && saBoard[2, 2] == "0") { IsWinningMove(); return true; }
          

            return false; 

        }

        /// <summary>
        /// IsHorzWin checks to see if any of the vertical columns in the saBoard and filled with X or 0 to see if there are three in a row; 
        /// </summary>
        /// <returns></returns>
        public bool IsHorzWin()
        {
            ///Checks for a Horizontal win for ROW 1, 2, 3 and it is checking for X's 
            if ((saBoard[0, 0] == "X" && saBoard[0, 1] == "X" && saBoard[0, 2] == "X") ||
                (saBoard[0, 2] == "X" && saBoard[0, 1] == "X" && saBoard[0, 0] == "X") ||
                (saBoard[1, 0] == "X" && saBoard[1, 1] == "X" && saBoard[1, 2] == "X") ||
                (saBoard[1, 2] == "X" && saBoard[1, 1] == "X" && saBoard[1, 0] == "X") ||
                (saBoard[2, 0] == "X" && saBoard[2, 1] == "X" && saBoard[2, 2] == "X") ||
                (saBoard[2, 2] == "X" && saBoard[2, 1] == "X" && saBoard[2, 0] == "X"))
            {
                // MessageBox.Show("IsHorzWin X");
                //if it finds a horizontal win with all x's it returns true; 
                IsWinningMove();
                return true;

            }
            ///Checks for a Horizontal win for ROW 1, 2, 3 and it is checking for 0's 
            if ((saBoard[0, 0] == "0" && saBoard[0, 1] == "0" && saBoard[0, 2] == "0") ||
                (saBoard[0, 2] == "0" && saBoard[0, 1] == "0" && saBoard[0, 0] == "0") ||
                (saBoard[1, 0] == "0" && saBoard[1, 1] == "0" && saBoard[1, 2] == "0") ||
                (saBoard[1, 2] == "0" && saBoard[1, 1] == "0" && saBoard[1, 0] == "0") ||
                (saBoard[2, 0] == "0" && saBoard[2, 1] == "0" && saBoard[2, 2] == "0") ||
                (saBoard[2, 2] == "0" && saBoard[2, 1] == "0" && saBoard[2, 0] == "0"))
            {
                // MessageBox.Show("IsHorzWin 0");
                //if it finds a horizontal win with all 0's it returns true;
                IsWinningMove();
                return true;

            }

            return false;
        }
        /// <summary>
        /// increments the ties count and returns the tie value; 
        /// </summary>
        /// <returns></returns>
        public bool IsTie()
        {
            ///Increment tie variable and return tie to add to the tie score
            ///iterates through the board to see what is left blank
            int count = 0; 
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if(saBoard[i, j] != " ")
                    {
                        count++; 
                    }
                }
            ///Checks to see if the all indexes of are full and if there isn't a win
            if(count == 9 && !IsDiagonalWin() && !IsHorzWin() && !IsVertWin())
            {
                return true; 
            }
           ///return false if board is not full and if there is a win
            return false;
           
        }

  
    }
}
