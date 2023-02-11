using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace StudentRecordsBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintRecordsTab_Click(object sender, EventArgs e)
        {

        }

        private void AddRecordsErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditSearchStudentIDButton_Click(object sender, EventArgs e)
        {
            populateEditDeleteDataGrid(EditDeleteStudentIDUpDown.Value.ToString());
        }

        private void DeleteGradeButton_Click(object sender, EventArgs e)
        {
            int rowToDelete = this.StudentCoursesDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            //if a valid row is not selected, do nothing
            if (rowToDelete <= -1)
            {
                return;
            }

            string courseToDeletePrefix, courseToDeleteNum;
            //retrieve prefix an number of course to be deleted
            courseToDeletePrefix = this.StudentCoursesDataGrid.Rows[rowToDelete].Cells[1].Value.ToString();
            courseToDeleteNum = this.StudentCoursesDataGrid.Rows[rowToDelete].Cells[2].Value.ToString();

            var confirmSubmission = MessageBox.Show("Are you sure you want to delete " + courseToDeletePrefix + " " + courseToDeleteNum + " for this student?",
                                     "Confirm delete",
                                     MessageBoxButtons.YesNo);
            if (confirmSubmission == DialogResult.Yes)
            {
                deleteSelectedGrade(StudentCoursesDataGrid.Tag.ToString(), this.StudentCoursesDataGrid.Rows[rowToDelete].Cells[0].Value.ToString());
                EditDeleteErrorLabel.Text = "Course deleted.";
                populateEditDeleteDataGrid(StudentCoursesDataGrid.Tag.ToString());
            }
            else
            {
                return;
            }
        }

        private void SubmitGradeEditButton_Click(object sender, EventArgs e)
        {
            int rowToEdit = this.StudentCoursesDataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (rowToEdit <= -1)
            {
                return;
            }

            char grade;

            //if else statements to return grade value depending on slected radio button
            if (EditARadioButton.Checked)
            {
                grade = 'A';
            }
            else if (EditBRadioButton.Checked)
            {
                grade = 'B';
            }
            else if (EditCRadioButton.Checked)
            {
                grade = 'C';
            }
            else if (EditDRadioButton.Checked)
            {
                grade = 'D';
            }
            else if (EditFRadioButton.Checked)
            {
                grade = 'F';
            }
            else if (EditWRadioButton.Checked)
            {
                grade = 'W';
            }
            else if (EditIRadioButton.Checked)
            {
                grade = 'I';
            }
            else if (EditSRadioButton.Checked)
            {
                grade = 'S';
            }
            else
            {
                //if no grade selected, return error message
                EditDeleteErrorLabel.Text = "Select a grade value.";
                return;
            }


            var confirmSubmission = MessageBox.Show("Are you sure you want to change selected grade to " + grade + " for this student?",
                                     "Confirm grade change",
                                     MessageBoxButtons.YesNo);
            //if user selects that they are sure 
            if (confirmSubmission == DialogResult.Yes)
            {
                changeSelectedGrade(StudentCoursesDataGrid.Tag.ToString(), this.StudentCoursesDataGrid.Rows[rowToEdit].Cells[0].Value.ToString(), grade);
                EditDeleteErrorLabel.Text = "Course grade updated.";
                populateEditDeleteDataGrid(StudentCoursesDataGrid.Tag.ToString());
                this.StudentCoursesDataGrid.Rows[rowToEdit].Selected = true;
            }
            else
            {
                return;
            }

        }


        private void PrintStudentIDButton_Click(object sender, EventArgs e)
        {
            //retreieve student id from GUI, then use to print the transcript
            String studentId = PrintStudentIDUpDown.Value.ToString();
            printTranscript(studentId);
        }

        private void SubmitGradeManuallyButton_Click(object sender, EventArgs e)
        {
            //resent error box to default blank
            AddRecordsErrorLabel.Text = "";
            char grade;
            if (AddAGradeRadioButton.Checked)
            {
                grade = 'A';
            }
            else if (AddBGradeRadioButton.Checked)
            {
                grade = 'B';
            }
            else if (AddCGradeRadioButton.Checked)
            {
                grade = 'C';
            }
            else if (AddDGradeRadioButton.Checked)
            {
                grade = 'D';
            }
            else if (AddFGradeRadioButton.Checked)
            {
                grade = 'F';
            }
            else if (AddWGradeRadioButton.Checked)
            {
                grade = 'W';
            }
            else if (AddIGradeRadioButton.Checked)
            {
                grade = 'I';
            }
            else if (AddSGradeRadioButton.Checked)
            {
                grade = 'S';
            }
            else
            {
                AddRecordsErrorLabel.Text = "Select a grade value.";
                return;
            }

            String studentIDString = AddStudentIDUpDown.Value.ToString();
            String courseIDString = AddCourseIDUpDown.Value.ToString();

            string verifiedStudentID;
            verifiedStudentID = verifyStudentID(studentIDString);
            if (verifiedStudentID == null)
            {
                AddRecordsErrorLabel.Text = "Student #" + studentIDString + " not found.";
                return;
            }

            String[] verifiedCourseID = new string[5];
            verifiedCourseID = verifyCourseID(courseIDString);
            if (verifiedCourseID == null)
            {
                AddRecordsErrorLabel.Text = "Course #" + courseIDString + " not found.";
                return;
            }

            if (checkForAddRedundancies(studentIDString, courseIDString))
            {
                AddRecordsErrorLabel.Text = "Grade already present in student records.";
                return;
            }

            var confirmSubmission = MessageBox.Show("Are you sure you want to submit grade " + grade + " for " + verifiedStudentID + " in " + verifiedCourseID[0] + " " + verifiedCourseID[1],
                                     "Confirm grade submission",
                                     MessageBoxButtons.YesNo);
            if (confirmSubmission == DialogResult.Yes)
            {
                addGrade(studentIDString, courseIDString, grade);
            }
            else
            {
                return;
            }

            AddRecordsErrorLabel.Text =  verifiedStudentID + " has received grade " + grade + " for " + verifiedCourseID[0] +
                " " + verifiedCourseID[1] + " in " + verifiedCourseID[2] + " of " + verifiedCourseID[3] + " (" + verifiedCourseID[4] + " credit hours)";
        }

        private void BrowseForExcelFileButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            //set the text in GUI to the file path of selected file
            SourceFileTextBox.Text = filePath;
        }

        protected bool checkForAddRedundancies(String studentID, String courseID)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {

                Console.WriteLine("Connecting to MySQL.");

                conn.Open();

                string sql = "SELECT letter FROM devoregrades WHERE student_id = @studentID AND course_id = @courseID";


                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@courseID", courseID);

                MySqlDataReader myReader = cmd.ExecuteReader();
                myReader.Close();
                conn.Close();

                if (myReader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            return false;
        }

        //verify that the course is a valid one in the database
        protected string[] verifyCourseID(String courseID)
        {
            string[] fullCourse = new String[5];

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {

                Console.WriteLine("Connecting to MySQL.");

                conn.Open();

                string sql = "SELECT prefix, num, semester, year, hours FROM devorecourses WHERE course_id = @courseID";


                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@courseID", courseID);

                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                //iterate through the results to retrieve the course information
                {
                    fullCourse[0] = myReader["prefix"].ToString();
                    fullCourse[1] = myReader["num"].ToString();
                    fullCourse[2] = myReader["semester"].ToString();
                    fullCourse[3] = myReader["year"].ToString();
                    fullCourse[4] = myReader["hours"].ToString();
                    myReader.Close();
                    conn.Close();
                    return fullCourse;
                }
                else
                {
                    myReader.Close();
                    conn.Close();
                    return null;
                }

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            Console.WriteLine("Done.");
            return null;
        }

        protected void populateEditDeleteDataGrid(String studentID)
        {
            //clear and information previously displayed in the GUI
            StudentCoursesDataGrid.Rows.Clear();
            StudentCoursesDataGrid.Tag = studentID;

            string fullName;

            fullName = verifyStudentID(studentID);

            if (fullName == null)
            {
                EditDeleteStudentNameLabel.Text = "No student matching ID# " + studentID + ".";
                return;
            }
            else
            {
                EditDeleteStudentNameLabel.Text = "Records for " + fullName + " (Student ID# " + studentID + ")";
            }

            System.Data.DataTable myTable = new System.Data.DataTable();

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            MySqlConnection conn = new MySqlConnection(connStr);

            try

            {
                Console.WriteLine("Connecting to MySQL.");

                conn.Open();

                //select all of the reeveant information for this student from the database
                string sql = "SELECT c.course_id, c.prefix, c.num, c.semester, c.year, c.hours, x.letter FROM devorecourses c JOIN devoregrades x ON c.course_id = x.course_id WHERE x.student_id = @studentID ORDER BY year DESC, semester DESC; ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentID);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);

                myAdapter.Fill(myTable);

                Console.WriteLine("Table is ready.");

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            //convert the retrieved data to events and save them to the list
            foreach (DataRow row in myTable.Rows)

            {
                this.StudentCoursesDataGrid.Rows.Add(row["course_id"].ToString(), row["prefix"].ToString(),
                    row["num"].ToString(), row["semester"].ToString(), row["year"].ToString(), row["hours"].ToString(), row["letter"].ToString());
            }
            return; //return the event list
        }

        //verify that the student id corresponds to a valid student in the databse
        protected string verifyStudentID(String studentID)
        {
            string fullName;

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try

            {

                Console.WriteLine("Connecting to MySQL.");

                conn.Open();

                string sql = "SELECT name FROM devorestudents WHERE student_id = @studentID";


                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentID);

                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())

                {

                    fullName = myReader["name"].ToString();
                    Console.WriteLine(fullName);
                    myReader.Close();
                    conn.Close();
                    return fullName;
                }
                else
                {
                    myReader.Close();
                    conn.Close();
                    return null;
                }

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            Console.WriteLine("Done.");
            return null;
        }

        protected void editGrade(String studentAffected, String courseToEdit, char grade)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "UPDATE devoregrades SET letter = @grade WHERE student_id = @studentID AND course_id = @courseID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentAffected);
                cmd.Parameters.AddWithValue("@courseID", courseToEdit);
                cmd.Parameters.AddWithValue("@grade", grade);
           
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("connection closed");
        }

        protected void changeSelectedGrade(String studentAffected, String courseToEdit, char grade)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
       
                string sql = "UPDATE devoregrades SET letter = @grade WHERE student_id = @studentID AND course_id = @courseID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentAffected);
                cmd.Parameters.AddWithValue("@courseID", courseToEdit);
                cmd.Parameters.AddWithValue("@grade", grade);
    
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("connection closed");
        }

        protected void printTranscript(String studentID)
        {
            if (verifyStudentID(studentID) != null)
            {
                //create text document for student transcript
                String transcript = assembleTranscript(studentID);
                //set the file name as a predictable string for easier desktop location
                String fileName = "StudentTranscript-"+studentID + ".txt";
                string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory)+"\\"+fileName;
                Console.WriteLine(strPath);
                //write the file to the user device
                File.WriteAllText(strPath, transcript);
                //inform the user of where the file was saved to for easier desktop searching
                PrintRecordsErrorLabel.Text = "Transcript printed to: \n"+strPath+".";
            }
            else
            {
                PrintRecordsErrorLabel.Text = "Student # "+studentID+" not found.";
            }
        }

        protected String assembleTranscript(String studentId)
        {
            string fullName;
            fullName = verifyStudentID(studentId);

            System.Data.DataTable myTable = new System.Data.DataTable();

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            MySqlConnection conn = new MySqlConnection(connStr);

            try

            {
                Console.WriteLine("Connecting to MySQL.");

                conn.Open();
                
                //begin creating table with student information for future iteration and transferring to text file
                string sql = "SELECT c.course_id, c.prefix, c.num, c.semester, c.year, c.hours, x.letter FROM devorecourses c JOIN devoregrades x ON c.course_id = x.course_id WHERE x.student_id = @studentID ORDER BY year DESC, semester DESC; ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentId);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);

                myAdapter.Fill(myTable);

                Console.WriteLine("Table is ready.");

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            String result = "Name is: " + fullName +  "\n";
            result += "ID is: " + studentId + "\n";
            double gradeSum = 0;
            int gradeQuant = 0;
            Boolean validLetter = true;
            int gradeValue = 0;
            result += "\nID PREFIX NUM SEMESTER YEAR CREDITS GRADE\n---------------------------------";
            foreach (DataRow row in myTable.Rows)

            {
                result += "\n" + row["course_id"].ToString() + " " + row["prefix"].ToString() + " " + row["num"].ToString() + " " + row["semester"].ToString() + " " + row["year"].ToString() + " " + row["hours"].ToString() + " " + row["letter"].ToString() + "\n";
                int hours = Int16.Parse(row["hours"].ToString());
                String grade = row["letter"].ToString();
                validLetter = true;
                //if the grade is a vlid letter add it to gpa calculation, otherwise do not
                switch (grade)
                {
                    case "A":
                        gradeValue = 4;
                        break;
                    case "B":
                        gradeValue = 3;
                        break;
                    case "C":
                        gradeValue = 2;
                        break;
                    case "D":
                        gradeValue = 1;
                        break;
                    case "F":
                        gradeValue = 0;
                        break;
                    default:
                        validLetter = false;
                        break;
                }
                if (validLetter)
                {
                    gradeValue *= hours;
                    gradeSum += gradeValue;
                    gradeQuant += hours;
                }
            }
            double gpa = gradeSum / gradeQuant;
            result += "\n"+"GPA is: " + gpa;
            return result; 
        }

        protected void deleteSelectedGrade(String studentAffected, String courseToDelete)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
       
                string sql = "DELETE FROM devoregrades WHERE student_id = @studentID AND course_id = @courseID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentAffected);
                cmd.Parameters.AddWithValue("@courseID", courseToDelete);
                //execute
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("connection closed");
            conn.Close();
        }

        protected void addGrade(String studentID, String courseID, char grade)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
     
                string sql = "insert into devoregrades (student_id, course_id, letter) values (@studentID, @courseID, @grade);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@courseID", courseID);
                cmd.Parameters.AddWithValue("grade", grade);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void importExcel(String filePath, String fileName)
        {
            //connect to databse for uploading of information
            String strConnection = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            MySqlConnection conn = new MySqlConnection(strConnection);
            
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;
            int count = -1;
            int column = 0;
            string name = "";
            int id = 0;
            char grade = 'u';
            //gather the course information from title of Excel file
            string[] classInfo = fileName.Split(' ');
            int courseId = 0;
            try

            {

                Console.WriteLine("Connecting to MySQL.");

                conn.Open();

                string sql = "SELECT course_id FROM devorecourses WHERE prefix = @prefix AND num = @num AND year = @year AND semester = @semester";


                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@prefix", classInfo[0]);
                cmd.Parameters.AddWithValue("@num", classInfo[1]);
                cmd.Parameters.AddWithValue("@year", classInfo[2]);
                cmd.Parameters.AddWithValue("@semester", classInfo[3]);

                MySqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())

                {
                    courseId = Int32.Parse(myReader["course_id"].ToString());
                    myReader.Close();
                    conn.Close();
                }
                else
                {
                    myReader.Close();
                    conn.Close();
                    AddRecordsErrorLabel.Text = "Course not found in database.";
                    return;
                }

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            //for each cell in the databse that contains information
            foreach (Range c in xlRange.Cells)
            {
                count++;
                column++;
                //count ensures that the column header information is not included
                //column keeps track of which column and tehrefore variable value is currently being read
                if (count > 2)
                {
                    if (count % 3 == 0)
                    {
                        Console.WriteLine("name value is " + c.Value);
                        name = c.Value;
                    }
                    else if (count % 3 == 1)
                    {
                        double idDub = c.Value;
                        string idString = idDub.ToString();
                        id = Int32.Parse(idString);
                    }
                    else
                    {
                        String gradeString = c.Value;
                        grade = gradeString[0];
                    }

                    if (count % 3 == 2)
                    {
                        try
                        {
                            conn.Open();

                            string sql = "insert into devoregrades (student_id, course_id, letter) values (@studentID, @courseID, @grade);";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);

                            cmd.Parameters.AddWithValue("@studentID", id);
                            cmd.Parameters.AddWithValue("@courseID", courseId);
                            cmd.Parameters.AddWithValue("grade", grade);

                            cmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            AddRecordsErrorLabel.Text = "Please check file for accuracy, some or all entries could not be uploaded.";
                            conn.Close();
                            return;
                        }
                        AddRecordsErrorLabel.Text = "Excel file successfully uploaded.";
                        conn.Close();
                    }
                }
            }
        }

        private void SubmitExcelFileButton_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentIDUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddRecordsTab_Click(object sender, EventArgs e)
        {

        }

        private void SubmitExcelFileButton_Click_1(object sender, EventArgs e)
        {
            if (SourceFileTextBox.Text != null) 
            {
                FileInfo fi = new FileInfo(SourceFileTextBox.Text);
                string extn = fi.Extension;
                string name = Path.GetFileNameWithoutExtension(SourceFileTextBox.Text);
                //ensure that the file selected is an Excel file
                if (extn.Equals(".xlsx"))
                {
                    importExcel(SourceFileTextBox.Text, name);
                }
                else
                {
                    AddRecordsErrorLabel.Text = "Please select an Excel file to import.";
                }
                
            }
            else
            {
                AddRecordsErrorLabel.Text = "Please select a file to import.";
            }

        }
    }
}
