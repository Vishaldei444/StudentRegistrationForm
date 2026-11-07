using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCourse.Items.AddRange(new object[]
            {
                "Diploma in Information Technology",
                "Diploma in Computer Science",
                "BCA",
                "B.Sc. Computer Science"
            });
            cmbCourse.SelectedIndex = -1;

            dtpDob.Value = DateTime.Today;
            dtpDob.MaxDate = DateTime.Today;
            dtpDob.Checked = false;

            btnSubmit.Click += btnSubmit_Click;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lstSummary.Items.Clear();

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (name.Length == 0)
            {
                ShowError("Please enter the student name.", txtName);
                return;
            }

            if (email.Length == 0)
            {
                ShowError("Please enter the email address.", txtEmail);
                return;
            }

            if (!IsValidEmail(email))
            {
                ShowError("Enter a valid email, such as rahul@example.com.", txtEmail);
                return;
            }

            string gender;
            if (rdoMale.Checked)
                gender = rdoMale.Text;
            else if (rdoFemale.Checked)
                gender = rdoFemale.Text;
            else if (rdoOther.Checked)
                gender = rdoOther.Text;
            else
            {
                ShowError("Please select a gender.", rdoMale);
                return;
            }

            if (cmbCourse.SelectedIndex == -1)
            {
                ShowError("Please select a course.", cmbCourse);
                return;
            }

            var hobbies = new List<string>();

            if (chkReading.Checked)
                hobbies.Add(chkReading.Text);
            if (chkSports.Checked)
                hobbies.Add(chkSports.Text);
            if (chkMusic.Checked)
                hobbies.Add(chkMusic.Text);

            if (hobbies.Count == 0)
            {
                ShowError("Please select at least one hobby.", chkReading);
                return;
            }

            if (!dtpDob.Checked)
            {
                ShowError("Please select and confirm the date of birth.", dtpDob);
                return;
            }

            lstSummary.Items.Add($"Name: {name}");
            lstSummary.Items.Add($"Email: {email}");
            lstSummary.Items.Add($"Gender: {gender}");
            lstSummary.Items.Add($"Course: {cmbCourse.SelectedItem}");
            lstSummary.Items.Add($"Hobbies: {string.Join(", ", hobbies)}");
            lstSummary.Items.Add($"Date of Birth: {dtpDob.Value:dd-MM-yyyy}");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email &&
                       address.Host.Contains(".") &&
                       !address.Host.EndsWith(".");
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void ShowError(string message, Control field)
        {
            MessageBox.Show(this, message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            field.Focus();
        }
    }
}