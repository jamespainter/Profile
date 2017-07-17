using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Added for MessageBox.Show(); 
using System.Windows.Forms;
///Added for Debugging
using System.Reflection; 
/// <summary>
/// FlightReservation is to select a seat on one of two planes 
/// </summary>
namespace FlightReservation
{
    /// <summary>
    /// Form one is the interface where you can select Flight and Passenger
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// List of flights to use for the list returned from the database
        /// </summary>
        List<Flight> flights;
        /// <summary>
        /// List of Passengers to use for the list returned from the database
        /// </summary>
        List<Passenger> passengers;
        /// <summary>
        /// FlightReservationDb Object to get objects from the database 
        /// </summary>
        FlightReservationDb flightResDb;
        /// <summary>
        /// string seatTag is used to know what has been selected for each flight. 
        /// </summary>
        string seatTag;
        /// <summary>
        /// Form1 constructor to initialize form, user control events, database object, set size for width and height, and initialize seat tag
        /// </summary>
        public Form1()
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Initialize form
                InitializeComponent();
                ///set form width
                this.Width = 850;
                ///set from height; 
                this.Height = 420;
                ///Bind Flight 1 object event to event in Form 1
                FlightOneLayout.SeatClickEvent += Flight1SeatSelectEvent_Click;
                ///Bind Flight 2 object event to event in Form 1
                FlightTwoLayout.SeatClickEvent += Flight1SeatSelectEvent_Click;
                ///Create database object
                flightResDb = new FlightReservationDb();
                ///Initializes the seat tag
                seatTag = "";
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }


            
        }
        /// <summary>
        /// Flight 1 event click so when a seat is select for a particular flight it will change color
        /// </summary>
        /// <param name="label"></param>
        private void Flight1SeatSelectEvent_Click(Object label)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Set new seatlabel to the label that was clicked
                Label seatLabel = (Label)label;
                ///Checks seat Label Tag and to see if seatTag has been set
                if (seatLabel.Tag.ToString() == seatTag || seatTag == "")
                {
                    ///setTag to new label tag
                    seatTag = seatLabel.Tag.ToString();
                    ///Check to see what color the label is already
                    if (seatLabel.BackColor == Color.Blue)
                    {
                        ///sets seatLabel BackColor to Green Yellow
                        seatLabel.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        ///Sets seatLabel Back Color to blue 
                        seatLabel.BackColor = Color.Blue;
                        ///Sets SeatTag to nothing
                        seatTag = ""; 
                    }
                }

            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }

        }
        /// <summary>
        /// On the form load we add all flights from the database in the flights combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Clears flight number label to null
                lbl_flight_number.Text = "";
                ///sets the flights to a list 
                flights = flightResDb.selectFlights();
               
                ///clears the flights combo box
                cb_flights.Items.Clear();
                ///sorts the flights list by by flight id
                flights.Sort(delegate(Flight x, Flight y)
                {
                    ///returns the flights by flight id 
                    return x.FlightID.CompareTo(y.FlightID);
                }); 
               ///iterates through the adding them to the flights combo box
                foreach (Flight fl in flights)
                {
                    ///Adds each flight to the flight combobox
                    cb_flights.Items.Add(fl.ToString());
                }

            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
           
        }
        
        /// <summary>
        /// By what flight is selected from the flights combo box will either hid or show the seating arrangement of the flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cb_flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Disable Change seat button 
                btn_change_seat.Enabled = false;
                ///Clear passenger seat text box
                tb_passenger_seat.Text = ""; 
                ///checks to see what index has been selected in the combo box flights
                if (cb_flights.SelectedIndex == 1)
                {
                    ///Sets usercontrol flightOneLayout1 to not be visible
                    flightOneLayout1.Visible = false;
                    ///Sets usercontrol flightTwoLayout1 to be visible
                    flightTwoLayout1.Visible = true;
                    ///Sets the flight number label to the flight number selected
                    lbl_flight_number.Text = flights[1].FlightNO.ToString();
                    ///calls the setPassengersComboBox to pull in all passengers for that flight
                    setPassengersComboBox();
                }
                else
                {
                    ///Sets usercontrol flightOneLayout1 to be visible
                    flightOneLayout1.Visible = true;
                    ///Sets usercontrol flightTwoLayout1 to not be visible
                    flightTwoLayout1.Visible = false;
                    ///Sets the flight number label to the flight number selected
                    lbl_flight_number.Text = flights[0].FlightNO.ToString();
                    ///calls the setPassengersComboBox to pull in all passengers for that flight
                    setPassengersComboBox();
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Sets the all passengers to the passenger combo box 
        /// </summary>
        private void setPassengersComboBox()
        {
            
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Clear Passenger Seat text box
                tb_passenger_seat.Text = ""; 
                ///Clear the passengers combo box 
                cb_passengers.Items.Clear();
                ///Clears the text our the passengers combo box
                cb_passengers.Text = "";
                ///Enables the passenger combo box
                cb_passengers.Enabled = true;
                ///Checks to see what flight was selected
                if (cb_flights.SelectedIndex == 0)
                {
                    ///sets the passengers list based on the index of the flight selected
                    passengers = flightResDb.SelectPassengers("743");
                }
                else if (cb_flights.SelectedIndex == 1)
                {
                    ///sets the passengers list based on the index of the flight selected
                    passengers = flightResDb.SelectPassengers("213");
                }
                else
                {
                    ///Message box asking to select flight
                    MessageBox.Show("Select Flight!");
                }
                ///Clears the items in the Passengers combo box
                cb_passengers.Items.Clear();
                ///Sorts the passenger list based on passengerID
                passengers.Sort(delegate (Passenger x, Passenger y)
                {
                    ///returns the first PassengerID
                    return x.PassengerID.CompareTo(y.PassengerID);
                });
                ///Iterates through the passengers adding them to the combo box
                foreach (Passenger pl in passengers)
                {
                    ///Adds Passengers to the Passengers combo box
                    cb_passengers.Items.Add(pl.ToString());
                }
                // btn_change_seat.Enabled = true; 
            }
            catch (Exception ex)
            {
                //throws exception to the higher level method
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }
        /// <summary>
        /// Base on the passenger select of a specific flight the seat number will be set in the text box passenger seat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_passengers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Loobs through items in the passengers combo box 
                for (int i = 0; i < cb_passengers.Items.Count; i++)
                {
                    ///checks to see what index is selected in the passengers combo box 
                    if(cb_passengers.SelectedIndex == i)
                    {
                        ///sets the text box passenger seat to the passenger selected
                        tb_passenger_seat.Text = passengers[i].SeatNO;
                    
                    }

                }
                ///enables add Passenger button 
                btn_add_passenger.Enabled = true;
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
        /// on a value change of the passenger seat with show the seat that is reserved 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_passenger_seat_ValueChange(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                //Enable Change Seat Button 
                btn_change_seat.Enabled = true;
                ///Sets the initializes new text box 
                TextBox tb = (TextBox)sender;
                ///Result of the text box from the passenger seat
                int result = 0;
                ///checks to see if the passenger seat text box is null 
                if(tb_passenger_seat != null)
                { 
                    ///checks to see if it can be converted into an int32 
                    if(Int32.TryParse(tb.Text, out result))
                    {
                        ///checks to see what flights combo box was selected and if the value is between 0 and 30
                        if(cb_flights.SelectedIndex == 0 && result >= 0 && result <= 30)
                        {
                            ///iterates the label controls of FlightOneLayout and puts it in a list 
                            foreach (Label lb in Controls.OfType<FlightOneLayout>().SelectMany(groupBox => groupBox.Controls.OfType<Label>()).ToList())
                            {
                               ///if one of the tags equals the result it changes the seat label to reserved
                                if (lb.Tag.Equals(result.ToString()))
                                {
                                    ///sets seatTag to maintain only one being selected
                                    seatTag = lb.Tag.ToString();
                                    ///Sets color to the seat label select 
                                    lb.BackColor = Color.Red; 
                                }
                                else
                                {
                                    ///Sets the rest of the labels to blue
                                    lb.BackColor = Color.Blue;
                                }
                            }
                        }
                        else if (cb_flights.SelectedIndex == 1 && result >= 0 && result <= 24)
                        {

                            ///iterates the label controls of FlightTwoLayout and puts it in a list 
                            foreach (Label lb in Controls.OfType<FlightTwoLayout>().SelectMany(groupBox => groupBox.Controls.OfType<Label>()).ToList())
                            {
                                ///if one of the tags equals the result it changes the seat label to reserved
                                if (lb.Tag.Equals(result.ToString()))
                                {
                                    //sets seatTag to maintain only one being selected
                                    seatTag = lb.Tag.ToString();
                                    ///Sets color to the seat label select 
                                    lb.BackColor = Color.Red;
                                }
                                else
                                {
                                    ///Sets the rest of the labels to blue
                                    lb.BackColor = Color.Blue;
                                }
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
        /// Button event for the change seat. This gives the user the ability to edit the passenger seat textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_change_seat_Click(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                
                ///sets the passenger text so it can be edited
               // tb_passenger_seat.Enabled = true;
                ///checks to see what index is selected for the flight
                if (cb_flights.SelectedIndex == 0)
                {
                    ///sets the flight one layout to be enabled
                    flightOneLayout1.Enabled = true;
                    ///set the flight two layout to be disabled
                    flightTwoLayout1.Enabled = false; 
                }
                else
                {
                    ///set the flight One layout to be disabled
                    flightOneLayout1.Enabled = false;
                    ///sets the flight two layout to be enabled
                    flightTwoLayout1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        private void btn_add_passenger_Click(object sender, EventArgs e)
        {
            ///Try executing if problem call HandleError to display the error Message; 
            try
            {
                ///Creates a new AddPassenger form object
                AddPassenger ap = new AddPassenger();
                ///Shows the AddPassenger dialog;
                ap.ShowDialog();
                ///Close this sreen
                //this.Close();
                

            }
            catch (Exception ex)
            {
                /// Call handleError Method to display the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
}
    }
}
