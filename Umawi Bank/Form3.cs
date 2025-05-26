using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form3 : Form
    {
    SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Form3()
        {
            InitializeComponent();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            DateTime birthDate = birthDatePicker.Value;
            DateTime today = DateTime.Today;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }
            if (birthDate.Date >= today)
            {
                MessageBox.Show("Please enter a valid birth date.");
                return;
            }
            string formattedBirthDate = birthDate.ToString("MM/dd/yyyy");
            string checkQuery = "SELECT COUNT(*) FROM signup WHERE email = @email AND birthdate = @birthdate";
            using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@birthdate", formattedBirthDate);
                conn.Open();
                int userExists = (int)cmd.ExecuteScalar();
                conn.Close();

                if (userExists > 0)
                {
                    MessageBox.Show("Email and birthdate matched. Please proceed to reset your password.");
                    newPasswordTextBox.Visible = true;
                    confirmResetButton.Visible = true;
                    newPasswordLabel.Visible = true;

                }
                else
                {
                    MessageBox.Show("The email and birthdate combination is incorrect.");
                }
            }
        }
        private void confirmResetButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }
            string resetQuery = "UPDATE signup SET password = @newPassword WHERE email = @email";
            using (SqlCommand cmd = new SqlCommand(resetQuery, conn))
            {
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your password has been successfully reset.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while resetting the password.");
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            newPasswordTextBox.Visible = false;
            confirmResetButton.Visible = false;
            newPasswordLabel.Visible = false;
        }
    }
}