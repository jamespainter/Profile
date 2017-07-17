namespace Assignment2_1
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Roll = new System.Windows.Forms.Button();
            this.lbl_Enter_Guess = new System.Windows.Forms.Label();
            this.tb_guess = new System.Windows.Forms.TextBox();
            this.pb_Dice = new System.Windows.Forms.PictureBox();
            this.gb_Game_Info = new System.Windows.Forms.GroupBox();
            this.lbl_NTL_Value = new System.Windows.Forms.Label();
            this.lbl_NTW_Value = new System.Windows.Forms.Label();
            this.lbl_NTP_Value = new System.Windows.Forms.Label();
            this.lbl_Number_Times_Lost = new System.Windows.Forms.Label();
            this.lbl_Number_Times_Won = new System.Windows.Forms.Label();
            this.lbl_Number_Times_Played = new System.Windows.Forms.Label();
            this.rtb_Frequency = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Percent = new System.Windows.Forms.RichTextBox();
            this.rtb_Face = new System.Windows.Forms.RichTextBox();
            this.rtb_NumTimesGuess = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice)).BeginInit();
            this.gb_Game_Info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(510, 482);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(208, 52);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Roll
            // 
            this.btn_Roll.Location = new System.Drawing.Point(512, 394);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(207, 46);
            this.btn_Roll.TabIndex = 10;
            this.btn_Roll.Text = "Roll";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // lbl_Enter_Guess
            // 
            this.lbl_Enter_Guess.AutoSize = true;
            this.lbl_Enter_Guess.Location = new System.Drawing.Point(241, 304);
            this.lbl_Enter_Guess.Name = "lbl_Enter_Guess";
            this.lbl_Enter_Guess.Size = new System.Drawing.Size(258, 29);
            this.lbl_Enter_Guess.TabIndex = 9;
            this.lbl_Enter_Guess.Text = "Enter Your Guess (1-6)";
            // 
            // tb_guess
            // 
            this.tb_guess.Location = new System.Drawing.Point(512, 298);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(213, 35);
            this.tb_guess.TabIndex = 8;
            this.tb_guess.TextChanged += new System.EventHandler(this.tb_guess_TextChanged);
            this.tb_guess.MouseEnter += new System.EventHandler(this.tb_guess_MouseEnter);
            // 
            // pb_Dice
            // 
            this.pb_Dice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Dice.Image = global::Assignment2_1.Properties.Resources.die6;
            this.pb_Dice.Location = new System.Drawing.Point(267, 354);
            this.pb_Dice.Name = "pb_Dice";
            this.pb_Dice.Padding = new System.Windows.Forms.Padding(30);
            this.pb_Dice.Size = new System.Drawing.Size(206, 180);
            this.pb_Dice.TabIndex = 7;
            this.pb_Dice.TabStop = false;
            // 
            // gb_Game_Info
            // 
            this.gb_Game_Info.Controls.Add(this.lbl_NTL_Value);
            this.gb_Game_Info.Controls.Add(this.lbl_NTW_Value);
            this.gb_Game_Info.Controls.Add(this.lbl_NTP_Value);
            this.gb_Game_Info.Controls.Add(this.lbl_Number_Times_Lost);
            this.gb_Game_Info.Controls.Add(this.lbl_Number_Times_Won);
            this.gb_Game_Info.Controls.Add(this.lbl_Number_Times_Played);
            this.gb_Game_Info.Location = new System.Drawing.Point(231, 8);
            this.gb_Game_Info.Name = "gb_Game_Info";
            this.gb_Game_Info.Size = new System.Drawing.Size(526, 255);
            this.gb_Game_Info.TabIndex = 12;
            this.gb_Game_Info.TabStop = false;
            this.gb_Game_Info.Text = "Game Info";
            // 
            // lbl_NTL_Value
            // 
            this.lbl_NTL_Value.AutoSize = true;
            this.lbl_NTL_Value.Location = new System.Drawing.Point(453, 201);
            this.lbl_NTL_Value.Name = "lbl_NTL_Value";
            this.lbl_NTL_Value.Size = new System.Drawing.Size(26, 29);
            this.lbl_NTL_Value.TabIndex = 5;
            this.lbl_NTL_Value.Text = "0";
            // 
            // lbl_NTW_Value
            // 
            this.lbl_NTW_Value.AutoSize = true;
            this.lbl_NTW_Value.Location = new System.Drawing.Point(453, 138);
            this.lbl_NTW_Value.Name = "lbl_NTW_Value";
            this.lbl_NTW_Value.Size = new System.Drawing.Size(26, 29);
            this.lbl_NTW_Value.TabIndex = 4;
            this.lbl_NTW_Value.Text = "0";
            // 
            // lbl_NTP_Value
            // 
            this.lbl_NTP_Value.AutoSize = true;
            this.lbl_NTP_Value.Location = new System.Drawing.Point(453, 71);
            this.lbl_NTP_Value.Name = "lbl_NTP_Value";
            this.lbl_NTP_Value.Size = new System.Drawing.Size(26, 29);
            this.lbl_NTP_Value.TabIndex = 3;
            this.lbl_NTP_Value.Text = "0";
            // 
            // lbl_Number_Times_Lost
            // 
            this.lbl_Number_Times_Lost.AutoSize = true;
            this.lbl_Number_Times_Lost.Location = new System.Drawing.Point(66, 201);
            this.lbl_Number_Times_Lost.Name = "lbl_Number_Times_Lost";
            this.lbl_Number_Times_Lost.Size = new System.Drawing.Size(251, 29);
            this.lbl_Number_Times_Lost.TabIndex = 2;
            this.lbl_Number_Times_Lost.Text = "Number of Times Lost";
            // 
            // lbl_Number_Times_Won
            // 
            this.lbl_Number_Times_Won.AutoSize = true;
            this.lbl_Number_Times_Won.Location = new System.Drawing.Point(66, 138);
            this.lbl_Number_Times_Won.Name = "lbl_Number_Times_Won";
            this.lbl_Number_Times_Won.Size = new System.Drawing.Size(255, 29);
            this.lbl_Number_Times_Won.TabIndex = 1;
            this.lbl_Number_Times_Won.Text = "Number of Times Won";
            // 
            // lbl_Number_Times_Played
            // 
            this.lbl_Number_Times_Played.AutoSize = true;
            this.lbl_Number_Times_Played.Location = new System.Drawing.Point(66, 71);
            this.lbl_Number_Times_Played.Name = "lbl_Number_Times_Played";
            this.lbl_Number_Times_Played.Size = new System.Drawing.Size(270, 29);
            this.lbl_Number_Times_Played.TabIndex = 0;
            this.lbl_Number_Times_Played.Text = "Number of times Played";
            // 
            // rtb_Frequency
            // 
            this.rtb_Frequency.BackColor = System.Drawing.Color.White;
            this.rtb_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Frequency.Location = new System.Drawing.Point(159, 3);
            this.rtb_Frequency.Name = "rtb_Frequency";
            this.rtb_Frequency.Size = new System.Drawing.Size(205, 274);
            this.rtb_Frequency.TabIndex = 13;
            this.rtb_Frequency.Text = "    FREQUENCY";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.66304F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.33696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            this.tableLayoutPanel1.Controls.Add(this.rtb_Percent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Frequency, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Face, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_NumTimesGuess, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 284);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // rtb_Percent
            // 
            this.rtb_Percent.BackColor = System.Drawing.Color.White;
            this.rtb_Percent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Percent.Location = new System.Drawing.Point(370, 3);
            this.rtb_Percent.Name = "rtb_Percent";
            this.rtb_Percent.Size = new System.Drawing.Size(175, 274);
            this.rtb_Percent.TabIndex = 15;
            this.rtb_Percent.Text = "      PERCENT";
            // 
            // rtb_Face
            // 
            this.rtb_Face.BackColor = System.Drawing.Color.White;
            this.rtb_Face.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Face.Location = new System.Drawing.Point(3, 3);
            this.rtb_Face.Name = "rtb_Face";
            this.rtb_Face.Size = new System.Drawing.Size(150, 274);
            this.rtb_Face.TabIndex = 14;
            this.rtb_Face.Text = "       FACE";
            // 
            // rtb_NumTimesGuess
            // 
            this.rtb_NumTimesGuess.BackColor = System.Drawing.Color.White;
            this.rtb_NumTimesGuess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_NumTimesGuess.Location = new System.Drawing.Point(551, 3);
            this.rtb_NumTimesGuess.Name = "rtb_NumTimesGuess";
            this.rtb_NumTimesGuess.Size = new System.Drawing.Size(391, 269);
            this.rtb_NumTimesGuess.TabIndex = 16;
            this.rtb_NumTimesGuess.Text = "   NUMBER OF TIMES GUESSED";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(44, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 287);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1026, 921);
            this.Controls.Add(this.gb_Game_Info);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Roll);
            this.Controls.Add(this.lbl_Enter_Guess);
            this.Controls.Add(this.tb_guess);
            this.Controls.Add(this.pb_Dice);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1054, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dice)).EndInit();
            this.gb_Game_Info.ResumeLayout(false);
            this.gb_Game_Info.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Roll;
        private System.Windows.Forms.Label lbl_Enter_Guess;
        private System.Windows.Forms.TextBox tb_guess;
        private System.Windows.Forms.PictureBox pb_Dice;
        private System.Windows.Forms.GroupBox gb_Game_Info;
        private System.Windows.Forms.Label lbl_NTL_Value;
        private System.Windows.Forms.Label lbl_NTW_Value;
        private System.Windows.Forms.Label lbl_NTP_Value;
        private System.Windows.Forms.Label lbl_Number_Times_Lost;
        private System.Windows.Forms.Label lbl_Number_Times_Won;
        private System.Windows.Forms.Label lbl_Number_Times_Played;
        private System.Windows.Forms.RichTextBox rtb_Frequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtb_Percent;
        private System.Windows.Forms.RichTextBox rtb_Face;
        private System.Windows.Forms.RichTextBox rtb_NumTimesGuess;
        private System.Windows.Forms.Panel panel1;
    }
}

