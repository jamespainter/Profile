using System;
using System.Windows;
/// <summary>
/// The TicTacToe NameSpace has methods and classes to play a tic tac toe game
/// </summary>
namespace TicTacToe
{
    /// <summary>
    /// Partial Class Window is used to put input dialog to get how many users from user input
    /// </summary>
    public partial class Window1 : Window
    {
        /// <summary>
        /// Window 1 constructor takes to arguments that will give a question and pre-populate the default answer. 
        /// </summary>
        /// <param name="question"></param>
        /// <param name="defaultAnswer"></param>
        public Window1(string question, string defaultAnswer = "")
        {
            ///Initialize Component
            InitializeComponent();
            ///Set the label in the content to What question has been given in the MainWindow.xaml.cs
            lblQuestion.Content = question;
            // txtAnswer.Text = defaultAnswer;
            //txtAnswer.Text = rbtn_two.Content.ToString(); 
            
        }
        /// <summary>
        /// btnDialogOk_Clic returns that value only if the ok button is selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            ///set the dialog result to true to send value
            this.DialogResult = true;
        }
        /// <summary>
        /// Window_Content rendered was never used 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_ContentRendered(object sender, EventArgs e)
        {
           // txtAnswer.SelectAll();
           // txtAnswer.Focus();
        }

        /// <summary>
        /// Get my value from Radio button to give me how many users 
        /// </summary>
        public int Answer
        {
            //get { return txtAnswer.Text; }
            get
            {
                ///Returns the value of radio button depending on what one is selected
                if (rbtn_one.IsChecked.Value)
                    return 1;
                else
                    return 2; 

            }
        }
    }
}