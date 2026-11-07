namespace StudentRegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            grpGender = new GroupBox();
            rdoOther = new RadioButton();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            label3 = new Label();
            cmbCourse = new ComboBox();
            label4 = new Label();
            chkReading = new CheckBox();
            chkSports = new CheckBox();
            chkMusic = new CheckBox();
            label5 = new Label();
            dtpDob = new DateTimePicker();
            btnSubmit = new Button();
            lstSummary = new ListBox();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 18);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Name\r\n";
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 63);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(301, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoOther);
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(212, 103);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(200, 100);
            grpGender.TabIndex = 4;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            
            // 
            // rdoOther
            // 
            rdoOther.AutoSize = true;
            rdoOther.Location = new Point(0, 72);
            rdoOther.Name = "rdoOther";
            rdoOther.Size = new Size(55, 19);
            rdoOther.TabIndex = 2;
            rdoOther.TabStop = true;
            rdoOther.Text = "Other";
            rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(0, 47);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 1;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(0, 22);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 217);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Course";
            // 
            // cmbCourse
            // 
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(301, 217);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 260);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Hobbies";
            // 
            // chkReading
            // 
            chkReading.AutoSize = true;
            chkReading.Location = new Point(301, 260);
            chkReading.Name = "chkReading";
            chkReading.Size = new Size(69, 19);
            chkReading.TabIndex = 8;
            chkReading.Text = "Reading";
            chkReading.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            chkSports.AutoSize = true;
            chkSports.Location = new Point(418, 260);
            chkSports.Name = "chkSports";
            chkSports.Size = new Size(59, 19);
            chkSports.TabIndex = 9;
            chkSports.Text = "Sports";
            chkSports.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            chkMusic.AutoSize = true;
            chkMusic.Location = new Point(519, 261);
            chkMusic.Name = "chkMusic";
            chkMusic.Size = new Size(58, 19);
            chkMusic.TabIndex = 10;
            chkMusic.Text = "Music";
            chkMusic.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 296);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 11;
            label5.Text = "Date of Birth";
            // 
            // dtpDob
            // 
            dtpDob.Checked = false;
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(301, 290);
            dtpDob.Name = "dtpDob";
            dtpDob.ShowCheckBox = true;
            dtpDob.Size = new Size(200, 23);
            dtpDob.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(212, 330);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lstSummary
            // 
            lstSummary.FormattingEnabled = true;
            lstSummary.Location = new Point(212, 359);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(365, 154);
            lstSummary.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 450);
            Controls.Add(lstSummary);
            Controls.Add(btnSubmit);
            Controls.Add(dtpDob);
            Controls.Add(label5);
            Controls.Add(chkMusic);
            Controls.Add(chkSports);
            Controls.Add(chkReading);
            Controls.Add(label4);
            Controls.Add(cmbCourse);
            Controls.Add(label3);
            Controls.Add(grpGender);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEmail;
        private GroupBox grpGender;
        private RadioButton rdoOther;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label label3;
        private ComboBox cmbCourse;
        private Label label4;
        private CheckBox chkReading;
        private CheckBox chkSports;
        private CheckBox chkMusic;
        private Label label5;
        private DateTimePicker dtpDob;
        private Button btnSubmit;
        private ListBox lstSummary;
    }
}
