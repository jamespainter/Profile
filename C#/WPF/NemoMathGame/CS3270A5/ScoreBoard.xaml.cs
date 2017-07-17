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
using System.Windows.Shapes;
using System.Reflection;

/// <summary>
/// CS3270A5 Namespace 
/// Classes GameWindow, MainWindow, Scores, Game, GameType, Users
/// Nemo game to help little ones want to do Math
/// </summary>
namespace CS3270A5
{
    /// <summary>
    /// Interaction logic for ScoreBoard.xaml
    /// </summary>
    public partial class ScoreBoard : Window
    {

        /// <summary>
        /// Declaration for User for use of player information 
        /// </summary>
        User player;
        /// <summary>
        /// Declaration for Game for use of game infomation specifically gamemode
        /// </summary>
        Game game; 
        /// <summary>
        /// ScorBoardWindow shows the list of results for each time a game was played
        /// </summary>
        /// <param name="player"></param>
        /// <param name="game"></param>
        public ScoreBoard(User player, Game game)
        {
            ///Try executing the animation behavior if problem call HandleError to display the error Message; 
            try
            {
                ///intializes the ScoreBoard window
                InitializeComponent();
                ///sets the player to user the information
                this.player = player;
                ///sets the this game object to game to use the game information 
                this.game = game;
                ///sets the player name content label to palyer name
                lbl_player_name.Content = this.player.Name;
                ///clears the rich text box 
                ClearRTB();
                
                ///loops for each score in the static listof scores 
                foreach(Scores score in Scores.listOfScores)
                {
                    ///formats the scores list and appends it to the rich text box
                    rtb_Scores.AppendText(score.name + " - " + score.correctAnswer.ToString() + " - " + score.incorrectAnswer.ToString() + " - " + score.time.ToString());
                    ///adds a new to every entry in the rtb
                    rtb_Scores.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// clears the all text in the rich text box
        /// </summary>
        public void ClearRTB()
        {
            ///Try executing the animation behavior if problem call HandleError to display the error Message; 
            try
            {
                ///selects all text in the rich text box
                rtb_Scores.SelectAll();
                /// sets the the rich text box text to empty
                rtb_Scores.Selection.Text = "";
                /// adds the headers 
                rtb_Scores.AppendText("Name" + "  " + "CA" +" "+ "IA" +" "+ "Times");
                rtb_Scores.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing the animation behavior if problem call HandleError to display the error Message; 
            try
            {
                ///closes the score board window
                this.Close();
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        /// <summary>
        /// HandleError displays any exception in the MainWindow class 
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {

            /// This will try to display the exception by saying what class method and message
            try
            {
                //Would write to a file or database here.
                System.Windows.MessageBox.Show(sClass + "." + sMethod + "->" + sMessage);


            }
            catch (Exception ex)
            {
                ///If there is an error it will write the error to a Error.txt file on the c:\drive
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }

        }
    }
}
