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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Media;
using System.Reflection;

/// <summary>
/// CS3270A5 Namespace 
/// Classes GameWindow, MainWindow, Scores, Game, GameType, Users
/// Nemo game to help little ones want to do Math
/// </summary>

namespace CS3270A5
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {

        /// <summary>
        /// Declaration of User to use the player information Name and Age;
        /// </summary>
        User player;
        /// <summary>
        /// Declartiona of Game to use properties of game for the gamboard
        /// </summary>
        Game gameBoard;
        /// <summary>
        /// Declaration of SoundPlayer to play .wav file
        /// </summary>
        SoundPlayer simpleSound;

        /// <summary>
        /// GameWindow constructor that initializes sets player, creates new instance of game, 
        /// Initializes the Timer, Points to a .wav file
        /// </summary>
        /// <param name="player"></param>
        /// <param name="GameMode"></param>
        public GameWindow(User player, string GameMode)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///initialize GameWindow Window
                InitializeComponent();
                ///Sets this class player to player passed into by the game type
                this.player = player;
                ///initialize a new game
                gameBoard = new Game();
                ///Timers call to initialize new timer
                Timers();
                ///Initialize sound file and points to Crowd_Applause.wav
                simpleSound = new SoundPlayer(@"Crowd_Applause.wav");
                ///Set player name label to player object name
                lbl_player_name.Content = player.Name;
                ///Set player age label to player object age
                lbl_age.Content = player.Age.ToString();
                ///Set player score label to gamboard object correctAnswer
                lbl_player_score_value.Content =  gameBoard.correctAnswer.ToString(); 
                ///Set GameMode lable to GameMode from gameType
                lbl_game_mode_value.Content = GameMode;
                ///Set gameboard game object to GameMode from game type
                gameBoard.GameMode = GameMode;
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Player public property to get and set player object 
        /// </summary>
        public User Player
        {
            get
            {
                ///returns player object
                return player;
            }
            set
            {
                player = value;
                ///Sets player name label to player object name
                lbl_player_name.Content = Player.Name;
            }

        }

        /// <summary>
        /// public Game GameBoard propert get and set gameboard private object
        /// </summary>
        public Game GameBoard
        {
            get
            {
                /// returns Game gameboard object
                return gameBoard; 
            }
            set
            {
                /// sets Game gameboard object 
                gameBoard = value;
                ///sets game mode value labe to gameBoard.gamemode 
                lbl_game_mode_value.Content = gameBoard.GameMode;
            }
        }

        /// <summary>
        /// button_click starts the the timer and initializes the first math object 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Sets the readonly propert the textbox math statement value
                tb_math_statement_value.IsReadOnly = false;
                ///Starts the timer 
                Start();
                ///Sets the math statement content to the mode selected
                lbl_math_statement.Content = checkMode();
                ///clears the math statement value textbox
                tb_math_statement_value.Clear();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Checks what mode has been picked by the User
        /// </summary>
        /// <returns></returns>
        public String checkMode()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Checks to see if the gamemode selected is addition, subtraction, multiplication, division
                if (gameBoard.GameMode == "Add")
                {
                    ///returns the addition statement
                    return gameBoard.AddStatement();
                }
                else if (gameBoard.GameMode == "Subtraction")
                {
                   ///returns the subtraction statment
                   return gameBoard.SubtractStatement();
                }
                else if (gameBoard.GameMode == "Multiply")
                {
                    ///returns the multiplication statement
                    return gameBoard.MultiplyStatement();
                }
                else
                {
                    ///returns the division statement
                    return gameBoard.DivideStatement(); 
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }


        /// <summary>
        /// math statement value key down is for the key enter. When user presses enter it will check
        /// to see if answer is correct and add the new statment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_math_statement_value_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Checks to make sure the Enter key was pressed
                if (e.Key == Key.Enter)
                {
                    //checkAnswer call checks if the answer is correct
                    checkAnswer();

                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// submit button click is the check answer and display new math statement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                //checkAnswer call checks if the answer is correct
                checkAnswer();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// CheckAnswer has a lot of the game logic. Checks if answer is correct, shows correct and wrong animation
        /// Sets labels for the correct and incorrect answers
        /// </summary>
        public void checkAnswer()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///result for tryParse out
                int result = 0;
                ///Checks to see if input into the textbox is a integer
                if (Int32.TryParse(tb_math_statement_value.Text, out result))
                {
                    ///check to see if gameBoard object result is the same as input
                    if (gameBoard.result == result)
                    {
                        ///sets happy nemo image to be visible
                        HappyNemo.Visibility = Visibility.Visible; 
                        ///causes the animation for the for the nemo image to fade in and out
                        Animation.ChangeSource(HappyNemo,HappyNemo.Source, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(3));
                        ///set incorrect or correct content to Correct
                        lbl_incorrect__or_correct.Content = "Correct";
                        ///increments the gameboard correct answer 
                        gameBoard.correctAnswer++;
                        ///sets the player score value content to the new gamboard correct answer count
                        lbl_player_score_value.Content = gameBoard.correctAnswer; 
                        ///set the player score to the new correct answer
                        player.Score = gameBoard.correctAnswer;
                        ///Converts and sets the new time in the Game gameBoard object time 
                        gameBoard.time = Convert.ToInt32(lbl_game_time_value.Content);
                        ///Gets a count of the number of questions  
                        gameBoard.numOfQuestions++;
                        ///Sets the math statement content to new question 
                        lbl_math_statement.Content = checkMode();
                        /// clears the math statement value label
                        tb_math_statement_value.Clear();
                        ///checks to see if there has been 10 questions asked
                        if (gameBoard.numOfQuestions == 10)
                        {
                            ///checks to see if all answers were answered correctly
                            if(GameBoard.correctAnswer == 10)
                            {
                                ///plays the clapping .wav file
                                simpleSound.Play();
                            }
                            ///stops the timer
                            Stop();
                            ///adds player score to the static score list 
                            AddScore();
                            ///sets the text to read only until they press the start game button again
                            tb_math_statement_value.IsReadOnly = true;
                        }
                    }
                    else
                    {
                        ///sets the upsetnemo image to visible 
                        UpsetNemo_png.Visibility = Visibility.Visible;
                        //uses the Animation class to fade in and out the upset nemo 
                        Animation.ChangeSource(UpsetNemo_png, UpsetNemo_png.Source, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(3));
                        ///sets the incorrect or correct content label to incorrect
                        lbl_incorrect__or_correct.Content = "Incorrect";
                        ///increments the incorrectAnswer 
                        gameBoard.incorrectAnswer++;
                        ///increments the numofquestions asked
                        gameBoard.numOfQuestions++;
                        ///sets the math statement content label with the new statement
                        lbl_math_statement.Content = checkMode();
                        ///Clears the tb math statement value 
                        tb_math_statement_value.Clear();
                        ///checks to see if the there has been 10 questiions left
                        if (gameBoard.numOfQuestions == 10)
                        {
                            ///stops the timer
                            Stop();
                            ///adds the score to the static score list 
                            AddScore();
                            ///clears all the answers 
                            clearAnswers();
                            ///sets the math statement textbox to read only 
                            tb_math_statement_value.IsReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }
        
        /// <summary>
        /// this method shows the static list in a richtextbox in order
        /// </summary>
        public void ShowScoreBoard()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Pass all values of player and gameboard
                ScoreBoard sb = new ScoreBoard(player, gameBoard);
                ///Shows the scoreBoard dialog             
                sb.ShowDialog();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }
        /// <summary>
        /// AddsScore Method adds the score to the static score list
        /// </summary>
        public void AddScore()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Create new score object to so I can add it to the static score list
                Scores score = new Scores(player.Name, gameBoard.correctAnswer, gameBoard.incorrectAnswer, gameBoard.time);
                ///Adds to the static score list 
                Scores.AddScore(score);
                ///sorts the list to so that highest score is the higest
                Scores.listOfScores.Sort(delegate (Scores x, Scores y)
                {
                    ///checks to see if the number of correct is the same
                    if (x.correctAnswer == y.correctAnswer)
                    {
                        ///if the number of correct answers is the same the condition is based on the time
                        if (x.time < y.time)
                        {
                            ///return -1 if this is true
                            return -1;
                        }
                        else if (y.time < x.time)
                        {
                            ///return 1 if this is true
                            return 1;
                        }


                    }
                    else if (x.correctAnswer > y.correctAnswer)
                    {
                        /// if the x correctAnswer is greate then the y.corret answer return -1
                        return -1;
                    }
                    else if (y.correctAnswer > x.correctAnswer)
                    {
                        /// if the y correctAnswer is greate then the x.correct answer return 1
                        return 1;
                    }
                    //else return 0
                    return 0;

                });
                ///clear answers
                clearAnswers();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }
        /// <summary>
        /// Clears the answer for correct, incorrect, time, and number of questions to start a new game
        /// </summary>
        public void clearAnswers()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///clear the gameboard object correct answer
                gameBoard.correctAnswer = 0;
                ///clear the gameboard object incorrect answer
                gameBoard.incorrectAnswer = 0;
                ///clear the gameboard object time answer
                gameBoard.time = 0;
                ///clear the gameboard object numOfQuestions answer
                gameBoard.numOfQuestions = 0;
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }

        /// <summary>
        /// btn_end_game_click shows the score card to see what user score is the highest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_end_game_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///shows the scoreboard to see scores
                ShowScoreBoard();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }

       



//*********************************Timer****************************//
        /// <summary>
        /// Timer declaration to use the timer feature
        /// </summary>
        private Timer timer;
        /// <summary>
        /// declaration for public property count to keep track of how many seconds
        /// </summary>
        private int count { get; set; }

        
        /// <summary>
        /// initializes the timer object
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
                ///initialize count to 0
                count = 0;
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }

        }
        //Stop the timer 
        public void Stop()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///set the timer to false to stop the timer
                timer.Enabled = false;
                ///set count equal to zero
                count = 0;
                ///set the game time value label to zero
                lbl_game_time_value.Content = 0; 
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);

            }
        }

        /// <summary>
        /// Start the timer
        /// </summary>
        public void Start()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {

                timer.Enabled = true;


            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
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
                lbl_game_time_value.Content = count.ToString();
                ///if the count gets to 150 seconds stop the timer and count = 0
                if (count == 150)
                {
                    ///set count to zero
                    count = 0;
                    ///stop the timer
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
        /// btn_main menu click goes to the main menu to change user if player desires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_main_menu_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Create new main window object
                MainWindow mw = new MainWindow();
                ///close Game Window Object
                this.Close();
                //show the main window objec
                mw.ShowDialog();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Menu item exit gamewindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Exit Game Window
                this.Close();
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

    /// <summary>
    /// Static class Animation is to handle the fade in and out of the images in the game Window
    /// </summary>
    public static class Animation
    {
       /// <summary>
       /// Static method to pass in the image source fadouttime and fadeintime
       /// </summary>
       /// <param name="image"></param>
       /// <param name="source"></param>
       /// <param name="fadeOutTime"></param>
       /// <param name="fadeInTime"></param>
       public static void ChangeSource(
       this Image image, ImageSource source, TimeSpan fadeOutTime, TimeSpan fadeInTime)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///initializes the animation fadeintime
                var fadeInAnimation = new DoubleAnimation(1d, fadeInTime);
                ///checks to make sure the source file is there
                if (image.Source != null)
                {
                    ///sets the fadoutanimation time
                    var fadeOutAnimation = new DoubleAnimation(0d, fadeOutTime);
                    ///Checks to see when the fade out is complete
                    fadeOutAnimation.Completed += (o, e) =>
                    {
                        ///sets the source to the image
                        image.Source = source;
                        ///begins the fadein animation 
                        image.BeginAnimation(Image.OpacityProperty, fadeInAnimation);
                        ///sets the visibility to hidden
                        image.Visibility = Visibility.Hidden;
                    };
                    ///sets the opacity of the fadout animation
                    image.BeginAnimation(Image.OpacityProperty, fadeOutAnimation);
                }
                else
                {
                   //sets the opacity of the image
                   image.Opacity = 0d;
                   //sets the souce of the image
                   image.Source = source;
                    ///begins that opacity and fade in animation
                   image.BeginAnimation(Image.OpacityProperty, fadeInAnimation);
                }
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        
    }
}
