using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form10 : Form
    {
        private string userId;
        public Form10()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            cmbCurrency.Items.AddRange(new string[] { "EUR", "USD", "TRY", "SAR", "GBP" });
            cmbCurrency.SelectedIndex = 0;
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text.Trim();
            string currency = cmbCurrency.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(currency))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            string accountId = GenerateRandomId(15);
            DateTime createdOn = DateTime.Now;
            decimal initialBalance = 0m;
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO accounts (accountid, userid, accountname, accountcreatedon, currency, balance) " + "VALUES (@accountid, @userid, @accountname, @accountcreatedon, @currency, @balance)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@accountid", accountId);
                cmd.Parameters.AddWithValue("@userid", userId);
                cmd.Parameters.AddWithValue("@accountname", accountName);
                cmd.Parameters.AddWithValue("@accountcreatedon", createdOn);
                cmd.Parameters.AddWithValue("@currency", currency);
                cmd.Parameters.AddWithValue("@balance", initialBalance);
                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Account created successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private string GenerateRandomId(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(chars[random.Next(chars.Length)]);

            return sb.ToString();
        }
    }
}