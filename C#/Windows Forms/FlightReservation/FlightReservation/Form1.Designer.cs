namespace FlightReservation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_flights = new System.Windows.Forms.ComboBox();
            this.lbl_flight_number = new System.Windows.Forms.Label();
            this.lbl_ChooseFlight = new System.Windows.Forms.Label();
            this.lbl_choose_passenger = new System.Windows.Forms.Label();
            this.cb_passengers = new System.Windows.Forms.ComboBox();
            this.lbl_passenger_seat = new System.Windows.Forms.Label();
            this.tb_passenger_seat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_selected_passenger_Seat = new System.Windows.Forms.Label();
            this.lbl_seat_is_empty = new System.Windows.Forms.Label();
            this.lbl_seat_taken = new System.Windows.Forms.Label();
            this.lbl_key_green = new System.Windows.Forms.Label();
            this.lbl_key_blue = new System.Windows.Forms.Label();
            this.lbl_key_red = new System.Windows.Forms.Label();
            this.btn_add_passenger = new System.Windows.Forms.Button();
            this.btn_delete_passenger = new System.Windows.Forms.Button();
            this.btn_change_seat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flightOneLayout1 = new FlightReservation.FlightOneLayout();
            this.flightTwoLayout1 = new FlightReservation.FlightTwoLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_flights
            // 
            this.cb_flights.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_flights.FormattingEnabled = true;
            this.cb_flights.Location = new System.Drawing.Point(1487, 64);
            this.cb_flights.Name = "cb_flights";
            this.cb_flights.Size = new System.Drawing.Size(450, 56);
            this.cb_flights.TabIndex = 3;
            this.cb_flights.SelectedIndexChanged += new System.EventHandler(this.cb_flights_SelectedIndexChanged);
            // 
            // lbl_flight_number
            // 
            this.lbl_flight_number.Font = new System.Drawing.Font("Modern No. 20", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flight_number.Location = new System.Drawing.Point(359, 331);
            this.lbl_flight_number.Name = "lbl_flight_number";
            this.lbl_flight_number.Size = new System.Drawing.Size(234, 97);
            this.lbl_flight_number.TabIndex = 4;
            this.lbl_flight_number.Text = "label1";
            this.lbl_flight_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ChooseFlight
            // 
            this.lbl_ChooseFlight.AutoSize = true;
            this.lbl_ChooseFlight.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChooseFlight.Location = new System.Drawing.Point(1127, 72);
            this.lbl_ChooseFlight.Name = "lbl_ChooseFlight";
            this.lbl_ChooseFlight.Size = new System.Drawing.Size(313, 50);
            this.lbl_ChooseFlight.TabIndex = 5;
            this.lbl_ChooseFlight.Text = "Choose Flight :";
            // 
            // lbl_choose_passenger
            // 
            this.lbl_choose_passenger.AutoSize = true;
            this.lbl_choose_passenger.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose_passenger.Location = new System.Drawing.Point(1068, 171);
            this.lbl_choose_passenger.Name = "lbl_choose_passenger";
            this.lbl_choose_passenger.Size = new System.Drawing.Size(381, 50);
            this.lbl_choose_passenger.TabIndex = 6;
            this.lbl_choose_passenger.Text = "Choose Passenger :";
            // 
            // cb_passengers
            // 
            this.cb_passengers.Enabled = false;
            this.cb_passengers.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_passengers.FormattingEnabled = true;
            this.cb_passengers.Location = new System.Drawing.Point(1487, 168);
            this.cb_passengers.Name = "cb_passengers";
            this.cb_passengers.Size = new System.Drawing.Size(450, 56);
            this.cb_passengers.TabIndex = 7;
            this.cb_passengers.SelectedIndexChanged += new System.EventHandler(this.cb_passengers_SelectedIndexChanged);
            // 
            // lbl_passenger_seat
            // 
            this.lbl_passenger_seat.AutoSize = true;
            this.lbl_passenger_seat.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passenger_seat.Location = new System.Drawing.Point(1120, 273);
            this.lbl_passenger_seat.Name = "lbl_passenger_seat";
            this.lbl_passenger_seat.Size = new System.Drawing.Size(329, 50);
            this.lbl_passenger_seat.TabIndex = 8;
            this.lbl_passenger_seat.Text = "Passenger Seat :";
            // 
            // tb_passenger_seat
            // 
            this.tb_passenger_seat.Enabled = false;
            this.tb_passenger_seat.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passenger_seat.Location = new System.Drawing.Point(1487, 273);
            this.tb_passenger_seat.Name = "tb_passenger_seat";
            this.tb_passenger_seat.Size = new System.Drawing.Size(451, 58);
            this.tb_passenger_seat.TabIndex = 9;
            this.tb_passenger_seat.TextChanged += new System.EventHandler(this.tb_passenger_seat_ValueChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_selected_passenger_Seat);
            this.groupBox1.Controls.Add(this.lbl_seat_is_empty);
            this.groupBox1.Controls.Add(this.lbl_seat_taken);
            this.groupBox1.Controls.Add(this.lbl_key_green);
            this.groupBox1.Controls.Add(this.lbl_key_blue);
            this.groupBox1.Controls.Add(this.lbl_key_red);
            this.groupBox1.Location = new System.Drawing.Point(1009, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 340);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Key";
            // 
            // lbl_selected_passenger_Seat
            // 
            this.lbl_selected_passenger_Seat.AutoSize = true;
            this.lbl_selected_passenger_Seat.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selected_passenger_Seat.Location = new System.Drawing.Point(362, 256);
            this.lbl_selected_passenger_Seat.Name = "lbl_selected_passenger_Seat";
            this.lbl_selected_passenger_Seat.Size = new System.Drawing.Size(473, 50);
            this.lbl_selected_passenger_Seat.TabIndex = 5;
            this.lbl_selected_passenger_Seat.Text = "Selected Passenger Seat";
            // 
            // lbl_seat_is_empty
            // 
            this.lbl_seat_is_empty.AutoSize = true;
            this.lbl_seat_is_empty.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seat_is_empty.Location = new System.Drawing.Point(362, 170);
            this.lbl_seat_is_empty.Name = "lbl_seat_is_empty";
            this.lbl_seat_is_empty.Size = new System.Drawing.Size(293, 50);
            this.lbl_seat_is_empty.TabIndex = 4;
            this.lbl_seat_is_empty.Text = "Seat Is Empty";
            // 
            // lbl_seat_taken
            // 
            this.lbl_seat_taken.AutoSize = true;
            this.lbl_seat_taken.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seat_taken.Location = new System.Drawing.Point(362, 78);
            this.lbl_seat_taken.Name = "lbl_seat_taken";
            this.lbl_seat_taken.Size = new System.Drawing.Size(285, 50);
            this.lbl_seat_taken.TabIndex = 3;
            this.lbl_seat_taken.Text = "Seat Is Taken";
            // 
            // lbl_key_green
            // 
            this.lbl_key_green.BackColor = System.Drawing.Color.Lime;
            this.lbl_key_green.Location = new System.Drawing.Point(182, 250);
            this.lbl_key_green.Name = "lbl_key_green";
            this.lbl_key_green.Size = new System.Drawing.Size(65, 54);
            this.lbl_key_green.TabIndex = 2;
            // 
            // lbl_key_blue
            // 
            this.lbl_key_blue.BackColor = System.Drawing.Color.Blue;
            this.lbl_key_blue.Location = new System.Drawing.Point(182, 164);
            this.lbl_key_blue.Name = "lbl_key_blue";
            this.lbl_key_blue.Size = new System.Drawing.Size(65, 54);
            this.lbl_key_blue.TabIndex = 1;
            // 
            // lbl_key_red
            // 
            this.lbl_key_red.BackColor = System.Drawing.Color.Red;
            this.lbl_key_red.Location = new System.Drawing.Point(182, 74);
            this.lbl_key_red.Name = "lbl_key_red";
            this.lbl_key_red.Size = new System.Drawing.Size(65, 54);
            this.lbl_key_red.TabIndex = 0;
            // 
            // btn_add_passenger
            // 
            this.btn_add_passenger.Enabled = false;
            this.btn_add_passenger.Location = new System.Drawing.Point(1306, 448);
            this.btn_add_passenger.Name = "btn_add_passenger";
            this.btn_add_passenger.Size = new System.Drawing.Size(283, 73);
            this.btn_add_passenger.TabIndex = 11;
            this.btn_add_passenger.Text = "Add Passenger";
            this.btn_add_passenger.UseVisualStyleBackColor = true;
            this.btn_add_passenger.Click += new System.EventHandler(this.btn_add_passenger_Click);
            // 
            // btn_delete_passenger
            // 
            this.btn_delete_passenger.Enabled = false;
            this.btn_delete_passenger.Location = new System.Drawing.Point(1655, 448);
            this.btn_delete_passenger.Name = "btn_delete_passenger";
            this.btn_delete_passenger.Size = new System.Drawing.Size(283, 73);
            this.btn_delete_passenger.TabIndex = 12;
            this.btn_delete_passenger.Text = "Delete Passenger";
            this.btn_delete_passenger.UseVisualStyleBackColor = true;
            // 
            // btn_change_seat
            // 
            this.btn_change_seat.Enabled = false;
            this.btn_change_seat.Location = new System.Drawing.Point(1655, 353);
            this.btn_change_seat.Name = "btn_change_seat";
            this.btn_change_seat.Size = new System.Drawing.Size(283, 73);
            this.btn_change_seat.TabIndex = 13;
            this.btn_change_seat.Text = "Change Seat";
            this.btn_change_seat.UseVisualStyleBackColor = true;
            this.btn_change_seat.Click += new System.EventHandler(this.btn_change_seat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 95);
            this.label1.TabIndex = 14;
            this.label1.Text = "Flight Reservation";
            // 
            // flightOneLayout1
            // 
            this.flightOneLayout1.Enabled = false;
            this.flightOneLayout1.Location = new System.Drawing.Point(36, 496);
            this.flightOneLayout1.Name = "flightOneLayout1";
            this.flightOneLayout1.Size = new System.Drawing.Size(883, 262);
            this.flightOneLayout1.TabIndex = 2;
            this.flightOneLayout1.Visible = false;
            // 
            // flightTwoLayout1
            // 
            this.flightTwoLayout1.Enabled = false;
            this.flightTwoLayout1.Location = new System.Drawing.Point(290, 431);
            this.flightTwoLayout1.Name = "flightTwoLayout1";
            this.flightTwoLayout1.Size = new System.Drawing.Size(368, 413);
            this.flightTwoLayout1.TabIndex = 1;
            this.flightTwoLayout1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1966, 855);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_change_seat);
            this.Controls.Add(this.btn_delete_passenger);
            this.Controls.Add(this.btn_add_passenger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_passenger_seat);
            this.Controls.Add(this.lbl_passenger_seat);
            this.Controls.Add(this.cb_passengers);
            this.Controls.Add(this.lbl_choose_passenger);
            this.Controls.Add(this.lbl_ChooseFlight);
            this.Controls.Add(this.lbl_flight_number);
            this.Controls.Add(this.cb_flights);
            this.Controls.Add(this.flightOneLayout1);
            this.Controls.Add(this.flightTwoLayout1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlightTwoLayout flightTwoLayout1;
        private FlightOneLayout flightOneLayout1;
        private System.Windows.Forms.ComboBox cb_flights;
        private System.Windows.Forms.Label lbl_flight_number;
        private System.Windows.Forms.Label lbl_ChooseFlight;
        private System.Windows.Forms.Label lbl_choose_passenger;
        private System.Windows.Forms.ComboBox cb_passengers;
        private System.Windows.Forms.Label lbl_passenger_seat;
        private System.Windows.Forms.TextBox tb_passenger_seat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_selected_passenger_Seat;
        private System.Windows.Forms.Label lbl_seat_is_empty;
        private System.Windows.Forms.Label lbl_seat_taken;
        private System.Windows.Forms.Label lbl_key_green;
        private System.Windows.Forms.Label lbl_key_blue;
        private System.Windows.Forms.Label lbl_key_red;
        private System.Windows.Forms.Button btn_add_passenger;
        private System.Windows.Forms.Button btn_delete_passenger;
        private System.Windows.Forms.Button btn_change_seat;
        private System.Windows.Forms.Label label1;
    }
}

