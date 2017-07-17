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
    /// Interaction logic for GameType.xaml
    /// </summary>
    public partial class GameType : Window
    {
        /// <summary>
        /// Declare player to use player information Name and Age
        /// </summary>
        User player;
       /// <summary>
       /// GameType Constructor that initializes the dialog, Asks the question and initializes new User()
       /// </summary>
        public GameType()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                InitializeComponent();
                lbl_Question.Content = "Select Type of Game";
                player = new User();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// public property to get and set player object
        /// </summary>
        public User Player
        {
            get
            {
                ///return the player object
                return player; 
            }
            set
            {
                ///set player object
                player = value; 
            }
        }
        /// <summary>
        /// Answer to the question asked in the Constructor and set the gamemode
        /// </summary>
        public String Answer
        {
            get
            {
                ///returns the what the gamemode is. This check is for Addition
                if (rb_add.IsChecked == true)
                {
                    return "Add"; 
                }
                else if(rb_subtraction.IsChecked == true)
                {
                    ///returns the what the gamemode subtraction.
                    return "Subtraction";
                }
                else if(rb_multiply.IsChecked == true)
                {
                    ///returns the what the gamemode Multiplication.
                    return "Multiply";
                }
                else
                {
                    ///returns the what the gamemode Division.
                    return "Divide"; 
                }
            }
            
        }
        /// <summary>
        /// Button click to close gametype dialog and set the gamboard for the GameWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initializes new GameWindow
                GameWindow gw = new GameWindow(Player, Answer);
                ///Set the gameboard gamemode with an answer
                gw.GameBoard.GameMode = Answer; 
                ///Sets the Dialog Result to true
                this.DialogResult = true;
                ///Closes the GameType Window
                this.Close(); 
                ///Shows the GameWindow
                gw.ShowDialog();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
        /// <summary>
        /// Btn_cancel_click cancels to the MainWindow 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initializes the main window(); 
                MainWindow mw = new MainWindow();
                ///sets the Main window player
                mw.Player = Player;
                ///closes the GameType dialog
                this.Close(); 
                ///Shows the MainWindow dialog
                mw.ShowDialog();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
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
