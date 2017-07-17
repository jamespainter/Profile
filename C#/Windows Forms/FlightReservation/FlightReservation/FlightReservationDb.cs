using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
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
    /// Is to get and set flight and passenger objects 
    /// </summary>
    public class FlightReservationDb
    {
        /// <summary>
        /// Declare a db object
        /// </summary>
        OleDbConnection OleDB;
        /// <summary>
        /// Declare a list string of results
        /// </summary>
        List<String> results;
        /// <summary>
        /// Flight reservation initialize the conection to the databaase
        /// </summary>
        public FlightReservationDb()
        {
            ///Connection string to the database
            String conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=FlightReservation.accdb";
            ///initialize the results string list
            results = new List<String>();
            try
            {
                ///Open New Instance of the oleDB with the parameter of the connection string conn
                OleDB = new OleDbConnection(conn);
                ///Opens database Connection 
                OleDB.Open();
 
            }
            catch (OleDbException ex)
            {
              
                ///throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

        /// <summary>
        /// Gets all flights in the database 
        /// </summary>
        /// <returns></returns>
        public List<Flight> selectFlights()
        {
            
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Clear the list of results
                results.Clear();
                ///Creates a new list of Flight to return 
                List<Flight> flights = new List<Flight>();
                ///Query to database
                string query = "SELECT * FROM Flight";
                ///New Instance of OleDBCommand Command to database using query and connection 
                OleDbCommand accessCommand = new OleDbCommand(query, OleDB);
                ///New Instance of OleDBAdator to store results from accessDBCommand 
                OleDbDataAdapter accessAdaptor = new OleDbDataAdapter(accessCommand);
                ///DataTable to store Adaptor values 
                DataTable dt = new DataTable();
                ///Fill datatable with adaptor values 
                accessAdaptor.Fill(dt);
                ///Iterate through data table to find specific values 
                foreach (DataRow row in dt.Rows)
                {
                    ///iterate through each column
                    foreach (DataColumn column in dt.Columns)
                    {
                        ///add values to String ArrayList 
                        results.Add(row[column].ToString());
                       
                    }
                }
                ///Iterate through the list of results and create new object
                for (int i = 0; i < results.Count; i++)
                {
                    ///gets me each row 
                    if(i % 6 == 0)
                    {
                       ///Create the flights list and flight object
                        flights.Add(new Flight(results[i], results[i + 1], results[i + 2], results[i + 3], results[i + 4], results[i + 5]));
                       
                    }
                  
                    

                }
                ///Close the database connection
                OleDB.Close();
                ///return list
                return flights;
            }
            catch (OleDbException ex)
            {

                ///throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
            
        }

        /// <summary>
        /// Select all passengers from the database 
        /// </summary>
        /// <param name="FlightNO"></param>
        /// <returns></returns>
        public List<Passenger> SelectPassengers(string FlightNO)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Clear the list of results
                results.Clear();
                List<Passenger> passengers = new List<Passenger>();
                ///Query to database
                string query = "SELECT * FROM Passenger WHERE FlightNO =" + FlightNO;
                ///New Instance of OleDBCommand Command to database using query and connection 
                OleDbCommand accessCommand = new OleDbCommand(query, OleDB);
                ///New Instance of OleDBAdator to store results from accessDBCommand 
                OleDbDataAdapter accessAdaptor = new OleDbDataAdapter(accessCommand);
                ///DataTable to store Adaptor values 
                DataTable dt = new DataTable();
                ///Fill datatable with adaptor values 
                accessAdaptor.Fill(dt);
                ///Iterate through data table to find specific values 
                foreach (DataRow row in dt.Rows)
                {
                    //Iterate through the columns that were returned
                    foreach (DataColumn column in dt.Columns)
                    {
                        ///add values to String ArrayList 
                        results.Add(row[column].ToString());

                    }
                }
                ///Iterate through the list of results and create new object
                for (int i = 0; i < results.Count; i++)
                {
                    ///give me each row of values 
                    if (i % 5 == 0)
                    {
                        // MessageBox.Show("Inside and i = "+i.ToString());
                        passengers.Add(new Passenger(results[i], results[i + 1], results[i + 2], results[i + 3], results[i + 4]));

                    }

                }
                ///Close database connection
                OleDB.Close();
                ///return list of passengers
                return passengers;
            }
            catch (OleDbException ex)
            {

                ///throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }

        }
        /// <summary>
        /// Add Passenger insterts a passenger on the flight
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="FlightNO"></param>
        /// <param name="SeatNO"></param>
        public void AddPassenger(string FirstName, string LastName, int FlightNO, int SeatNO)
        {
            try
            {
                results.Clear();
                List<Passenger> passengers = new List<Passenger>();
                ///Query to database
                string query = "INSERT INTO Passenger(FirstName, LastName, FlightNO, SeatNO) Values('"+ FirstName+"',"+"'"+LastName+"',"+FlightNO+","+SeatNO+")" ;
                ///New Instance of OleDBCommand Command to database using query and connection 
                OleDbCommand accessCommand = new OleDbCommand(query, OleDB);
                ///Execute query and return the rows affected 
                int rows = accessCommand.ExecuteNonQuery();
                ///Show rows affected
                //MessageBox.Show(rows.ToString());
               
            }
            catch (OleDbException ex)
            {

                ///throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
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
    }
}
