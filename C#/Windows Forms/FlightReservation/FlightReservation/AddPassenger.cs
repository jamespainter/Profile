using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///Added for Debugging
using System.Reflection;
/// <summary>
/// FlightReservation is to select a seat on one of two planes 
/// </summary>
namespace FlightReservation
{

    /// <summary>
    /// Add New Passenger to the database
    /// </summary>
    public partial class AddPassenger : Form
    {
        ///Declare new instance of form1
        Form1 f1;
        /// <summary>
        /// List of flights to use for the list returned from the database
        /// </summary>
        List<Flight> flights;
        /// <summary>
        /// Database object Declared
        /// </summary>
        FlightReservationDb flightResDb;
        /// <summary>
        /// constructor to initialize the add passenger form
        /// </summary>
        public AddPassenger()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                
                ///initializes the add passenger form
                InitializeComponent();
                ///Initialize new instance of form1
               f1 = new Form1();
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
                MessageBox.Show(sClass + "." + sMethod + "->" + sMessage);


            }
            catch (Exception ex)
            {
                ///If there is an error it will write the error to a Error.txt file on the c:\drive
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }


        }
        /// <summary>
        /// Save values to add new passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initialize database object 
                flightResDb = new FlightReservationDb();
                ///check to see if any text box is empty
                if (tb_first_name.Text != "" && tb_last_name.Text != "" && cb_flight_number.Text !="" && tb_seat_number.Text != "")
                {
                    ///flight number result
                    int flightNO = 0;
                    ///seat number result
                    int seatNo = 0; 
                    if(Int32.TryParse(cb_flight_number.Text, out flightNO ) && Int32.TryParse(tb_seat_number.Text, out seatNo))
                    {
                        
                        ///Add User to database
                        flightResDb.AddPassenger(tb_first_name.Text, tb_last_name.Text, flightNO, seatNo);
                        
                        ///close add user dialog
                        this.Close();
                        
                        
                    }
                    else
                    {
                        ///Message box to remind user to put in an integer
                        MessageBox.Show("Enter Numbers for flight number and seat number.");
                    }
                }
                else
                {
                    ///Message box to fill in all information 
                    MessageBox.Show("Enter all infromation in form!");
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Open form1 and close the the add user dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {

            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Close add user dialog 
                this.Close();
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// On load event to load the flight numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPassenger_Load(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initialize database object 
                flightResDb = new FlightReservationDb();
               
                ///sets the flights to a list 
                flights = flightResDb.selectFlights();
               
                ///clears the flights combo box
                cb_flight_number.Items.Clear();
                ///sorts the flights list by by flight id
                flights.Sort(delegate (Flight x, Flight y)
                {
                    ///returns the flights by flight id 
                    return x.FlightID.CompareTo(y.FlightID);
                });
                ///iterates through the adding them to the flights combo box
                foreach (Flight fl in flights)
                {
                    ///Adds each flight to the flight combobox
                    cb_flight_number.Items.Add(fl.FlightNO);
                }

            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
