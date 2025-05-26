using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            LoadUserData();
            InitializeCountryCodes();
        }
        private void LoadUserData()
        {
            string userId = Form1.LoggedInUserId;
            SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                conn.Open();
                string query = "SELECT * FROM signup WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textEmail.Text = reader["email"].ToString();
                    textPhone.Text = "";
                    textPassword.Text = reader["password"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void InitializeCountryCodes()
        {
            countryCodeComboBox.Items.AddRange(new string[] {
                "+1", "+7", "+20", "+30", "+31", "+32", "+33", "+34", "+36", "+39", "+40", "+41", "+43", "+44",
                "+45", "+46", "+47", "+48", "+49", "+51", "+52", "+53", "+54", "+55", "+56", "+57", "+58", "+60",
                "+61", "+62", "+63", "+64", "+65", "+66", "+81", "+82", "+84", "+86", "+88", "+90", "+91", "+92",
                "+93", "+94", "+95", "+98", "+212", "+216", "+218", "+222", "+223", "+225", "+226", "+227", "+228",
                "+229", "+230", "+231", "+232", "+233", "+234", "+236", "+237", "+238", "+239", "+240", "+241", "+242",
                "+243", "+244", "+248", "+249", "+250", "+251", "+252", "+255", "+256", "+257", "+260", "+263", "+264",
                "+265", "+266", "+267", "+268", "+269", "+290", "+297", "+298", "+299", "+350", "+351", "+352", "+353",
                "+354", "+355", "+356", "+357", "+358", "+359", "+370", "+371", "+372", "+373", "+374", "+375", "+376",
                "+377", "+378", "+379", "+380", "+381", "+382", "+385", "+386", "+387", "+389", "+420", "+421", "+423",
                "+500", "+501", "+502", "+503", "+504", "+505", "+506", "+507", "+509", "+590", "+591", "+593", "+595",
                "+596", "+597", "+598", "+670", "+672", "+674", "+675", "+676", "+677", "+678", "+679", "+680", "+682",
                "+683", "+685", "+686", "+687", "+688", "+690", "+691", "+692", "+850", "+852", "+853", "+855", "+856",
                "+880", "+886", "+962", "+963", "+964", "+965", "+966", "+967", "+968", "+970", "+971", "+972", "+973",
                "+974", "+975", "+976", "+977", "+992", "+993", "+994", "+995", "+996", "+998"
            });
        }
        private bool ValidateEmail(string email)
        {
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }
        private bool ValidatePassword(string password)
        {
            string userId = Form1.LoggedInUserId.ToLower();
            string firstName = GetUserFirstName(userId).ToLower();
            if (password.ToLower().Contains(userId))
            {
                MessageBox.Show("Password should not contain your username.");
                return false;
            }
            if (password.ToLower().Contains(firstName))
            {
                MessageBox.Show("Password should not contain your first name.");
                return false;
            }
            var birthYearRegex = new Regex(@"\b(19|20)\d{2}\b");
            if (birthYearRegex.IsMatch(password))
            {
                MessageBox.Show("Password should not contain any birth year (4-digit year between 1900-2023).");
                return false;
            }
            if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters.");
                return false;
            }
            return true;
        }
        private string GetUserFirstName(string userId)
        {
            string firstName = string.Empty;
            SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                conn.Open();
                string query = "SELECT firstname FROM signup WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    firstName = reader["firstname"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return firstName;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (countryCodeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a country code.");
                countryCodeComboBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPhone.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                textPhone.Focus();
                return;
            }
            string email = textEmail.Text;
            string phone = countryCodeComboBox.SelectedItem.ToString() + textPhone.Text;
            string password = textPassword.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                textEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                textPassword.Focus();
                return;
            }
            if (!ValidateEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (!ValidatePassword(password))
            {
                MessageBox.Show("Password must be between 8-16 characters and contain at least one uppercase letter, one lowercase letter, and one number. It should not contain your username, first name, or a birth year.");
                return;
            }
            SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                conn.Open();
                string query = "UPDATE signup SET email = @email, [phone number] = @phone, password = @password WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Form1.LoggedInUserId);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@password", password);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully.");
                }
                else
                {
                    MessageBox.Show("No changes were made.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}