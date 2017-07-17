using System;
using System.Collections.Generic;
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
    /// Flight class is to create an object used to values from the database into 
    /// </summary>
    public class Flight
    {
        public static List<string> still = new List<string>();
        /// <summary>
        /// Flight id from database
        /// </summary>
        public string FlightID { get; set; }
        /// <summary>
        /// FlightNO from database
        /// </summary>
        public string FlightNO { get; set; }
        /// <summary>
        /// FlightName from database
        /// </summary>
        public string FlightName { get; set; }
        /// <summary>
        /// Flight Number of Seats from database
        /// </summary>
        public string NumOfSeats { get; set; }
        /// <summary>
        /// Flight Available Seats on flight from database
        /// </summary>
        public string AvailableSeats { get; set; }
        /// <summary>
        /// Flight Reserved Seats From Database
        /// </summary>
        public string ReservedSeats { get; set; }
        /// <summary>
        /// Create New Flight Object to use when data has been retrieved from database
        /// </summary>
        public Flight()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initializes the flight number
                FlightNO = "";
                ///Initializes the flight name
                FlightName = "";
                ///Initializes the Number of Seats
                NumOfSeats = "";
                ///Initializes the available Seats on the flight
                AvailableSeats = "";
                ///Initiallizes the reserved flights on the flight
                ReservedSeats = "";
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Initializes a flight object when a query has been rendered from the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="flightNO"></param>
        /// <param name="flightName"></param>
        /// <param name="numOfSeats"></param>
        /// <param name="availableSeats"></param>
        /// <param name="reservedSeats"></param>
        public Flight(string id, string flightNO, string flightName, string numOfSeats, string availableSeats, string reservedSeats)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initializes the flight number
                FlightID = id;
                ///Initializes the flight name
                FlightNO = flightNO;
                ///Initializes the Number of Seats
                FlightName = flightName;
                ///Initializes the available Seats on the flight
                NumOfSeats = numOfSeats;
                ///Initializes the available Seats on the flight
                AvailableSeats = availableSeats;
                ///Initiallizes the reserved flights on the flight
                ReservedSeats = reservedSeats;
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Overide the tostring method to return a object as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            ///returns the object flight no and flight name
            return FlightNO + " " + FlightName;
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
