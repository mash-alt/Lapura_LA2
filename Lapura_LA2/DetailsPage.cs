using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lapura_LA2
{
    public partial class DetailsPage : Form
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Clear previous validation messages
            Result.Text = "";

            // Validate Age
            if (string.IsNullOrWhiteSpace(Age.Text))
            {
                MessageBox.Show("Please enter your age.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Age.Focus();
                return;
            }

            // Check if Age is a valid number
            if (!int.TryParse(Age.Text, out int ageValue))
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Age.Focus();
                return;
            }

            // Check if Age is within a reasonable range
            if (ageValue < 1 || ageValue > 120)
            {
                MessageBox.Show("Please enter a valid age between 1 and 120.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Age.Focus();
                return;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Email.Focus();
                return;
            }

            // Check if Email is valid format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(Email.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Email.Focus();
                return;
            }

            // All validations passed - show success message
            Result.Text = "Age: " + Age.Text + "\nEmail: " + Email.Text;
            Result.ForeColor = Color.Green;

            // Clear the fields after successful submission
            Age.Clear();
            Email.Clear();
        }

        // Add event handler for the Back button if needed


        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}