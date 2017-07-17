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
    /// Interaction logic for UserInformation.xaml
    /// </summary>
    public partial class UserInformation : Window
    {
        /// <summary>
        /// Declaration of the player
        /// </summary>
        User player;
        /// <summary>
        /// User information constructor to initialize the window and create a new instance of User
        /// </summary>
        public UserInformation()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                InitializeComponent();
                player = new User();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// textbox1 gotfocus removes text that is in the text box for the user to enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                TextBox textbox = (TextBox)sender;
                textbox.Text = "";
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// AddText adds text to the text box if the there is nothing in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddText(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///create a new textbox object from and sets it to the sender
                TextBox textbox = (TextBox)sender;
                ///checks to see what type of object. if it is txtbox_user_name
                if (textbox.Name == "txtbox_user_name")
                {
                    ///checks to see if it is null. 
                    if (String.IsNullOrWhiteSpace(textbox.Text))
                        ///if it is null then it will add text to textbox
                        textbox.Text = "Enter Name Here...";
                }
                else
                {
                    ///checks to see if it is null.
                    if (String.IsNullOrWhiteSpace(textbox.Text))
                        ///if it is null then it will add text to textbox
                        textbox.Text = "Enter Age Here...";
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summuary>
        /// textbox user name lost focus checks what textbox object and enters text or sets the player object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbox_user_name_LostFocus(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Sets a text box to sender
                TextBox textbox = (TextBox)sender;
                ///checks to see if it txtbox_user_name
                if (textbox.Name == "txtbox_user_name")
                {
                    ///checks to see if the textbox is null or has whitespace
                    if (String.IsNullOrWhiteSpace(textbox.Text))
                    { 
                        ///if it does it adds text 
                        textbox.Text = "Enter Name Here...";
                    }
                    else
                    {
                        ///if it is not null it will set the text to the playername object
                        player.Name = textbox.Text;
                    
                    }
                }
                else
                {
                    ///checks to see if the textbox is null
                    if (String.IsNullOrWhiteSpace(textbox.Text))
                    {
                        ///if it is null then it asks user to put in there information
                        textbox.Text = "Enter Age Here...";
                    }
                    else
                    {
                        ///initalize the int age variable to use for the out tryparse result
                        int age = 0;    
                        ///checks to see if what was entered can be converted as an int32
                        if(Int32.TryParse(textbox.Text, out age))
                        {
                            ///sets player object age to int age
                            player.Age = age;
                        }
                        else
                        {
                            ///if it cannot convert message to enter a number
                            MessageBox.Show("Enter Number"); 
                        }
                    
                    }
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// user name keydown event is used for the enter key 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbox_user_name_KeyDown(object sender, KeyEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///checks to see if the enter key was pressed 
                if (e.Key == Key.Enter)
                {
                    //create new textbox object so that event can be used for multiple events
                    TextBox textbox = (TextBox)sender;
                    ///checks to see if the textbox name is textbox_user_name
                    if (textbox.Name == "txtbox_user_name")
                    {
                        ///checks to see if it null 
                        if (String.IsNullOrWhiteSpace(textbox.Text))
                        {
                            ///if it is null the tells user to enter the name
                            textbox.Text = "Enter Name Here...";
                        }
                        else
                        {
                            ///if it is not null sets player name by pressing enter
                            player.Name = textbox.Text;
                      
                        }
                    }
                    else
                    {
                        ///checks to see if the textbox is null by pressing enter
                        if (String.IsNullOrWhiteSpace(textbox.Text))
                        {
                            ///if it is null tells user to enter correct age by pressing enter
                            textbox.Text = "Enter Age Here...";
                        }
                        else
                        {
                            ///create age for result out of the tryparse
                            int age = 0;
                            ///checks to see if input can be converted to int32 by pressing enter
                            if (Int32.TryParse(textbox.Text, out age))
                            {
                                ///if it can set player object age to out age
                                player.Age = age;
                         
                            }
                            else
                            {
                                ///if it cannot show message to enter number
                                MessageBox.Show("Enter Number");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// btn_save_click is to show the MainWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Creates a MainWindow Object 
                MainWindow mw = new MainWindow();
                /// sets the MainWindow player
                mw.Player = player;
                ///closes the userInformation dialog
                this.Close();
                ///shows the Main Window Dialog
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
