namespace FlightReservation
{
    partial class AddPassenger
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
            this.lbl_add_Passenger = new System.Windows.Forms.Label();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.tb_seat_number = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_seat_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_flight_number = new System.Windows.Forms.ComboBox();
            this.lbl_flight_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_add_Passenger
            // 
            this.lbl_add_Passenger.AutoSize = true;
            this.lbl_add_Passenger.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_Passenger.Location = new System.Drawing.Point(124, 58);
            this.lbl_add_Passenger.Name = "lbl_add_Passenger";
            this.lbl_add_Passenger.Size = new System.Drawing.Size(506, 83);
            this.lbl_add_Passenger.TabIndex = 0;
            this.lbl_add_Passenger.Text = "Add Passenger";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.Location = new System.Drawing.Point(111, 219);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(263, 50);
            this.lbl_first_name.TabIndex = 1;
            this.lbl_first_name.Text = "First Name :";
            // 
            // tb_first_name
            // 
            this.tb_first_name.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_first_name.Location = new System.Drawing.Point(428, 219);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(262, 58);
            this.tb_first_name.TabIndex = 2;
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.Location = new System.Drawing.Point(119, 328);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(254, 50);
            this.lbl_last_name.TabIndex = 3;
            this.lbl_last_name.Text = "Last Name :";
            // 
            // tb_last_name
            // 
            this.tb_last_name.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_last_name.Location = new System.Drawing.Point(428, 318);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(262, 58);
            this.tb_last_name.TabIndex = 4;
            // 
            // tb_seat_number
            // 
            this.tb_seat_number.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_seat_number.Location = new System.Drawing.Point(428, 516);
            this.tb_seat_number.Name = "tb_seat_number";
            this.tb_seat_number.Size = new System.Drawing.Size(262, 58);
            this.tb_seat_number.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(28, 646);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(273, 83);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(482, 646);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(273, 83);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_seat_number
            // 
            this.lbl_seat_number.AutoSize = true;
            this.lbl_seat_number.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seat_number.Location = new System.Drawing.Point(81, 524);
            this.lbl_seat_number.Name = "lbl_seat_number";
            this.lbl_seat_number.Size = new System.Drawing.Size(293, 50);
            this.lbl_seat_number.TabIndex = 9;
            this.lbl_seat_number.Text = "Seat Number :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 10);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // cb_flight_number
            // 
            this.cb_flight_number.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_flight_number.FormattingEnabled = true;
            this.cb_flight_number.Location = new System.Drawing.Point(428, 418);
            this.cb_flight_number.Name = "cb_flight_number";
            this.cb_flight_number.Size = new System.Drawing.Size(262, 56);
            this.cb_flight_number.TabIndex = 12;
            // 
            // lbl_flight_number
            // 
            this.lbl_flight_number.AutoSize = true;
            this.lbl_flight_number.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flight_number.Location = new System.Drawing.Point(39, 421);
            this.lbl_flight_number.Name = "lbl_flight_number";
            this.lbl_flight_number.Size = new System.Drawing.Size(335, 50);
            this.lbl_flight_number.TabIndex = 13;
            this.lbl_flight_number.Text = "Flight Number :";
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 771);
            this.Controls.Add(this.lbl_flight_number);
            this.Controls.Add(this.cb_flight_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_seat_number);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_seat_number);
            this.Controls.Add(this.tb_last_name);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.tb_first_name);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.lbl_add_Passenger);
            this.Name = "AddPassenger";
            this.Text = "AddPassenger";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_add_Passenger;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label lbl_last_name;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.TextBox tb_seat_number;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_seat_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_flight_number;
        private System.Windows.Forms.Label lbl_flight_number;
    }
}