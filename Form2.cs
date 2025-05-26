using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Umawi_Bank
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Form2()
        {
            InitializeComponent();
            hidepassword.CheckedChanged += new EventHandler(hidepassword_CheckedChanged);
            this.firstname.KeyPress += new KeyPressEventHandler(firstname_KeyPress);
            this.surname.KeyPress += new KeyPressEventHandler(surname_KeyPress);
            this.idnumber.KeyPress += new KeyPressEventHandler(idnumber_KeyPress);
            this.email.Validating += new CancelEventHandler(email_Validating);
            this.phonenumber.KeyPress += new KeyPressEventHandler(phonenumber_KeyPress);
            this.signupbutton.Click += new EventHandler(signupbutton_Click);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            countryCodeComboBox.Items.AddRange(new string[]
            {
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
            countryCodeComboBox.SelectedIndex = 0;
            birthcountryComboBox.Items.AddRange(new string[]
            {
                "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Argentina", "Armenia", "Australia", "Austria",
                "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin",
                "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso",
                "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile",
                "China", "Colombia", "Comoros", "Congo (Brazzaville)", "Congo (Kinshasa)", "Costa Rica", "Croatia", "Cuba",
                "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt",
                "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland",
                "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea",
                "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq",
                "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North",
                "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia",
                "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali",
                "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco",
                "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands",
                "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau",
                "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania",
                "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa",
                "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone",
                "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain",
                "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania",
                "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan",
                "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay",
                "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"
            });
            birthcountryComboBox.SelectedIndex = 0;
        }
        private void signupbutton_Click(object sender, EventArgs e)
        {
            string selectedCountryCode = countryCodeComboBox.SelectedItem.ToString().Split(' ')[0];
            string fullPhoneNumber = selectedCountryCode + phonenumber.Text;
            DateTime birthDate = birthdatePicker.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("You must be at least 18 years old to sign up.");
                return;
            }
            string passwordText = password.Text;
            List<string> passwordIssues = new List<string>();
            if (passwordText.Length < 8 || passwordText.Length > 16)
                passwordIssues.Add("• Password must be between 8 and 16 characters.");
            if (passwordText.ToLower().Contains(firstname.Text.ToLower()) || passwordText.ToLower().Contains(surname.Text.ToLower()))
                passwordIssues.Add("• Password cannot contain your first name or surname.");
            if (Regex.IsMatch(passwordText, @"\b(19[0-9]{2}|20[0-2][0-9])\b"))
                passwordIssues.Add("• Password cannot contain a birth year like 1990, 2000, etc.");
            if (passwordIssues.Count > 0)
            {
                MessageBox.Show("Invalid password:\n" + string.Join("\n", passwordIssues), "Password Format Error");
                return;
            }
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM signup WHERE id = @id OR email = @email OR [phone number] = @phone";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", idnumber.Text);
                    checkCmd.Parameters.AddWithValue("@email", email.Text);
                    checkCmd.Parameters.AddWithValue("@phone", fullPhoneNumber);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("ID number, email, or phone number is already in use.", "Duplicate Entry");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO signup (id, firstname, surname, email, birthdate, birthplace, [phone number], password) " +
                                     "VALUES (@id, @firstname, @surname, @email, @birthdate, @birthplace, @phone_number, @password)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idnumber.Text);
                    cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                    cmd.Parameters.AddWithValue("@surname", surname.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@birthdate", birthDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@birthplace", birthcountryComboBox.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@phone_number", fullPhoneNumber);
                    cmd.Parameters.AddWithValue("@password", passwordText);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("You signed up successfully!");
        }
        private void loginnavigator_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
        private void hidepassword_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !hidepassword.Checked;
        }
        private void phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }
        private void firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != '\b';
        }
        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != '\b';
        }
        private void idnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }
        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                e.Cancel = true;
            }
        }
        private void ribbonControl1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}