using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// GameBoard Class holds all of the logic of the game
/// Determines what type of win. Diagnol, Vertical, Horizontal  
/// </summary>
namespace TicTacToe
{
    /// <summary>
    /// The player class is used to create players and keep track of the score and turn 
    /// </summary>
    class Player
    {
        /// <summary>
        /// Player property Attributes 
        /// </summary>
        public int player_id { get; set ; }
        public string name { get; set; }
        public int score { get; set; }
        public bool isTurn { get; set; }
        /// <summary>
        /// numPlayers keeps track of how many total players
        /// </summary>
        private static int numPlayers = 0; 
        /// <summary>
        /// Player(playerId, name) was to give a choice to the players if they chose to have one or two players 
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="name"></param>
        public Player(int playerId, string name)
        {
            this.player_id = playerId + 1;
            this.name = name;
            this.score = 0; 
        }
        /// <summary>
        /// Default constructor to just initialize a single player 
        /// </summary>
        public Player()
        {
            numPlayers++; 
            this.player_id =  numPlayers;
            this.name = "Player" + numPlayers.ToString();
            this.score = 0;
            this.isTurn = false; 
        }

        /// <summary>
        /// increments the score on a win
        /// </summary>
        public void newPlayerScore()
        {
            score++; 
        }





    }
}
