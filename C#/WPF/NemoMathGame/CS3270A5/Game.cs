using System;
using System.Windows;
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
    /// Game class has all of the nemo math logic 
    /// </summary>
    public class Game 
    {
        //Random Generator
        Random rnd;

        
       /// <summary>
       /// public property time to keep track of the time for the game
       /// </summary>
        public int time { get; set; }
        /// <summary>
        /// public property correctAnswer to keep track of the correct answers for each game
        /// </summary>
        public int correctAnswer { get; set; }
        /// <summary>
        /// public property incorrect answer to keep track of the incorrect answers for each game
        /// </summary>
        public int incorrectAnswer { get; set; }
        /// <summary>
        /// public property GameMode to keep track of the gamemode for each game played
        /// </summary>
        public string GameMode { get; set; }
        /// <summary>
        /// public property result to keep track of the result of the math statement
        /// </summary>
        public int result { get; set; }
        /// <summary>
        /// public property numOfQuestions to keep count of the number of questions asked each game
        /// </summary>
        public int numOfQuestions { get; set; } 
        /// <summary>
        /// Game Constructor that initializes the time, correct answer, incorrect answer, gamemode
        /// numOfquestions and the random generator
        /// </summary>
        public Game()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                time = 0;
                correctAnswer = 0;
                incorrectAnswer = 0;
         
                GameMode = "";
                numOfQuestions = 0; 
             
                rnd = new Random();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
        /// <summary>
        /// AddStatment puts the add math statement and gets the result of the statement
        /// </summary>
        /// <returns></returns>
        public string AddStatement()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///gets the first number randomly 
                int firstNumber = rnd.Next(0, 10);
                ///gets the second number randomly
                int secondNumber = rnd.Next(0, 10);
                ///sets the result of the addition statement
                result = firstNumber + secondNumber; 
                ///returns the string of the statement
                return firstNumber.ToString() + " + " + secondNumber.ToString() + " = " ;
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        /// <summary>
        /// subtractstatement returns the subtract math statment and gets the result of subtracting the first number for the second
        /// </summary>
        /// <returns></returns>
        public string SubtractStatement()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///gets the first number randomly
                int firstNumber = rnd.Next(0, 10);
                ///gets the second number randomly
                int secondNumber = rnd.Next(0, 10);
                ///checks to see if firstnumber is greater than second number
                if(firstNumber > secondNumber)
                {
                    ///gets the result of the subtraction statement
                    result = firstNumber - secondNumber;
                    ///returns the subtraction statment
                    return firstNumber.ToString() + " - " + secondNumber.ToString() + " = ";
                }
                ///sets the result if the second number is greater than the first number
                result = secondNumber - firstNumber; 
                ///returns the subtraction statement 
                return secondNumber.ToString() + " - " + firstNumber.ToString() + " = ";
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        /// <summary>
        /// MultiplyStatement returns a string of multiplication statement and sets the result of the muliplication statement
        /// </summary>
        /// <returns></returns>
        public string MultiplyStatement()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///gets the first number randomly
                int firstNumber = rnd.Next(0, 10);
                ///gets the second number randomly
                int secondNumber = rnd.Next(0, 10);
                ///sets the result of the of muliplication statement
                result = firstNumber * secondNumber;
                ///returns the string of the muliplication statement
                return firstNumber.ToString() + " * " + secondNumber.ToString() + " = ";
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        /// <summary>
        /// Division statement returns a division math statement and gets the result of that division statement
        /// </summary>
        /// <returns></returns>
        public string DivideStatement()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///sets a flag to to loop through to get a whole number
                bool flag = true;
                ///while loop to find a whole number
                while (flag)
                {
                    ///gets a small number betwen 1 and 5 for first number
                    int firstNumber = rnd.Next(1, 5);
                    //gets a small number between 1 and 5 for first number
                    int secondNumber = rnd.Next(1, 5);
                    ///multiplies the first number by secondnumber to get a whole number
                    int firstNumberRes = firstNumber * secondNumber;
                    ///checks to see if it divid by each other to get a whole number
                    if (firstNumberRes % secondNumber == 0)
                    {
                        ///sets result of the first number result by the second number
                        result = firstNumberRes / secondNumber;
                        ///returns the division statement
                        return firstNumberRes.ToString() + " / " + secondNumber.ToString() + " = ";
                    }
           
                }
                ///returns emptey if not 
                return "";
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
