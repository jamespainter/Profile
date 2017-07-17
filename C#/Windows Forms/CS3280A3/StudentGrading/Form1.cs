using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Student Grading namespace. has a collection of members that will help 
/// grade multiple students and multiple assignments per submission
/// </summary>
namespace StudentGrading
{
    /// <summary>
    /// w_scores class is a class keeps track of scores of students for the total amount of assignments submitted
    /// </summary>
    public partial class w_scores : Form
    {
        /// <summary>
        /// students array keeps track of number of students and there names 
        /// assigments array keeps track of the number of students and their score
        /// </summary>
        private String[] students;
        private String[,] assignments;
        private String[] averages;
        private String[] grades; 

        ///Arrays size variables 
        private int studentArraySize = 0;
        private int assignmentArraySize = 0;


        ///students index to keep track of where I am in the array
        private int studentsIndex = 0;

        //global strings that will display a students grad
        private string average = "0";
        private string grade = "0";

        /// <summary>
        /// w_scores() is the constructor that initializes my for and sets my error labels to null
        ///  and disables my the lower half of the form. 
        /// </summary>
        public w_scores()
        {
            InitializeComponent();
            lbl_error1.Text = "";
            lbl_error2.Text = ""; 
            disable(); 
        }

        /// <summary>
        /// Method disable() disables the lower half of the form 
        /// </summary>
        private void disable()
        {
            ///disables the all group boxes in the form 
            gb1_student_info.Enabled = false;
            gb_student_info.Enabled = false;
            gb_navigate.Enabled = false;
            gb_scores.Enabled = false;
        }

        /// <summary>
        /// Method Enable allows for the user to use the lower part of the form 
        /// </summary>
        private void enable()
        {
            /// enables all the group boxes on the form 
            gb1_student_info.Enabled = true;
            gb_student_info.Enabled = true;
            gb_navigate.Enabled = true;
            gb_scores.Enabled = true;
        }
        /// <summary>
        /// Method resets the entire form
        /// *disables all lower half group boxes 
        /// *clears my Rich Text box 
        /// *clears my array
        /// </summary>
        private void reset()
        {

            gb1_student_info.Enabled = false;
            gb_student_info.Enabled = false;
            gb_navigate.Enabled = false;
            gb_scores.Enabled = false;
            /// Clear rich text box
            rtb_display_scores.Clear(); 
            /// Clear array students and assignments 
            Array.Clear(students, 0 , students.Length );
            Array.Clear(assignments, 0, assignments.Length);

        }
        private void getAvgs(string[,] assignments)
        {



        }
        /// <summary>
        /// method getAvg gets the average of all assignments graded
        /// </summary>
        /// <param name="assignments"></param>
        private void getAvg(string[,] assignments)
        {
            /// create new double array that I will use to sum and get average
            Double[] studentGradeScores = new Double[studentArraySize];
            Double result = 0; 
            /// iterate through assignmnets string and set it a double array 
            for (int i = 0; i < studentArraySize; i++)
            {
                ///converst from string to double
                studentGradeScores[i] = Convert.ToDouble(assignments[studentsIndex, i]);
            }
            for (int i = 0; i < studentGradeScores.Length; i++)
            {
                ///sums all scores for each assignment
                result += studentGradeScores[i];
            }
            /// gets average and sets it to result
            result = result / studentArraySize;
            ///converts to int and rounds the decimal to int
            int avg = Convert.ToInt32(Math.Round(result));
            ///Method call to set average string and display letter grad
            setAvg(avg); 
        }

        /// <summary>
        /// set avg sets the string avg and sets the letter grad to the string grade depenging on the percentage of the average
        /// </summary>
        /// <param name="avg"></param>
        private void setAvg(int avg)
        {
            /// sets the average string
            average = "%" + avg.ToString();
            /// checks the average percentage and gives letter grade 
            if(avg >= 93 && avg <= 100)
            {
                grade = "A"; 
            }
            else if(avg >= 90 && avg < 93)
            {
                grade = "A-";
            }
            else if (avg >= 87 && avg < 90)
            {
                grade = "B+";
            }
            else if (avg >= 83 && avg < 87)
            {
                grade = "B";
            }
            else if (avg >= 80 && avg < 83)
            {
                grade = "B-";
            }
            else if (avg >= 77 && avg < 80)
            {
                grade = "C+";
            }
            else if (avg >= 73 && avg < 77)
            {
                grade = "C";
            }
            else if (avg >= 70 && avg < 73)
            {
                grade = "C-";
            }
            else if (avg >= 67 && avg < 70)
            {
                grade = "D+";
            }
            else if (avg >= 63 && avg < 67)
            {
                grade = "D";
            }
            else if (avg >= 60 && avg < 63)
            {
                grade = "D-";
            }
            else
            {
                grade = "F";
            }

        }
        /// <summary>
        /// Method displayStudentHeader writes a header on the initialization of the form 
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="totalAssignments"></param>
        private void displayStudentHeader(string studentName, int totalAssignments)
        {
            ///clears my rich text box 
            rtb_display_scores.Clear(); 
            /// initializes new stringbuilder to build the string of the header 
            StringBuilder numOfAssignments = new StringBuilder();
            for (int i = 0; i < totalAssignments; i++)
            {
                ///appends all instances of the assignments to string
                numOfAssignments.Append("#" + (i+1).ToString() + "              ");
            }

           // MessageBox.Show(studentName + "           " + numOfAssignments.ToString() + "         " + "Avg" + "         " + "Grade");
           ///writes sting of the header to the Rich Text Box  
           // rtb_display_scores.Text = studentName + "              " + numOfAssignments.ToString() + "    " + "Avg" + "   " + "Grade";
            rtb_display_scores.Text = studentName + String.Format("{0,14}", "") + String.Format("{0,0}", numOfAssignments.ToString()) + String.Format("{0,0}", "Avg         ") + String.Format("{0,5}", "Grade") + "\n";
        }

        ///this was used for a separate purpose Pay no attentions
        
        //private void displayStudentScore(int index, String[,] assigmentScores)
        //{
        //    rtb_display_scores.Clear();
        //    displayStudentHeader(students[studentsIndex], assignmentArraySize);
        //    StringBuilder assignmentScores = new StringBuilder();
        //    getAvg(assigmentScores); 
        //    //for (int i = 0; i < studentArraySize; i++)
        //    //{
             
        //    //        assignmentScores.Append(assignments[index, i]+"                ");
   
        //    //}
        //   // rtb_display_scores.Text +="\n                                    "+ assignmentScores.ToString() + "      " + average  + "       " + grade + "\n";
          
          

        //   // MessageBox.Show(assignmentScores.Length.ToString());
            


        //    /// Display All Scores for Students
        //    /// 
        //    /// 
        //    /// //rtb_display_scores.Text += "          "; 

        //    for (int i = 0; i < studentArraySize; i++)
        //    {
        //        for (int j = 0; j < assignmentArraySize; j++)
        //        {
        //            assignmentScores.Append(assignments[i, j]);


        //        }

        //    }
        //    int k = 0;
        //    rtb_display_scores.Text += students[0];
        //    for (int i = 1; i <= assignmentScores.Length; i++)
        //    {
        //        rtb_display_scores.Text += "              " + assignmentScores[i - 1].ToString();
        //        if (i % assignmentArraySize == 0)
        //        {
                    
        //            // MessageBox.Show(assignmentScores.Length.ToString());
        //            rtb_display_scores.Text += average + "  " + grade+ "\n ";
        //           // rtb_display_scores.Text += ;
        //           if(k < studentArraySize -1)
        //            rtb_display_scores.Text += students[k++]; 
        //        }
               
        //    }
        //   // rtb_display_scores.Text += "              " + assignmentScores.ToString() + "   ";

        //}
        

        ///Method displayStudentScore 
        ///Displays the header and scores for each student
             private void displayStudentScore(string studentName, int totalAssignments, int index, String[,] assigmentScores)
             {
                 ///Clears Rich Text Box 
                 rtb_display_scores.Clear();
                 /// gets the average of all assignments 
                 getAvg(assigmentScores);

                 ///Initializes string builder for assignmentScores 
                 ///Initializes string builder for numOfassignments
                 StringBuilder assignmentScores = new StringBuilder();
                 StringBuilder numOfAssignments = new StringBuilder();
                 ///loops through the total amount of the assignments and appends to the stringbuilder num of assignments 
                 for (int i = 0; i < totalAssignments; i++)
                 {
                     ///build the string build for the header
                     numOfAssignments.Append("#" + (i + 1).ToString() + String.Format("{0,15}", ""));
                 }

                 ///Loops through appending each of the assignment scores to stringbuilder
                 for (int i = 0; i < assignmentArraySize; i++)
                 {
                     /// build the string build for the assingmnets 
                     assignmentScores.Append(assignments[index, i] + String.Format("{0,15}", ""));

                 }

                 /// writes header and scores to rich text box 
                 rtb_display_scores.Text = studentName + String.Format("{0,14}","") + String.Format("{0,0}", numOfAssignments.ToString()) + String.Format("{0,0}", "Avg      ") + String.Format("{0,5}", "Grade");
                 rtb_display_scores.Text += Environment.NewLine + String.Format("{0,35}", "") + String.Format("{0,0}", assignmentScores.ToString()) + String.Format("{0,5}", average) + String.Format("{0,5}", grade );
             }
             

        private void changeStudentName(int index, string studentName)
        {
            int lblLength = lbl_student_name.Text.Length;

            ///changes the student name at the specific index
            students[index] = studentName;
            lbl_student_name.Text = students[index];
            displayStudentHeader(students[index], assignmentArraySize);
            tb_student_name.Clear();

            /// Extra

            //if(studentName.Length < lblLength)
            //{
            //    result = lblLength - studentName.Length; 
            //    for(int i = 0; i < result; i++)
            //    {
            //        studentName += "  ";
            //    }
            //}
            //if (lblLength <  studentName.Length)
            //{

            //        studentName.Trim();

            //}


        }


    

        private void btn_submit_Counts_Click(object sender, EventArgs e)
        {
            
            if(Int32.TryParse(tb_num_of_students.Text.ToString(), out studentArraySize) && Int32.TryParse(tb_num_of_assignments.Text.ToString(), out assignmentArraySize))
            {
                if (studentArraySize <= 10 && studentArraySize > 0 && assignmentArraySize <= 100 && assignmentArraySize > 0)
                {
                    lbl_error1.Text = ""; 
                    ///Enable other buttons 
                    enable(); 
                    ///initialize student students array 
                    students = new String[studentArraySize];
                    ///initialize assignments array 
                    //assignments = new String[assignmentArraySize, assignmentArraySize];
                    assignments = new String[studentArraySize, assignmentArraySize];

                    ///Populate student name array 
                    for (int i = 0; i < students.Length; i++)
                    {
                        students[i] = "Students # " + (i + 1).ToString();
                    }
                    ///Populate assignments array 
                    for (int i = 0; i < studentArraySize; i++)
                    {
                        for (int j = 0; j < assignmentArraySize; j++)
                        {
                            assignments[i, j] = "0";
                        }

                    }


                    ///Put the first student into the lbl_student_name 
                    lbl_student_name.Text = students[0];
                    ///Set Students index at 1; 
                    studentsIndex = 0;

                    ///Put the assignment range in the lbl_enter_assignment_number 
                    lbl_enter_assignment_number.Text = "Enter Assignment Number (1 - " + assignmentArraySize.ToString() + "):";
                    ///Calls to display the header of each student
                    displayStudentHeader(students[0], assignmentArraySize);
                    ///Clears all the text boxes 
                    tb_num_of_students.Clear();
                    tb_num_of_assignments.Clear();
                    tb_enter_assignment_number.Clear();
                    tb_assignment_score.Clear(); 

                }
                else
                {
                    lbl_error1.Text = "ERROR Student 1-10 & Assignments 1-100";
                    //MessageBox.Show("You have too many students or too many assignments");
                }
            }
            else
            {
                lbl_error1.Text = "ERROR Student 1-10 & Assignments 1-100";
                //MessageBox.Show("This is not correct input: Num of students" + tb_num_of_students.Text.ToString() + " : " + "tb_num_of_assignments.Text.ToString()");
                //Need to put in label 

            }
          
            

        }
        /// <summary>
        /// Navigates to the first student int the students array 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_first_student_Click(object sender, EventArgs e)
        {
            studentsIndex = 0;
            lbl_student_name.Text = students[studentsIndex];
            displayStudentHeader(students[studentsIndex], assignmentArraySize);

        }
        /// <summary>
        /// Navigates to the last student in the students array 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_last_student(object sender, EventArgs e)
        {
            studentsIndex = students.Length - 1;
            lbl_student_name.Text = students[studentsIndex];
            displayStudentHeader(students[studentsIndex], assignmentArraySize);
        }
        /// <summary>
        /// Navigates to the previous student in the students array 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Prev_Student_Click(object sender, EventArgs e)
        {
            if (studentsIndex > 0)
                studentsIndex--;

            lbl_student_name.Text = students[studentsIndex];
            displayStudentHeader(students[studentsIndex], assignmentArraySize);
        }
        /// <summary>
        /// Navigates to the next student in the students array 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_next_student_Click(object sender, EventArgs e)
        {
            if(studentsIndex < students.Length -1)
                studentsIndex++;

            lbl_student_name.Text = students[studentsIndex];
            displayStudentHeader(students[studentsIndex], assignmentArraySize);

        }
        /// <summary>
        /// Saves the new name to students array 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saves_name_Click(object sender, EventArgs e)
        {
            ///Method call to save the new students name
            changeStudentName(studentsIndex, tb_student_name.Text); 
        }
        /// <summary>
        /// btn_save_scor_Click event saves the scores to the assignments array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_score_Click(object sender, EventArgs e)
        {
            int assignmentIndex = 0;
            int scoreresult = 0; 
            ///Checks to make sure input is correct 
            if(Int32.TryParse(tb_enter_assignment_number.Text.ToString(), out assignmentIndex) && Int32.TryParse(tb_assignment_score.Text.ToString(), out scoreresult))
            {
                ///Checks to make sure input is correct 
                try {
                    if (scoreresult <= 100 && scoreresult > 0 && assignmentIndex >0 && assignmentIndex <= assignmentArraySize)
                    {
                        lbl_error2.Text = ""; 
                        String score = tb_assignment_score.Text;

                        assignments[studentsIndex, assignmentIndex - 1] = score;
                      
                    }
                    else
                    {
                        ///Catches and sets error label if input is incorrect
                       // MessageBox.Show("Your score is incorrect");
                        lbl_error2.Text = "ERROR Score  1-100 & Asignment (1-"+ assignmentArraySize+")";
                    }
                    ///Catches and sets error label if input is incorrect
                }catch(Exception exception)
                {
                    lbl_error2.Text = "ERROR Score  1-100 & Asignment (1-" + assignmentArraySize + ")";
                  //  MessageBox.Show("There is not an assigmnent" + assignmentIndex.ToString());
                }
        
            }
            else
            {
                ///Catches and sets error label if input is incorrect
                //put error in label 
                // MessageBox.Show("This incorrect input: " + tb_enter_assignment_number.Text.ToString());
                lbl_error2.Text = "ERROR Score  1-100 & Asignment (1-" + assignmentArraySize + ")";

            }
            ///Clears the textboxes
              tb_enter_assignment_number.Clear();
              tb_assignment_score.Clear();
        }
        /// <summary>
        /// displays all student scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_display_scores_Click(object sender, EventArgs e)
        {
            /// Method call to write all scores for student
           displayStudentScore(students[studentsIndex], assignmentArraySize,studentsIndex, assignments);
           // displayStudentScore(studentsIndex, assignments);
        }

       
        /// <summary>
        /// resets the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_scores_Click(object sender, EventArgs e)
        {
            reset(); 
        }
    }

  
}
