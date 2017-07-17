using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
/// <summary>
/// CS3270A5 Namespace 
/// Classes GameWindow, MainWindow, Scores, Game, GameType, Users
/// Nemo game to help little ones want to do Math
/// </summary>
namespace CS3270A5
{
    /// <summary>
    /// Scores class is to keep a list of scores
    /// </summary>
    public class Scores
    {
        /// <summary>
        /// Static list of scores to keep record
        /// </summary>
        public static List<Scores> listOfScores = new List<Scores>();
        /// <summary>
        /// public propert name to create the score object
        /// </summary>
        public string name { get; }
        /// <summary>
        /// public int property incorrectAnswer to get incorrect answer
        /// </summary>
        public int incorrectAnswer { get; }
        /// <summary>
        /// public property correctAnswer to get the totoal of correct answers
        /// </summary>
        public int correctAnswer { get;  }
        /// <summary>
        /// public property to get the time amount for the game played
        /// </summary>
        public int time { get;  }
        /// <summary>
        /// Scores contructor to create score objects
        /// </summary>
        /// <param name="PlayerName"></param>
        /// <param name="PlayerCorrectAnswer"></param>
        /// <param name="PlayerIncorrectAnswer"></param>
        /// <param name="PlayerTime"></param>
        public Scores(string PlayerName, int PlayerCorrectAnswer, int PlayerIncorrectAnswer, int PlayerTime)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///sets the name of the player
                name = PlayerName;
                ///sets the player incorrect answers for the score object
                incorrectAnswer = PlayerIncorrectAnswer;
                ///sets the player correct answers for the score object
                correctAnswer = PlayerCorrectAnswer;
                ///sets the player time afor the score object
                time = PlayerTime;
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// AddScore adds player and scores to List 
        /// </summary>
        /// <param name="score"></param>
        public static void AddScore(Scores score)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///adds a score to static list of scores
                listOfScores.Add(score);
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
