using System;
using System.Collections.Generic;
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
    /// Passenger object is used to set and get values of each passenger in the database
    /// </summary>
    public class Passenger
    {
        /// <summary>
        /// Passenger id from Table Passenger
        /// </summary>
        public String PassengerID { get; set; }
        /// <summary>
        /// Passenger First Name from Table Passenger
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Passenger Last Name from Table Passenger
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Passenger Seat Number from Table Passenger
        /// </summary>
        public string SeatNO { get; set; }
        /// <summary>
        /// Passenger Flight Number from Table Passenger
        /// </summary>
        public string FlightNO { get; set;}


       /// <summary>
       /// Passenger Constructor to set Passenger Object
       /// </summary>
        public Passenger()
        {
            ///Initialize the first name of the passenger
            FirstName = "";
            ///Initializes the Last name of the passeger
            LastName = "";
            ///Initializes the seatNo of the passenger
            SeatNO = "";
            ///initializes the flightno of the passenger
            FlightNO = ""; 
        }
        /// <summary>
        /// intializes Passenger object
        /// </summary>
        /// <param name="passengerID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="flightNO"></param>
        /// <param name="seatNO"></param>
        public Passenger(string passengerID, string firstName, string lastName, string flightNO, string seatNO)
        {
            ///Initialize the PassengerID
            PassengerID = passengerID;
            ///Initialize the First name of Passenger
            FirstName = firstName;
            ///Initializes the Last name of the Passenger
            LastName = lastName;
            ///initializes the SeatNO of the passenger
            SeatNO = seatNO;
            ///initializes the Flightno of the passenger
            FlightNO = flightNO; 
        }
        /// <summary>
        /// override the tostring method to print in the text box
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            ///Returns how the passenger should be returned
            return PassengerID + " " + FirstName + " " + LastName; 
        }


    }
}
