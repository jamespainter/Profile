namespace StudentGrading
{
    partial class w_scores
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
            this.gb_counts = new System.Windows.Forms.GroupBox();
            this.btn_submit_Counts = new System.Windows.Forms.Button();
            this.tb_num_of_assignments = new System.Windows.Forms.TextBox();
            this.tb_num_of_students = new System.Windows.Forms.TextBox();
            this.lbl_num_of_assignmnets = new System.Windows.Forms.Label();
            this.lbl_num_of_students = new System.Windows.Forms.Label();
            this.gb_navigate = new System.Windows.Forms.GroupBox();
            this.btn_next_student = new System.Windows.Forms.Button();
            this.btn_prev_Student = new System.Windows.Forms.Button();
            this.btn_first_student = new System.Windows.Forms.Button();
            this.gb_student_info = new System.Windows.Forms.GroupBox();
            this.btn_saves_name = new System.Windows.Forms.Button();
            this.tb_student_name = new System.Windows.Forms.TextBox();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.gb1_student_info = new System.Windows.Forms.GroupBox();
            this.lbl_assignmnet_score = new System.Windows.Forms.Label();
            this.tb_assignment_score = new System.Windows.Forms.TextBox();
            this.btn_save_score = new System.Windows.Forms.Button();
            this.tb_enter_assignment_number = new System.Windows.Forms.TextBox();
            this.lbl_enter_assignment_number = new System.Windows.Forms.Label();
            this.btn_display_scores = new System.Windows.Forms.Button();
            this.rtb_display_scores = new System.Windows.Forms.RichTextBox();
            this.btn_lst_student = new System.Windows.Forms.Button();
            this.btn_reset_scores = new System.Windows.Forms.Button();
            this.gb_scores = new System.Windows.Forms.GroupBox();
            this.lbl_error1 = new System.Windows.Forms.Label();
            this.lbl_error2 = new System.Windows.Forms.Label();
            this.gb_counts.SuspendLayout();
            this.gb_navigate.SuspendLayout();
            this.gb_student_info.SuspendLayout();
            this.gb1_student_info.SuspendLayout();
            this.gb_scores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_counts
            // 
            this.gb_counts.Controls.Add(this.lbl_error1);
            this.gb_counts.Controls.Add(this.btn_submit_Counts);
            this.gb_counts.Controls.Add(this.tb_num_of_assignments);
            this.gb_counts.Controls.Add(this.tb_num_of_students);
            this.gb_counts.Controls.Add(this.lbl_num_of_assignmnets);
            this.gb_counts.Controls.Add(this.lbl_num_of_students);
            this.gb_counts.Location = new System.Drawing.Point(28, 52);
            this.gb_counts.Name = "gb_counts";
            this.gb_counts.Size = new System.Drawing.Size(945, 223);
            this.gb_counts.TabIndex = 0;
            this.gb_counts.TabStop = false;
            this.gb_counts.Text = "Counts";
            // 
            // btn_submit_Counts
            // 
            this.btn_submit_Counts.Location = new System.Drawing.Point(584, 66);
            this.btn_submit_Counts.Name = "btn_submit_Counts";
            this.btn_submit_Counts.Size = new System.Drawing.Size(217, 64);
            this.btn_submit_Counts.TabIndex = 3;
            this.btn_submit_Counts.Text = "Submit Counts";
            this.btn_submit_Counts.UseVisualStyleBackColor = true;
            this.btn_submit_Counts.Click += new System.EventHandler(this.btn_submit_Counts_Click);
            // 
            // tb_num_of_assignments
            // 
            this.tb_num_of_assignments.Location = new System.Drawing.Point(396, 107);
            this.tb_num_of_assignments.Name = "tb_num_of_assignments";
            this.tb_num_of_assignments.Size = new System.Drawing.Size(126, 38);
            this.tb_num_of_assignments.TabIndex = 2;
            // 
            // tb_num_of_students
            // 
            this.tb_num_of_students.Location = new System.Drawing.Point(396, 45);
            this.tb_num_of_students.Name = "tb_num_of_students";
            this.tb_num_of_students.Size = new System.Drawing.Size(126, 38);
            this.tb_num_of_students.TabIndex = 2;
            // 
            // lbl_num_of_assignmnets
            // 
            this.lbl_num_of_assignmnets.AutoSize = true;
            this.lbl_num_of_assignmnets.Location = new System.Drawing.Point(60, 110);
            this.lbl_num_of_assignmnets.Name = "lbl_num_of_assignmnets";
            this.lbl_num_of_assignmnets.Size = new System.Drawing.Size(321, 32);
            this.lbl_num_of_assignmnets.TabIndex = 1;
            this.lbl_num_of_assignmnets.Text = "Number of assignments:";
            // 
            // lbl_num_of_students
            // 
            this.lbl_num_of_students.AutoSize = true;
            this.lbl_num_of_students.Location = new System.Drawing.Point(112, 51);
            this.lbl_num_of_students.Name = "lbl_num_of_students";
            this.lbl_num_of_students.Size = new System.Drawing.Size(269, 32);
            this.lbl_num_of_students.TabIndex = 0;
            this.lbl_num_of_students.Text = "Number of students:";
            // 
            // gb_navigate
            // 
            this.gb_navigate.Controls.Add(this.btn_lst_student);
            this.gb_navigate.Controls.Add(this.btn_next_student);
            this.gb_navigate.Controls.Add(this.btn_prev_Student);
            this.gb_navigate.Controls.Add(this.btn_first_student);
            this.gb_navigate.Location = new System.Drawing.Point(28, 308);
            this.gb_navigate.Name = "gb_navigate";
            this.gb_navigate.Size = new System.Drawing.Size(1316, 149);
            this.gb_navigate.TabIndex = 1;
            this.gb_navigate.TabStop = false;
            this.gb_navigate.Text = "Navigate";
            // 
            // btn_next_student
            // 
            this.btn_next_student.Location = new System.Drawing.Point(692, 55);
            this.btn_next_student.Name = "btn_next_student";
            this.btn_next_student.Size = new System.Drawing.Size(253, 64);
            this.btn_next_student.TabIndex = 4;
            this.btn_next_student.Text = "> Next Student";
            this.btn_next_student.UseVisualStyleBackColor = true;
            this.btn_next_student.Click += new System.EventHandler(this.btn_next_student_Click);
            // 
            // btn_prev_Student
            // 
            this.btn_prev_Student.Location = new System.Drawing.Point(377, 55);
            this.btn_prev_Student.Name = "btn_prev_Student";
            this.btn_prev_Student.Size = new System.Drawing.Size(253, 64);
            this.btn_prev_Student.TabIndex = 4;
            this.btn_prev_Student.Text = "< Prev Student";
            this.btn_prev_Student.UseVisualStyleBackColor = true;
            this.btn_prev_Student.Click += new System.EventHandler(this.btn_Prev_Student_Click);
            // 
            // btn_first_student
            // 
            this.btn_first_student.Location = new System.Drawing.Point(40, 55);
            this.btn_first_student.Name = "btn_first_student";
            this.btn_first_student.Size = new System.Drawing.Size(253, 64);
            this.btn_first_student.TabIndex = 4;
            this.btn_first_student.Text = "<< First Student";
            this.btn_first_student.UseVisualStyleBackColor = true;
            this.btn_first_student.Click += new System.EventHandler(this.btn_first_student_Click);
            // 
            // gb_student_info
            // 
            this.gb_student_info.Controls.Add(this.btn_saves_name);
            this.gb_student_info.Controls.Add(this.tb_student_name);
            this.gb_student_info.Controls.Add(this.lbl_student_name);
            this.gb_student_info.Location = new System.Drawing.Point(28, 526);
            this.gb_student_info.Name = "gb_student_info";
            this.gb_student_info.Size = new System.Drawing.Size(1316, 144);
            this.gb_student_info.TabIndex = 2;
            this.gb_student_info.TabStop = false;
            this.gb_student_info.Text = "Student Info";
            // 
            // btn_saves_name
            // 
            this.btn_saves_name.Location = new System.Drawing.Point(1028, 62);
            this.btn_saves_name.Name = "btn_saves_name";
            this.btn_saves_name.Size = new System.Drawing.Size(240, 65);
            this.btn_saves_name.TabIndex = 5;
            this.btn_saves_name.Text = "Saves Name";
            this.btn_saves_name.UseVisualStyleBackColor = true;
            this.btn_saves_name.Click += new System.EventHandler(this.btn_saves_name_Click);
            // 
            // tb_student_name
            // 
            this.tb_student_name.Location = new System.Drawing.Point(245, 62);
            this.tb_student_name.Name = "tb_student_name";
            this.tb_student_name.Size = new System.Drawing.Size(672, 38);
            this.tb_student_name.TabIndex = 4;
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Location = new System.Drawing.Point(60, 65);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(161, 32);
            this.lbl_student_name.TabIndex = 1;
            this.lbl_student_name.Text = "Student #1:";
            // 
            // gb1_student_info
            // 
            this.gb1_student_info.Controls.Add(this.lbl_error2);
            this.gb1_student_info.Controls.Add(this.lbl_assignmnet_score);
            this.gb1_student_info.Controls.Add(this.tb_assignment_score);
            this.gb1_student_info.Controls.Add(this.btn_save_score);
            this.gb1_student_info.Controls.Add(this.tb_enter_assignment_number);
            this.gb1_student_info.Controls.Add(this.lbl_enter_assignment_number);
            this.gb1_student_info.Location = new System.Drawing.Point(28, 704);
            this.gb1_student_info.Name = "gb1_student_info";
            this.gb1_student_info.Size = new System.Drawing.Size(1316, 217);
            this.gb1_student_info.TabIndex = 6;
            this.gb1_student_info.TabStop = false;
            this.gb1_student_info.Text = "Student Info";
            // 
            // lbl_assignmnet_score
            // 
            this.lbl_assignmnet_score.AutoSize = true;
            this.lbl_assignmnet_score.Location = new System.Drawing.Point(266, 135);
            this.lbl_assignmnet_score.Name = "lbl_assignmnet_score";
            this.lbl_assignmnet_score.Size = new System.Drawing.Size(253, 32);
            this.lbl_assignmnet_score.TabIndex = 8;
            this.lbl_assignmnet_score.Text = "Assignment Score:";
            // 
            // tb_assignment_score
            // 
            this.tb_assignment_score.Location = new System.Drawing.Point(584, 132);
            this.tb_assignment_score.Name = "tb_assignment_score";
            this.tb_assignment_score.Size = new System.Drawing.Size(126, 38);
            this.tb_assignment_score.TabIndex = 7;
            // 
            // btn_save_score
            // 
            this.btn_save_score.Location = new System.Drawing.Point(769, 77);
            this.btn_save_score.Name = "btn_save_score";
            this.btn_save_score.Size = new System.Drawing.Size(240, 65);
            this.btn_save_score.TabIndex = 6;
            this.btn_save_score.Text = "Saves Score";
            this.btn_save_score.UseVisualStyleBackColor = true;
            this.btn_save_score.Click += new System.EventHandler(this.btn_save_score_Click);
            // 
            // tb_enter_assignment_number
            // 
            this.tb_enter_assignment_number.Location = new System.Drawing.Point(584, 62);
            this.tb_enter_assignment_number.Name = "tb_enter_assignment_number";
            this.tb_enter_assignment_number.Size = new System.Drawing.Size(126, 38);
            this.tb_enter_assignment_number.TabIndex = 3;
            // 
            // lbl_enter_assignment_number
            // 
            this.lbl_enter_assignment_number.AutoSize = true;
            this.lbl_enter_assignment_number.Location = new System.Drawing.Point(85, 62);
            this.lbl_enter_assignment_number.Name = "lbl_enter_assignment_number";
            this.lbl_enter_assignment_number.Size = new System.Drawing.Size(434, 32);
            this.lbl_enter_assignment_number.TabIndex = 2;
            this.lbl_enter_assignment_number.Text = "Enter Assignment Number (1 - 5):";
            // 
            // btn_display_scores
            // 
            this.btn_display_scores.Location = new System.Drawing.Point(537, 21);
            this.btn_display_scores.Name = "btn_display_scores";
            this.btn_display_scores.Size = new System.Drawing.Size(240, 65);
            this.btn_display_scores.TabIndex = 9;
            this.btn_display_scores.Text = "Display Scores";
            this.btn_display_scores.UseVisualStyleBackColor = true;
            this.btn_display_scores.Click += new System.EventHandler(this.btn_display_scores_Click);
            // 
            // rtb_display_scores
            // 
            this.rtb_display_scores.Location = new System.Drawing.Point(0, 92);
            this.rtb_display_scores.Name = "rtb_display_scores";
            this.rtb_display_scores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtb_display_scores.Size = new System.Drawing.Size(1316, 259);
            this.rtb_display_scores.TabIndex = 10;
            this.rtb_display_scores.Text = "";
            this.rtb_display_scores.WordWrap = false;
            // 
            // btn_lst_student
            // 
            this.btn_lst_student.Location = new System.Drawing.Point(1015, 55);
            this.btn_lst_student.Name = "btn_lst_student";
            this.btn_lst_student.Size = new System.Drawing.Size(253, 64);
            this.btn_lst_student.TabIndex = 4;
            this.btn_lst_student.Text = ">> Last Student";
            this.btn_lst_student.UseVisualStyleBackColor = true;
            this.btn_lst_student.Click += new System.EventHandler(this.btn_last_student);
            // 
            // btn_reset_scores
            // 
            this.btn_reset_scores.Location = new System.Drawing.Point(1080, 90);
            this.btn_reset_scores.Name = "btn_reset_scores";
            this.btn_reset_scores.Size = new System.Drawing.Size(174, 121);
            this.btn_reset_scores.TabIndex = 11;
            this.btn_reset_scores.Text = "Reset Scores";
            this.btn_reset_scores.UseVisualStyleBackColor = true;
            this.btn_reset_scores.Click += new System.EventHandler(this.btn_reset_scores_Click);
            // 
            // gb_scores
            // 
            this.gb_scores.Controls.Add(this.btn_display_scores);
            this.gb_scores.Controls.Add(this.rtb_display_scores);
            this.gb_scores.Location = new System.Drawing.Point(28, 927);
            this.gb_scores.Name = "gb_scores";
            this.gb_scores.Size = new System.Drawing.Size(1318, 400);
            this.gb_scores.TabIndex = 12;
            this.gb_scores.TabStop = false;
            // 
            // lbl_error1
            // 
            this.lbl_error1.AutoSize = true;
            this.lbl_error1.Location = new System.Drawing.Point(72, 188);
            this.lbl_error1.Name = "lbl_error1";
            this.lbl_error1.Size = new System.Drawing.Size(93, 32);
            this.lbl_error1.TabIndex = 4;
            this.lbl_error1.Text = "label1";
            // 
            // lbl_error2
            // 
            this.lbl_error2.AutoSize = true;
            this.lbl_error2.Location = new System.Drawing.Point(763, 182);
            this.lbl_error2.Name = "lbl_error2";
            this.lbl_error2.Size = new System.Drawing.Size(93, 32);
            this.lbl_error2.TabIndex = 4;
            this.lbl_error2.Text = "label1";
            // 
            // w_scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1468, 1312);
            this.Controls.Add(this.btn_reset_scores);
            this.Controls.Add(this.gb1_student_info);
            this.Controls.Add(this.gb_student_info);
            this.Controls.Add(this.gb_navigate);
            this.Controls.Add(this.gb_counts);
            this.Controls.Add(this.gb_scores);
            this.Name = "w_scores";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Text = "Scores";
            this.gb_counts.ResumeLayout(false);
            this.gb_counts.PerformLayout();
            this.gb_navigate.ResumeLayout(false);
            this.gb_student_info.ResumeLayout(false);
            this.gb_student_info.PerformLayout();
            this.gb1_student_info.ResumeLayout(false);
            this.gb1_student_info.PerformLayout();
            this.gb_scores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_counts;
        private System.Windows.Forms.Button btn_submit_Counts;
        private System.Windows.Forms.TextBox tb_num_of_assignments;
        private System.Windows.Forms.TextBox tb_num_of_students;
        private System.Windows.Forms.Label lbl_num_of_assignmnets;
        private System.Windows.Forms.Label lbl_num_of_students;
        private System.Windows.Forms.GroupBox gb_navigate;
        private System.Windows.Forms.Button btn_next_student;
        private System.Windows.Forms.Button btn_prev_Student;
        private System.Windows.Forms.Button btn_first_student;
        private System.Windows.Forms.GroupBox gb_student_info;
        private System.Windows.Forms.Button btn_saves_name;
        private System.Windows.Forms.TextBox tb_student_name;
        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.GroupBox gb1_student_info;
        private System.Windows.Forms.TextBox tb_assignment_score;
        private System.Windows.Forms.Button btn_save_score;
        private System.Windows.Forms.TextBox tb_enter_assignment_number;
        private System.Windows.Forms.Label lbl_enter_assignment_number;
        private System.Windows.Forms.Label lbl_assignmnet_score;
        private System.Windows.Forms.Button btn_display_scores;
        private System.Windows.Forms.RichTextBox rtb_display_scores;
        private System.Windows.Forms.Button btn_lst_student;
        private System.Windows.Forms.Button btn_reset_scores;
        private System.Windows.Forms.GroupBox gb_scores;
        private System.Windows.Forms.Label lbl_error1;
        private System.Windows.Forms.Label lbl_error2;
    }
}

