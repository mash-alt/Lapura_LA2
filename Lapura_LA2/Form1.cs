namespace Lapura_LA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Clear previous validation messages
            Result.Text = "";

            // Validate First Name
            if (string.IsNullOrWhiteSpace(FirstName.Text))
            {
                MessageBox.Show("Please enter your first name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstName.Focus();
                return;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(LastName.Text))
            {
                MessageBox.Show("Please enter your last name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastName.Focus();
                return;
            }

            // Check for invalid characters in names (allow letters, spaces, hyphens, and apostrophes)
            string namePattern = @"^[a-zA-Z\s\-']+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(FirstName.Text, namePattern))
            {
                MessageBox.Show("First name contains invalid characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstName.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(LastName.Text, namePattern))
            {
                MessageBox.Show("Last name contains invalid characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastName.Focus();
                return;
            }

            // All validations passed - show success message
            Result.Text = "Hello " + FirstName.Text + " " + LastName.Text + "!";
            Result.ForeColor = Color.Green;

            // Clear the fields after successful submission
            FirstName.Clear();
            LastName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             DetailsPage detailsPage = new DetailsPage();
            detailsPage.Show();
        }
    }
}