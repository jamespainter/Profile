using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Used for the messagebox
using System.Windows.Forms;
///Added for Debugging
using System.Reflection;
/// <summary>
/// FlightReservation is to select a seat on one of two planes 
/// </summary>
namespace FlightReservation
{
    /// <summary>
    /// FlightOneLayout is used as a user control it also inherits off of base class UserControl
    /// </summary>
    public partial class FlightOneLayout : UserControl
    {
        /// <summary>
        /// Create a delegate for your event. 
        /// This just sets up the format that we expect out event handler on the 
        /// main form to have. So the method that handles our event has to except
        /// a string as a parameter. You can pass whatever you want .
        /// </summary>
        /// <param name = "SeatNumber"></param>
        public delegate void SeatClickDelegate(Object seat);

        ///Delegate for the button click 
        ///
        public delegate void ButtonClickDelegate(string Message);

        ///Create the event that is raised when a set is clicked 
        ///
        public static event SeatClickDelegate SeatClickEvent;

        /////Create the event for the Button click 
        ///
        private void lbl_seat_Click(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                Label MyLabel = (Label)sender;

                ///This is what raises the event, just like as if a button had been
                ///clicked. In our case we are telling our problem that a label has 
                ///been clicked,, and who ever is supposed to handle this event should 
                ///handle it, and by the way here is the seat number. 
                ///
                if (SeatClickEvent != null)
                {
                    ///Passes the seat label control
                    SeatClickEvent(MyLabel);

                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Constructor to initialise the flightOneLayout User Control
        /// </summary>
        public FlightOneLayout()
        {
            ///Initializes Form
            InitializeComponent();
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
                MessageBox.Show(sClass + "." + sMethod + "->" + sMessage);


            }
            catch (Exception ex)
            {
                ///If there is an error it will write the error to a Error.txt file on the c:\drive
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }


        }
    }
}
