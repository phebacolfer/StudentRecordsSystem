
namespace StudentRecordsBook
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
            this.TabController = new System.Windows.Forms.TabControl();
            this.AddRecordsTab = new System.Windows.Forms.TabPage();
            this.AddRecordsErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubmitGradeManuallyButton = new System.Windows.Forms.Button();
            this.AddSGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddIGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddWGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddFGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddDGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddCGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddBGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.AddAGradeRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectGradeLabel = new System.Windows.Forms.Label();
            this.AddCourseIDLabel = new System.Windows.Forms.Label();
            this.AddStudentIDLabel = new System.Windows.Forms.Label();
            this.AddCourseIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddStudentIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddRecordByFileGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitExcelFileButton = new System.Windows.Forms.Button();
            this.BrowseForExcelFileButton = new System.Windows.Forms.Button();
            this.SourceFileTextBox = new System.Windows.Forms.TextBox();
            this.AddRecordsLabel = new System.Windows.Forms.Label();
            this.EditDeleteRecordsTab = new System.Windows.Forms.TabPage();
            this.EditDeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.EditDeleteErrorLabel = new System.Windows.Forms.Label();
            this.EditDeleteStudentNameLabel = new System.Windows.Forms.Label();
            this.EditSearchStudentIDButton = new System.Windows.Forms.Button();
            this.DeleteGradeButton = new System.Windows.Forms.Button();
            this.SubmitGradeEditButton = new System.Windows.Forms.Button();
            this.EditSRadioButton = new System.Windows.Forms.RadioButton();
            this.EditIRadioButton = new System.Windows.Forms.RadioButton();
            this.EditWRadioButton = new System.Windows.Forms.RadioButton();
            this.EditFRadioButton = new System.Windows.Forms.RadioButton();
            this.EditDRadioButton = new System.Windows.Forms.RadioButton();
            this.EditCRadioButton = new System.Windows.Forms.RadioButton();
            this.EditBRadioButton = new System.Windows.Forms.RadioButton();
            this.EditARadioButton = new System.Windows.Forms.RadioButton();
            this.StudentCoursesDataGrid = new System.Windows.Forms.DataGridView();
            this.CourseIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePrefixColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseSemesterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDeleteStudentIDLabel = new System.Windows.Forms.Label();
            this.EditDeleteStudentIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditDeleteRecordsLabel = new System.Windows.Forms.Label();
            this.PrintRecordsTab = new System.Windows.Forms.TabPage();
            this.PrintRecordsErrorLabel = new System.Windows.Forms.Label();
            this.PrintRecordsGroupBox = new System.Windows.Forms.GroupBox();
            this.PrintStudentIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrintStudentIDButton = new System.Windows.Forms.Button();
            this.PrintStudentIDLabel = new System.Windows.Forms.Label();
            this.PrintRecordsLabel = new System.Windows.Forms.Label();
            this.TabController.SuspendLayout();
            this.AddRecordsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCourseIDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentIDUpDown)).BeginInit();
            this.AddRecordByFileGroupBox.SuspendLayout();
            this.EditDeleteRecordsTab.SuspendLayout();
            this.EditDeleteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCoursesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDeleteStudentIDUpDown)).BeginInit();
            this.PrintRecordsTab.SuspendLayout();
            this.PrintRecordsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStudentIDUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.AddRecordsTab);
            this.TabController.Controls.Add(this.EditDeleteRecordsTab);
            this.TabController.Controls.Add(this.PrintRecordsTab);
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(840, 465);
            this.TabController.TabIndex = 0;
            // 
            // AddRecordsTab
            // 
            this.AddRecordsTab.Controls.Add(this.AddRecordsErrorLabel);
            this.AddRecordsTab.Controls.Add(this.groupBox2);
            this.AddRecordsTab.Controls.Add(this.AddRecordByFileGroupBox);
            this.AddRecordsTab.Controls.Add(this.AddRecordsLabel);
            this.AddRecordsTab.Location = new System.Drawing.Point(4, 22);
            this.AddRecordsTab.Name = "AddRecordsTab";
            this.AddRecordsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddRecordsTab.Size = new System.Drawing.Size(832, 439);
            this.AddRecordsTab.TabIndex = 0;
            this.AddRecordsTab.Text = "Add Records";
            this.AddRecordsTab.UseVisualStyleBackColor = true;
            this.AddRecordsTab.Click += new System.EventHandler(this.AddRecordsTab_Click);
            // 
            // AddRecordsErrorLabel
            // 
            this.AddRecordsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordsErrorLabel.Location = new System.Drawing.Point(8, 275);
            this.AddRecordsErrorLabel.Name = "AddRecordsErrorLabel";
            this.AddRecordsErrorLabel.Size = new System.Drawing.Size(699, 78);
            this.AddRecordsErrorLabel.TabIndex = 3;
            this.AddRecordsErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddRecordsErrorLabel.Click += new System.EventHandler(this.AddRecordsErrorLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.SubmitGradeManuallyButton);
            this.groupBox2.Controls.Add(this.AddSGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddIGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddWGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddFGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddDGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddCGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddBGradeRadioButton);
            this.groupBox2.Controls.Add(this.AddAGradeRadioButton);
            this.groupBox2.Controls.Add(this.SelectGradeLabel);
            this.groupBox2.Controls.Add(this.AddCourseIDLabel);
            this.groupBox2.Controls.Add(this.AddStudentIDLabel);
            this.groupBox2.Controls.Add(this.AddCourseIDUpDown);
            this.groupBox2.Controls.Add(this.AddStudentIDUpDown);
            this.groupBox2.Location = new System.Drawing.Point(8, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Record Manually";
            // 
            // SubmitGradeManuallyButton
            // 
            this.SubmitGradeManuallyButton.Location = new System.Drawing.Point(7, 73);
            this.SubmitGradeManuallyButton.Name = "SubmitGradeManuallyButton";
            this.SubmitGradeManuallyButton.Size = new System.Drawing.Size(158, 23);
            this.SubmitGradeManuallyButton.TabIndex = 13;
            this.SubmitGradeManuallyButton.Text = "Submit Grade Manually";
            this.SubmitGradeManuallyButton.UseVisualStyleBackColor = true;
            this.SubmitGradeManuallyButton.Click += new System.EventHandler(this.SubmitGradeManuallyButton_Click);
            // 
            // AddSGradeRadioButton
            // 
            this.AddSGradeRadioButton.AutoSize = true;
            this.AddSGradeRadioButton.Location = new System.Drawing.Point(521, 50);
            this.AddSGradeRadioButton.Name = "AddSGradeRadioButton";
            this.AddSGradeRadioButton.Size = new System.Drawing.Size(32, 17);
            this.AddSGradeRadioButton.TabIndex = 12;
            this.AddSGradeRadioButton.TabStop = true;
            this.AddSGradeRadioButton.Text = "S";
            this.AddSGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddIGradeRadioButton
            // 
            this.AddIGradeRadioButton.AutoSize = true;
            this.AddIGradeRadioButton.Location = new System.Drawing.Point(487, 50);
            this.AddIGradeRadioButton.Name = "AddIGradeRadioButton";
            this.AddIGradeRadioButton.Size = new System.Drawing.Size(28, 17);
            this.AddIGradeRadioButton.TabIndex = 11;
            this.AddIGradeRadioButton.TabStop = true;
            this.AddIGradeRadioButton.Text = "I";
            this.AddIGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddWGradeRadioButton
            // 
            this.AddWGradeRadioButton.AutoSize = true;
            this.AddWGradeRadioButton.Location = new System.Drawing.Point(445, 50);
            this.AddWGradeRadioButton.Name = "AddWGradeRadioButton";
            this.AddWGradeRadioButton.Size = new System.Drawing.Size(36, 17);
            this.AddWGradeRadioButton.TabIndex = 10;
            this.AddWGradeRadioButton.TabStop = true;
            this.AddWGradeRadioButton.Text = "W";
            this.AddWGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddFGradeRadioButton
            // 
            this.AddFGradeRadioButton.AutoSize = true;
            this.AddFGradeRadioButton.Location = new System.Drawing.Point(411, 50);
            this.AddFGradeRadioButton.Name = "AddFGradeRadioButton";
            this.AddFGradeRadioButton.Size = new System.Drawing.Size(31, 17);
            this.AddFGradeRadioButton.TabIndex = 9;
            this.AddFGradeRadioButton.TabStop = true;
            this.AddFGradeRadioButton.Text = "F";
            this.AddFGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddDGradeRadioButton
            // 
            this.AddDGradeRadioButton.AutoSize = true;
            this.AddDGradeRadioButton.Location = new System.Drawing.Point(373, 50);
            this.AddDGradeRadioButton.Name = "AddDGradeRadioButton";
            this.AddDGradeRadioButton.Size = new System.Drawing.Size(33, 17);
            this.AddDGradeRadioButton.TabIndex = 8;
            this.AddDGradeRadioButton.TabStop = true;
            this.AddDGradeRadioButton.Text = "D";
            this.AddDGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddCGradeRadioButton
            // 
            this.AddCGradeRadioButton.AutoSize = true;
            this.AddCGradeRadioButton.Location = new System.Drawing.Point(335, 50);
            this.AddCGradeRadioButton.Name = "AddCGradeRadioButton";
            this.AddCGradeRadioButton.Size = new System.Drawing.Size(32, 17);
            this.AddCGradeRadioButton.TabIndex = 7;
            this.AddCGradeRadioButton.TabStop = true;
            this.AddCGradeRadioButton.Text = "C";
            this.AddCGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddBGradeRadioButton
            // 
            this.AddBGradeRadioButton.AutoSize = true;
            this.AddBGradeRadioButton.Location = new System.Drawing.Point(297, 50);
            this.AddBGradeRadioButton.Name = "AddBGradeRadioButton";
            this.AddBGradeRadioButton.Size = new System.Drawing.Size(32, 17);
            this.AddBGradeRadioButton.TabIndex = 6;
            this.AddBGradeRadioButton.TabStop = true;
            this.AddBGradeRadioButton.Text = "B";
            this.AddBGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddAGradeRadioButton
            // 
            this.AddAGradeRadioButton.AutoSize = true;
            this.AddAGradeRadioButton.Location = new System.Drawing.Point(259, 50);
            this.AddAGradeRadioButton.Name = "AddAGradeRadioButton";
            this.AddAGradeRadioButton.Size = new System.Drawing.Size(32, 17);
            this.AddAGradeRadioButton.TabIndex = 5;
            this.AddAGradeRadioButton.TabStop = true;
            this.AddAGradeRadioButton.Text = "A";
            this.AddAGradeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectGradeLabel
            // 
            this.SelectGradeLabel.AutoSize = true;
            this.SelectGradeLabel.Location = new System.Drawing.Point(360, 28);
            this.SelectGradeLabel.Name = "SelectGradeLabel";
            this.SelectGradeLabel.Size = new System.Drawing.Size(69, 13);
            this.SelectGradeLabel.TabIndex = 4;
            this.SelectGradeLabel.Text = "Select Grade";
            // 
            // AddCourseIDLabel
            // 
            this.AddCourseIDLabel.AutoSize = true;
            this.AddCourseIDLabel.Location = new System.Drawing.Point(164, 28);
            this.AddCourseIDLabel.Name = "AddCourseIDLabel";
            this.AddCourseIDLabel.Size = new System.Drawing.Size(54, 13);
            this.AddCourseIDLabel.TabIndex = 3;
            this.AddCourseIDLabel.Text = "Course ID";
            // 
            // AddStudentIDLabel
            // 
            this.AddStudentIDLabel.AutoSize = true;
            this.AddStudentIDLabel.Location = new System.Drawing.Point(33, 28);
            this.AddStudentIDLabel.Name = "AddStudentIDLabel";
            this.AddStudentIDLabel.Size = new System.Drawing.Size(55, 13);
            this.AddStudentIDLabel.TabIndex = 2;
            this.AddStudentIDLabel.Text = "StudentID";
            // 
            // AddCourseIDUpDown
            // 
            this.AddCourseIDUpDown.Location = new System.Drawing.Point(132, 47);
            this.AddCourseIDUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AddCourseIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddCourseIDUpDown.Name = "AddCourseIDUpDown";
            this.AddCourseIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.AddCourseIDUpDown.TabIndex = 1;
            this.AddCourseIDUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // AddStudentIDUpDown
            // 
            this.AddStudentIDUpDown.Location = new System.Drawing.Point(7, 47);
            this.AddStudentIDUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.AddStudentIDUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddStudentIDUpDown.Name = "AddStudentIDUpDown";
            this.AddStudentIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.AddStudentIDUpDown.TabIndex = 0;
            this.AddStudentIDUpDown.Value = new decimal(new int[] {
            901000000,
            0,
            0,
            0});
            this.AddStudentIDUpDown.ValueChanged += new System.EventHandler(this.AddStudentIDUpDown_ValueChanged);
            // 
            // AddRecordByFileGroupBox
            // 
            this.AddRecordByFileGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRecordByFileGroupBox.Controls.Add(this.SubmitExcelFileButton);
            this.AddRecordByFileGroupBox.Controls.Add(this.BrowseForExcelFileButton);
            this.AddRecordByFileGroupBox.Controls.Add(this.SourceFileTextBox);
            this.AddRecordByFileGroupBox.Location = new System.Drawing.Point(8, 51);
            this.AddRecordByFileGroupBox.Name = "AddRecordByFileGroupBox";
            this.AddRecordByFileGroupBox.Size = new System.Drawing.Size(699, 78);
            this.AddRecordByFileGroupBox.TabIndex = 1;
            this.AddRecordByFileGroupBox.TabStop = false;
            this.AddRecordByFileGroupBox.Text = "Add Record By Excel File";
            // 
            // SubmitExcelFileButton
            // 
            this.SubmitExcelFileButton.Location = new System.Drawing.Point(7, 47);
            this.SubmitExcelFileButton.Name = "SubmitExcelFileButton";
            this.SubmitExcelFileButton.Size = new System.Drawing.Size(158, 23);
            this.SubmitExcelFileButton.TabIndex = 2;
            this.SubmitExcelFileButton.Text = "Submit Excel File";
            this.SubmitExcelFileButton.UseVisualStyleBackColor = true;
            this.SubmitExcelFileButton.Click += new System.EventHandler(this.SubmitExcelFileButton_Click_1);
            // 
            // BrowseForExcelFileButton
            // 
            this.BrowseForExcelFileButton.Location = new System.Drawing.Point(388, 20);
            this.BrowseForExcelFileButton.Name = "BrowseForExcelFileButton";
            this.BrowseForExcelFileButton.Size = new System.Drawing.Size(135, 20);
            this.BrowseForExcelFileButton.TabIndex = 1;
            this.BrowseForExcelFileButton.Text = "Browse For An Excel File";
            this.BrowseForExcelFileButton.UseVisualStyleBackColor = true;
            this.BrowseForExcelFileButton.Click += new System.EventHandler(this.BrowseForExcelFileButton_Click);
            // 
            // SourceFileTextBox
            // 
            this.SourceFileTextBox.Location = new System.Drawing.Point(7, 20);
            this.SourceFileTextBox.Name = "SourceFileTextBox";
            this.SourceFileTextBox.Size = new System.Drawing.Size(374, 20);
            this.SourceFileTextBox.TabIndex = 0;
            // 
            // AddRecordsLabel
            // 
            this.AddRecordsLabel.AutoSize = true;
            this.AddRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordsLabel.Location = new System.Drawing.Point(290, 3);
            this.AddRecordsLabel.Name = "AddRecordsLabel";
            this.AddRecordsLabel.Size = new System.Drawing.Size(213, 37);
            this.AddRecordsLabel.TabIndex = 0;
            this.AddRecordsLabel.Text = "Add Records";
            // 
            // EditDeleteRecordsTab
            // 
            this.EditDeleteRecordsTab.Controls.Add(this.EditDeleteGroupBox);
            this.EditDeleteRecordsTab.Controls.Add(this.EditDeleteRecordsLabel);
            this.EditDeleteRecordsTab.Location = new System.Drawing.Point(4, 22);
            this.EditDeleteRecordsTab.Name = "EditDeleteRecordsTab";
            this.EditDeleteRecordsTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditDeleteRecordsTab.Size = new System.Drawing.Size(832, 439);
            this.EditDeleteRecordsTab.TabIndex = 1;
            this.EditDeleteRecordsTab.Text = "Edit/Delete Records";
            this.EditDeleteRecordsTab.UseVisualStyleBackColor = true;
            // 
            // EditDeleteGroupBox
            // 
            this.EditDeleteGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditDeleteGroupBox.Controls.Add(this.EditDeleteErrorLabel);
            this.EditDeleteGroupBox.Controls.Add(this.EditDeleteStudentNameLabel);
            this.EditDeleteGroupBox.Controls.Add(this.EditSearchStudentIDButton);
            this.EditDeleteGroupBox.Controls.Add(this.DeleteGradeButton);
            this.EditDeleteGroupBox.Controls.Add(this.SubmitGradeEditButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditSRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditIRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditWRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditFRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditDRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditCRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditBRadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.EditARadioButton);
            this.EditDeleteGroupBox.Controls.Add(this.StudentCoursesDataGrid);
            this.EditDeleteGroupBox.Controls.Add(this.EditDeleteStudentIDLabel);
            this.EditDeleteGroupBox.Controls.Add(this.EditDeleteStudentIDUpDown);
            this.EditDeleteGroupBox.Location = new System.Drawing.Point(0, 43);
            this.EditDeleteGroupBox.Name = "EditDeleteGroupBox";
            this.EditDeleteGroupBox.Size = new System.Drawing.Size(829, 393);
            this.EditDeleteGroupBox.TabIndex = 2;
            this.EditDeleteGroupBox.TabStop = false;
            // 
            // EditDeleteErrorLabel
            // 
            this.EditDeleteErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDeleteErrorLabel.Location = new System.Drawing.Point(118, 311);
            this.EditDeleteErrorLabel.Name = "EditDeleteErrorLabel";
            this.EditDeleteErrorLabel.Size = new System.Drawing.Size(633, 26);
            this.EditDeleteErrorLabel.TabIndex = 15;
            this.EditDeleteErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditDeleteStudentNameLabel
            // 
            this.EditDeleteStudentNameLabel.Location = new System.Drawing.Point(216, 39);
            this.EditDeleteStudentNameLabel.Name = "EditDeleteStudentNameLabel";
            this.EditDeleteStudentNameLabel.Size = new System.Drawing.Size(535, 23);
            this.EditDeleteStudentNameLabel.TabIndex = 14;
            this.EditDeleteStudentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditSearchStudentIDButton
            // 
            this.EditSearchStudentIDButton.Location = new System.Drawing.Point(135, 42);
            this.EditSearchStudentIDButton.Name = "EditSearchStudentIDButton";
            this.EditSearchStudentIDButton.Size = new System.Drawing.Size(75, 20);
            this.EditSearchStudentIDButton.TabIndex = 13;
            this.EditSearchStudentIDButton.Text = "Search";
            this.EditSearchStudentIDButton.UseVisualStyleBackColor = true;
            this.EditSearchStudentIDButton.Click += new System.EventHandler(this.EditSearchStudentIDButton_Click);
            // 
            // DeleteGradeButton
            // 
            this.DeleteGradeButton.Location = new System.Drawing.Point(18, 314);
            this.DeleteGradeButton.Name = "DeleteGradeButton";
            this.DeleteGradeButton.Size = new System.Drawing.Size(94, 23);
            this.DeleteGradeButton.TabIndex = 12;
            this.DeleteGradeButton.Text = "Delete Grade";
            this.DeleteGradeButton.UseVisualStyleBackColor = true;
            this.DeleteGradeButton.Click += new System.EventHandler(this.DeleteGradeButton_Click);
            // 
            // SubmitGradeEditButton
            // 
            this.SubmitGradeEditButton.Location = new System.Drawing.Point(754, 252);
            this.SubmitGradeEditButton.Name = "SubmitGradeEditButton";
            this.SubmitGradeEditButton.Size = new System.Drawing.Size(75, 47);
            this.SubmitGradeEditButton.TabIndex = 11;
            this.SubmitGradeEditButton.Text = "Submit Grade Change";
            this.SubmitGradeEditButton.UseVisualStyleBackColor = true;
            this.SubmitGradeEditButton.Click += new System.EventHandler(this.SubmitGradeEditButton_Click);
            // 
            // EditSRadioButton
            // 
            this.EditSRadioButton.AutoSize = true;
            this.EditSRadioButton.Location = new System.Drawing.Point(770, 229);
            this.EditSRadioButton.Name = "EditSRadioButton";
            this.EditSRadioButton.Size = new System.Drawing.Size(32, 17);
            this.EditSRadioButton.TabIndex = 10;
            this.EditSRadioButton.TabStop = true;
            this.EditSRadioButton.Text = "S";
            this.EditSRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditIRadioButton
            // 
            this.EditIRadioButton.AutoSize = true;
            this.EditIRadioButton.Location = new System.Drawing.Point(770, 206);
            this.EditIRadioButton.Name = "EditIRadioButton";
            this.EditIRadioButton.Size = new System.Drawing.Size(28, 17);
            this.EditIRadioButton.TabIndex = 9;
            this.EditIRadioButton.TabStop = true;
            this.EditIRadioButton.Text = "I";
            this.EditIRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditWRadioButton
            // 
            this.EditWRadioButton.AutoSize = true;
            this.EditWRadioButton.Location = new System.Drawing.Point(770, 183);
            this.EditWRadioButton.Name = "EditWRadioButton";
            this.EditWRadioButton.Size = new System.Drawing.Size(36, 17);
            this.EditWRadioButton.TabIndex = 8;
            this.EditWRadioButton.TabStop = true;
            this.EditWRadioButton.Text = "W";
            this.EditWRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditFRadioButton
            // 
            this.EditFRadioButton.AutoSize = true;
            this.EditFRadioButton.Location = new System.Drawing.Point(770, 160);
            this.EditFRadioButton.Name = "EditFRadioButton";
            this.EditFRadioButton.Size = new System.Drawing.Size(31, 17);
            this.EditFRadioButton.TabIndex = 7;
            this.EditFRadioButton.TabStop = true;
            this.EditFRadioButton.Text = "F";
            this.EditFRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditDRadioButton
            // 
            this.EditDRadioButton.AutoSize = true;
            this.EditDRadioButton.Location = new System.Drawing.Point(770, 137);
            this.EditDRadioButton.Name = "EditDRadioButton";
            this.EditDRadioButton.Size = new System.Drawing.Size(33, 17);
            this.EditDRadioButton.TabIndex = 6;
            this.EditDRadioButton.TabStop = true;
            this.EditDRadioButton.Text = "D";
            this.EditDRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditCRadioButton
            // 
            this.EditCRadioButton.AutoSize = true;
            this.EditCRadioButton.Location = new System.Drawing.Point(770, 114);
            this.EditCRadioButton.Name = "EditCRadioButton";
            this.EditCRadioButton.Size = new System.Drawing.Size(32, 17);
            this.EditCRadioButton.TabIndex = 5;
            this.EditCRadioButton.TabStop = true;
            this.EditCRadioButton.Text = "C";
            this.EditCRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditBRadioButton
            // 
            this.EditBRadioButton.AutoSize = true;
            this.EditBRadioButton.Location = new System.Drawing.Point(770, 91);
            this.EditBRadioButton.Name = "EditBRadioButton";
            this.EditBRadioButton.Size = new System.Drawing.Size(32, 17);
            this.EditBRadioButton.TabIndex = 4;
            this.EditBRadioButton.TabStop = true;
            this.EditBRadioButton.Text = "B";
            this.EditBRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditARadioButton
            // 
            this.EditARadioButton.AutoSize = true;
            this.EditARadioButton.Location = new System.Drawing.Point(771, 68);
            this.EditARadioButton.Name = "EditARadioButton";
            this.EditARadioButton.Size = new System.Drawing.Size(32, 17);
            this.EditARadioButton.TabIndex = 3;
            this.EditARadioButton.TabStop = true;
            this.EditARadioButton.Text = "A";
            this.EditARadioButton.UseVisualStyleBackColor = true;
            // 
            // StudentCoursesDataGrid
            // 
            this.StudentCoursesDataGrid.AllowUserToAddRows = false;
            this.StudentCoursesDataGrid.AllowUserToDeleteRows = false;
            this.StudentCoursesDataGrid.AllowUserToResizeColumns = false;
            this.StudentCoursesDataGrid.AllowUserToResizeRows = false;
            this.StudentCoursesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentCoursesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseIDColumn,
            this.CoursePrefixColumn,
            this.CourseNumberColumn,
            this.CourseSemesterColumn,
            this.CourseYearColumn,
            this.CourseHoursColumn,
            this.CourseGradeColumn});
            this.StudentCoursesDataGrid.Location = new System.Drawing.Point(8, 68);
            this.StudentCoursesDataGrid.MultiSelect = false;
            this.StudentCoursesDataGrid.Name = "StudentCoursesDataGrid";
            this.StudentCoursesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentCoursesDataGrid.Size = new System.Drawing.Size(743, 240);
            this.StudentCoursesDataGrid.TabIndex = 2;
            // 
            // CourseIDColumn
            // 
            this.CourseIDColumn.HeaderText = "Course ID";
            this.CourseIDColumn.Name = "CourseIDColumn";
            this.CourseIDColumn.ReadOnly = true;
            // 
            // CoursePrefixColumn
            // 
            this.CoursePrefixColumn.HeaderText = "Course Prefix";
            this.CoursePrefixColumn.Name = "CoursePrefixColumn";
            this.CoursePrefixColumn.ReadOnly = true;
            // 
            // CourseNumberColumn
            // 
            this.CourseNumberColumn.HeaderText = "Course Number";
            this.CourseNumberColumn.Name = "CourseNumberColumn";
            this.CourseNumberColumn.ReadOnly = true;
            // 
            // CourseSemesterColumn
            // 
            this.CourseSemesterColumn.HeaderText = "Semester";
            this.CourseSemesterColumn.Name = "CourseSemesterColumn";
            this.CourseSemesterColumn.ReadOnly = true;
            // 
            // CourseYearColumn
            // 
            this.CourseYearColumn.HeaderText = "Year";
            this.CourseYearColumn.Name = "CourseYearColumn";
            this.CourseYearColumn.ReadOnly = true;
            // 
            // CourseHoursColumn
            // 
            this.CourseHoursColumn.HeaderText = "Hours";
            this.CourseHoursColumn.Name = "CourseHoursColumn";
            this.CourseHoursColumn.ReadOnly = true;
            // 
            // CourseGradeColumn
            // 
            this.CourseGradeColumn.HeaderText = "Grade";
            this.CourseGradeColumn.Name = "CourseGradeColumn";
            this.CourseGradeColumn.ReadOnly = true;
            // 
            // EditDeleteStudentIDLabel
            // 
            this.EditDeleteStudentIDLabel.AutoSize = true;
            this.EditDeleteStudentIDLabel.Location = new System.Drawing.Point(35, 26);
            this.EditDeleteStudentIDLabel.Name = "EditDeleteStudentIDLabel";
            this.EditDeleteStudentIDLabel.Size = new System.Drawing.Size(58, 13);
            this.EditDeleteStudentIDLabel.TabIndex = 1;
            this.EditDeleteStudentIDLabel.Text = "Student ID";
            // 
            // EditDeleteStudentIDUpDown
            // 
            this.EditDeleteStudentIDUpDown.Location = new System.Drawing.Point(8, 42);
            this.EditDeleteStudentIDUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.EditDeleteStudentIDUpDown.Name = "EditDeleteStudentIDUpDown";
            this.EditDeleteStudentIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.EditDeleteStudentIDUpDown.TabIndex = 0;
            this.EditDeleteStudentIDUpDown.Value = new decimal(new int[] {
            901000000,
            0,
            0,
            0});
            // 
            // EditDeleteRecordsLabel
            // 
            this.EditDeleteRecordsLabel.AutoSize = true;
            this.EditDeleteRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDeleteRecordsLabel.Location = new System.Drawing.Point(290, 3);
            this.EditDeleteRecordsLabel.Name = "EditDeleteRecordsLabel";
            this.EditDeleteRecordsLabel.Size = new System.Drawing.Size(317, 37);
            this.EditDeleteRecordsLabel.TabIndex = 1;
            this.EditDeleteRecordsLabel.Text = "Edit/Delete Records";
            // 
            // PrintRecordsTab
            // 
            this.PrintRecordsTab.Controls.Add(this.PrintRecordsErrorLabel);
            this.PrintRecordsTab.Controls.Add(this.PrintRecordsGroupBox);
            this.PrintRecordsTab.Controls.Add(this.PrintRecordsLabel);
            this.PrintRecordsTab.Location = new System.Drawing.Point(4, 22);
            this.PrintRecordsTab.Name = "PrintRecordsTab";
            this.PrintRecordsTab.Size = new System.Drawing.Size(832, 439);
            this.PrintRecordsTab.TabIndex = 2;
            this.PrintRecordsTab.Text = "Print Records";
            this.PrintRecordsTab.UseVisualStyleBackColor = true;
            this.PrintRecordsTab.Click += new System.EventHandler(this.PrintRecordsTab_Click);
            // 
            // PrintRecordsErrorLabel
            // 
            this.PrintRecordsErrorLabel.AutoSize = true;
            this.PrintRecordsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.PrintRecordsErrorLabel.Location = new System.Drawing.Point(18, 163);
            this.PrintRecordsErrorLabel.Name = "PrintRecordsErrorLabel";
            this.PrintRecordsErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.PrintRecordsErrorLabel.TabIndex = 5;
            // 
            // PrintRecordsGroupBox
            // 
            this.PrintRecordsGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrintRecordsGroupBox.Controls.Add(this.PrintStudentIDUpDown);
            this.PrintRecordsGroupBox.Controls.Add(this.PrintStudentIDButton);
            this.PrintRecordsGroupBox.Controls.Add(this.PrintStudentIDLabel);
            this.PrintRecordsGroupBox.Location = new System.Drawing.Point(8, 43);
            this.PrintRecordsGroupBox.Name = "PrintRecordsGroupBox";
            this.PrintRecordsGroupBox.Size = new System.Drawing.Size(721, 100);
            this.PrintRecordsGroupBox.TabIndex = 4;
            this.PrintRecordsGroupBox.TabStop = false;
            // 
            // PrintStudentIDUpDown
            // 
            this.PrintStudentIDUpDown.Location = new System.Drawing.Point(6, 42);
            this.PrintStudentIDUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PrintStudentIDUpDown.Name = "PrintStudentIDUpDown";
            this.PrintStudentIDUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrintStudentIDUpDown.TabIndex = 0;
            this.PrintStudentIDUpDown.Value = new decimal(new int[] {
            901000000,
            0,
            0,
            0});
            // 
            // PrintStudentIDButton
            // 
            this.PrintStudentIDButton.Location = new System.Drawing.Point(133, 42);
            this.PrintStudentIDButton.Name = "PrintStudentIDButton";
            this.PrintStudentIDButton.Size = new System.Drawing.Size(75, 20);
            this.PrintStudentIDButton.TabIndex = 3;
            this.PrintStudentIDButton.Text = "Print";
            this.PrintStudentIDButton.UseVisualStyleBackColor = true;
            this.PrintStudentIDButton.Click += new System.EventHandler(this.PrintStudentIDButton_Click);
            // 
            // PrintStudentIDLabel
            // 
            this.PrintStudentIDLabel.AutoSize = true;
            this.PrintStudentIDLabel.Location = new System.Drawing.Point(28, 26);
            this.PrintStudentIDLabel.Name = "PrintStudentIDLabel";
            this.PrintStudentIDLabel.Size = new System.Drawing.Size(58, 13);
            this.PrintStudentIDLabel.TabIndex = 2;
            this.PrintStudentIDLabel.Text = "Student ID";
            // 
            // PrintRecordsLabel
            // 
            this.PrintRecordsLabel.AutoSize = true;
            this.PrintRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintRecordsLabel.Location = new System.Drawing.Point(290, 3);
            this.PrintRecordsLabel.Name = "PrintRecordsLabel";
            this.PrintRecordsLabel.Size = new System.Drawing.Size(223, 37);
            this.PrintRecordsLabel.TabIndex = 1;
            this.PrintRecordsLabel.Text = "Print Records";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.TabController);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabController.ResumeLayout(false);
            this.AddRecordsTab.ResumeLayout(false);
            this.AddRecordsTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCourseIDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentIDUpDown)).EndInit();
            this.AddRecordByFileGroupBox.ResumeLayout(false);
            this.AddRecordByFileGroupBox.PerformLayout();
            this.EditDeleteRecordsTab.ResumeLayout(false);
            this.EditDeleteRecordsTab.PerformLayout();
            this.EditDeleteGroupBox.ResumeLayout(false);
            this.EditDeleteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCoursesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDeleteStudentIDUpDown)).EndInit();
            this.PrintRecordsTab.ResumeLayout(false);
            this.PrintRecordsTab.PerformLayout();
            this.PrintRecordsGroupBox.ResumeLayout(false);
            this.PrintRecordsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStudentIDUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage AddRecordsTab;
        private System.Windows.Forms.TabPage EditDeleteRecordsTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox AddRecordByFileGroupBox;
        private System.Windows.Forms.Button SubmitExcelFileButton;
        private System.Windows.Forms.Button BrowseForExcelFileButton;
        private System.Windows.Forms.TextBox SourceFileTextBox;
        private System.Windows.Forms.Label AddRecordsLabel;
        private System.Windows.Forms.TabPage PrintRecordsTab;
        private System.Windows.Forms.NumericUpDown AddCourseIDUpDown;
        private System.Windows.Forms.NumericUpDown AddStudentIDUpDown;
        private System.Windows.Forms.Label SelectGradeLabel;
        private System.Windows.Forms.Label AddCourseIDLabel;
        private System.Windows.Forms.Label AddStudentIDLabel;
        private System.Windows.Forms.RadioButton AddSGradeRadioButton;
        private System.Windows.Forms.RadioButton AddIGradeRadioButton;
        private System.Windows.Forms.RadioButton AddWGradeRadioButton;
        private System.Windows.Forms.RadioButton AddFGradeRadioButton;
        private System.Windows.Forms.RadioButton AddDGradeRadioButton;
        private System.Windows.Forms.RadioButton AddCGradeRadioButton;
        private System.Windows.Forms.RadioButton AddBGradeRadioButton;
        private System.Windows.Forms.RadioButton AddAGradeRadioButton;
        private System.Windows.Forms.Button SubmitGradeManuallyButton;
        private System.Windows.Forms.NumericUpDown PrintStudentIDUpDown;
        private System.Windows.Forms.Button PrintStudentIDButton;
        private System.Windows.Forms.Label PrintStudentIDLabel;
        private System.Windows.Forms.Label PrintRecordsLabel;
        private System.Windows.Forms.Label EditDeleteRecordsLabel;
        private System.Windows.Forms.NumericUpDown EditDeleteStudentIDUpDown;
        private System.Windows.Forms.GroupBox EditDeleteGroupBox;
        private System.Windows.Forms.GroupBox PrintRecordsGroupBox;
        private System.Windows.Forms.RadioButton EditARadioButton;
        private System.Windows.Forms.DataGridView StudentCoursesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoursePrefixColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSemesterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseYearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseHoursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseGradeColumn;
        private System.Windows.Forms.Label EditDeleteStudentIDLabel;
        private System.Windows.Forms.Button DeleteGradeButton;
        private System.Windows.Forms.Button SubmitGradeEditButton;
        private System.Windows.Forms.RadioButton EditSRadioButton;
        private System.Windows.Forms.RadioButton EditIRadioButton;
        private System.Windows.Forms.RadioButton EditWRadioButton;
        private System.Windows.Forms.RadioButton EditFRadioButton;
        private System.Windows.Forms.RadioButton EditDRadioButton;
        private System.Windows.Forms.RadioButton EditCRadioButton;
        private System.Windows.Forms.RadioButton EditBRadioButton;
        private System.Windows.Forms.Button EditSearchStudentIDButton;
        private System.Windows.Forms.Label AddRecordsErrorLabel;
        private System.Windows.Forms.Label EditDeleteStudentNameLabel;
        private System.Windows.Forms.Label EditDeleteErrorLabel;
        private System.Windows.Forms.Label PrintRecordsErrorLabel;
    }
}

