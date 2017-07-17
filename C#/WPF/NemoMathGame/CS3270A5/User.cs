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
    /// public class User is used to create objects for players 
    /// </summary>
    public class User
    {
           /// <summary>
           /// Every player needs a name 
           /// </summary>
           private string name;
            /// <summary>
            /// Every player needs an age
            /// </summary>
           private int age;
       
            /// <summary>
            /// score to keep track of the player score 
            /// </summary>
           private int score; 
     

            /// <summary>
            /// User contructor to initialize class variables (e.g. Name, age)
            /// </summary>
            public User()
            {
                ///Try executing if problem call HandleError to display the error Message; 
                try
                {
                    ///initialize string name
                    name = "";
                    ///initialize int age
                    age = 0;
                    ///initializes score
                    score = 0;
                }
                catch (Exception ex)
                {
                    /// Call handleError Method to display the exception
                    HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
                }

            }

            /// <summary>
            /// getter and setter for private variable string name
            /// </summary>
            public string Name
            {
                get
                {
                    ///return the name of the player in user
                    return name; 
                }
                set
                {
                    ///sets the name of the player in user
                    name = value; 
                }
            }

            /// <summary>
            /// getter and setter for private member int age
            /// </summary>
            public int Age
            {
                get
                {
                    ///returns the age of the User
                    return age; 
                }
                set
                {
                    ///sets the age of the user
                    age = value; 
                }
            }

         /// <summary>
         /// public property score to get and set the score private attribute
         /// </summary>
         public int Score
         {
                get
                {
                    ///return the value of score
                    return score;
                }
                set
                {
                    ///set the value of score
                    score = value; 
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
