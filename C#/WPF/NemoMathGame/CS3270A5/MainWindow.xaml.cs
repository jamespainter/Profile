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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Reflection;

/// <summary>
/// CS3270A5 Namespace 
/// Classes GameWindow, MainWindow, Scores, Game, GameType, Users
/// Nemo game to help little ones want to do Math
/// </summary>
namespace CS3270A5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Main window Gets the game started. User has to put in their name and age before they can play
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// User Player is used to set the name and age so that User can play game.
        /// </summary>
        User player; 
        /// <summary>
        /// Main Window Constructor. Initializes the player to enter user information 
        /// </summary>
        public MainWindow()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initializes the Main Window Component
                InitializeComponent();
                ///Initialize Player to enter user information 
                player = new User();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
       
        /// <summary>
        /// Public property to get and set private attribute player
        /// </summary>
        public User Player
        {

            get
            {
                ///returns player value 
                return player; 
            }
            set
            {
                ///sets User Objet player
                player = value;
               
            }

        }


        /// <summary>
        /// Move Nemos Dad and Nemo
        /// </summary>
        /// <param name="target"></param>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        public void MoveFish(Image target, double newX, double newY)
        {

            ///Try executing the animation behavior if problem call HandleError to display the error Message; 
            try { 
                ///gets the top dimension of the canvas
                var top = Canvas.GetTop(this);
                ///gets the left dimension of the canvas
                var left = Canvas.GetLeft(this);
                ///Initializes TranslateTransform object to move images
                TranslateTransform trans = new TranslateTransform();
                ///Sets image up to transform
                target.RenderTransform = trans;
                ///Moves image from bottom upward
                DoubleAnimation anim1 = new DoubleAnimation(top, newY - top, TimeSpan.FromSeconds(10));
                ///Moves left to right
                DoubleAnimation anim2 = new DoubleAnimation(left, newX - left, TimeSpan.FromSeconds(10));
                ///Begins the movement for image
                trans.BeginAnimation(TranslateTransform.XProperty, anim1);
                ///Begins the movement for image
                trans.BeginAnimation(TranslateTransform.YProperty, anim2);
            }
            catch(Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        
        /// <summary>
        /// Sets Canvas up when screen is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Makes the call to move the nemo fish
                MoveFish(img_ActualNemo, 25, 350);
                ///Makes the call to move the shark
                MoveFish(Shark_png, 100, 120);
                ///initializes timer to show buttons
                Timers();
                ///Starts timer 
                Start();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
        /// <summary>
        /// User Info Event Click to create new instance User information and close the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_user_info_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Create new instance of userInformation to show UserInformation Dialog
                UserInformation ui = new UserInformation();
                ///Close MainWindow Instance
                this.Close();
                ///Shows the User Information Diaglog 
                ui.ShowDialog();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
        ///Start Time For Main Window     
        private Timer timer;
        /// <summary>
        /// Keeps track of the timer for the when to show the Playe game and UserInformation Button
        /// </summary>
        private int count { get; set; }

        
        /// <summary>
        /// Creates a new instance of a timer 
        /// </summary>
        public void Timers()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                //initialize timer
                timer = new Timer();
                //Trigger event handler TimeOut
                timer.Tick += new EventHandler(TimeOut);

                //Intervale is set in ms. 1000ms = 1 second
                timer.Interval = 1000;
                //Timer is set to stop 
                timer.Enabled = false;

                count = 0;
            
            }
            catch(Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
}
        /// <summary>
        /// Stop timer
        /// </summary>
        public void Stop()
        {
            try
            {
                ///Disables Timer
                timer.Enabled = false;

            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        /// <summary>
        /// Start timer
        /// </summary>
        public void Start()
        {
            try
            {
                ///Enables Timer
                timer.Enabled = true;


            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }
      
        //Timeout is an Event that is triggered by the timer.Tick += new EventHandler(Timeout) every second
        private void TimeOut(Object myObject, EventArgs myEventArgs)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                //Counter to get a number get time in seconds 
                count++;
                //Test for Debugging
                textBox.Text = count.ToString(); 

                //Condition to check after five seconds
                if (count == 3)
                {

                    //Call game.GameOver()
                    /// Visibility for the Start Button
                    btn_edit_user_info.Visibility = Visibility.Visible;
                    /// Visibility for the Start Button
                    btn_start_game.Visibility = Visibility.Visible; 
                    //set counter to zero
                    count = 0;
                    Stop(); 
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// btn_start_game_Click event to start to play game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_game_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Checks to see if the Name or is null or not 
                if (!String.IsNullOrEmpty(player.Name) && player.Age > 0)
                {
                    ///Show Game Mode Window 
                    GameType gamemode = new GameType();
                    ///Passes player to GameType
                    gamemode.Player = player;
                    ///Closes Main Menu
                    this.Close(); 
                    ///Shows GameType Window
                    gamemode.ShowDialog();
               
                }
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
        /// <summary>
        /// MenuItemClick to Exit Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Closes Main Menu
                this.Close();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Another way to start the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Checks to see if the Name or is null or not 
                if (!String.IsNullOrEmpty(player.Name) && player.Age > 0)
                {
                    ///Show Game Mode Window 
                    GameType gamemode = new GameType();
                    ///Passes player to GameType
                    gamemode.Player = player;
                    ///Closes Main Menu
                    this.Close();
                    ///Shows GameType Window
                    gamemode.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        ///  User Info Event Click to create new instance User information and close the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Create new instance of userInformation to show UserInformation Dialog
                UserInformation ui = new UserInformation();
                ///Close MainWindow Instance
                this.Close();
                ///Shows the User Information Diaglog 
                ui.ShowDialog();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
   
}
